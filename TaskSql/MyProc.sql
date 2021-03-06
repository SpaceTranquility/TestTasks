USE [TestTaskDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_report_1]    Script Date: 11.03.2020 18:29:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_report_1]
	@date_from date,
	@date_to date,
	@good_group_name nvarchar(MAX)
AS
BEGIN
	
	/*	---------------------------------------------
		--------------Постановка задачи--------------
		---------------------------------------------
		1. Заказчик утверждает, что продажи с НДС по сети, по группе товаров 'Биологически активные добавки',
				  в июне 2017 составили: 1 782 949.10 в рублях и 6761.10 в штуках.
			Процедура ETL исполнителя возвращает другие данные.
			Необходимо найти и устранить возможные причины расхождений.
			Пример запуска процедуры: 
				exec sp_report_1 @date_from = '2017-06-01', @date_to = '2017-06-30', @good_group_name = N'Биологически активные добавки'
			 
		2. В результат процедуры необходимо добавить показатели: 
				-Средняя цена закупки руб., без НДС
				-Маржа руб. без НДС
				-Наценка % без НДС
				
		3. Добавить возможность фильтрации по нескольким группам товаров одновременно. 
			Пример входных данных: 'Биологически активные добавки,Косметические средства'
			Пример запуска процедуры после модернизации: 
				exec sp_report_1 @date_from = '2017-06-01', @date_to = '2017-06-30', @good_group_name = 'Биологически активные добавки,Косметические средства'
			
		4. Вывести долю продаж товара в %, относительно общего объема продаж в рублях в разрезе день/магазин/группа товаров,
		 затем отсортировать выборку по убыванию показателя.
		
	*/
		
	declare @date_from_int int
	declare @date_to_int int
	
	set @date_from_int = (select top 1 did from dbo.dim_date where d = @date_from )
	set @date_to_int = (select top 1 did from dbo.dim_date where d = @date_to )
	
	Select Sum Продажи руб., с НДС from(

	SELECT d.d as [Дата],
		s.store_name as [Аптека],
		g.group_name as [Группа товара] ,
		g.good_name as [Номенклатура],
		sum(f.quantity) as [Продажи шт.],
		sum(f.sale_net) as [Продажи руб., с НДС],
		sum(f.cost_net) as [Закупка руб., с НДС]		
	FROM [dbo].[fct _cheque] as f
	inner join dim_goods as g
		on g.good_id = f.good_id
	inner join [dim_stores] as s
		on s.store_id = f.store_id
	inner join dim_date as d
		on d.did = f.date_id
	inner join dbo.dim_cash_register as cr
		on cr.cash_register_id = f.cash_register_id
	where date_id between @date_from_int and @date_to_int
		and g.group_name = @good_group_name
	group by d.d,
		s.store_name,
		g.group_name,
		g.good_name

	)
END
