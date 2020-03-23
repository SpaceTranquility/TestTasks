using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace TaskSQL
{
    public partial class MainForm : Form
    {
        DataSet ds;
        DataView dv;
        SqlDataAdapter adapter;
        string connectionString = ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString;
        bool started = false; //Ключ, что все компоненты инициализированы b vj;yj наинать
        string sqlStoredProc = "PersonsList";// название хранимой процедуры
        //Сама процедура в папке проекта 
        
        public MainForm()
        {
            
            InitializeComponent();
            dateTimePicker_To.Value = System.DateTime.Now;
            
            //Мелкие подстройки формы
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AllowUserToAddRows = false;

            //Подключение и получение БД
            ConnectServer(connectionString);
        }

        void ConnectServer(string conString)
        {
            // Создание подключения
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                // Открываем подключение
                connection.Open();

                //Выгрузка таблицы из БД
                SqlCommand command = new SqlCommand(sqlStoredProc, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                ds = new DataSet();
                adapter.Fill(ds);

                //Списки Для фильтрации
                comboBox_Status.Items.AddRange(TakeVariantArray(ds, "Статус"));
                comboBox_Post.Items.AddRange(TakeVariantArray(ds, "Должность"));
                comboBox_Dep.Items.AddRange(TakeVariantArray(ds, "Отдел"));

                // Отображение таблицы
                button_Reset_Click(null, null); //Чтобы меньше было кода
            }

            catch (SqlException ex)
            {
                groupBox_Connect.Visible = true;
                TextBox_Conection.Clear();
            }
            finally
            {
                // закрываем подключение
                connection.Close();
            }
        }

        //Получение списка возможных значений столбца
        string[] TakeVariantArray(DataSet dataSet, string nameCol)
        {
            List<string> StatusList = new List<string>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
                StatusList.Add((string)row[nameCol]);
            StatusList = StatusList.Distinct().ToList();
            return StatusList.ToArray();
        }
        
        //Обновление статистики
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        { ReNewStatistic(); }
        private void checkBox_unemploy_CheckedChanged(object sender, EventArgs e)
        { ReNewStatistic(); }        
        private void dateTimePickers_ValueChanged(object sender, EventArgs e)
        { ReNewStatistic(); }
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        { ReNewStatistic(); }

        void ReNewStatistic()
        {
            if (!started) return;
            //Обновление статистики
            string filter = "";
            if (comboBox_Status.SelectedIndex != 0) //Статус
                filter += "[Статус] = '" + comboBox_Status.SelectedItem + "' AND "; 
            if (comboBox_employ.SelectedIndex != 0) //Принят/Уволен
                filter += "[" + comboBox_employ.SelectedItem + "] IS NOT NULL " +                                                                                     
                    "AND [" + comboBox_employ.SelectedItem + "] >= #" + dateTimePicker_From.Value.ToString("MM.dd.yyyy") + 
                    "# AND [" + comboBox_employ.SelectedItem + "] <= #" + dateTimePicker_To.Value.ToString("MM.dd.yyyy") + "# AND ";
            if (comboBox_Dep.SelectedIndex != 0)    //Отдел 
                filter += "[Отдел] = '" + comboBox_Dep.SelectedItem + "' AND ";
            if (comboBox_Post.SelectedIndex != 0)   //Должность
                filter += "[Должность] = '" + comboBox_Post.SelectedItem + "' AND ";
            if (textBox_Search.TextLength > 0)   //Фильтрация по фамилии
                filter += "[Ф.И.О.] LIKE ('%" + textBox_Search.Text + "%') AND ";

            filter += " TRUE"; //Чтобы AND в конце строк ничего не сломал

            dv = new DataView(ds.Tables[0]);
            dv.RowFilter = filter;
            dv.Sort = "Ф.И.О. ASC";
            dataGridView.DataSource = dv; //Результат таблицей

            //Результат цифрой
            label_Found.Text = "Найдено " + dv.Count + " записей.";
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            comboBox_Status.SelectedIndex = 0;
            comboBox_employ.SelectedIndex = 0;
            comboBox_Dep.SelectedIndex = 0;
            comboBox_Post.SelectedIndex = 0;
            textBox_Search.Clear();
            started = true;
            //Вывод всей таблицы
            dv = new DataView(ds.Tables[0]);
            dataGridView.DataSource = dv;
            label_Found.Text = "Всего найдено " + dv.Count + " записей.";
            
        }

        private void TextBox_Conection_Enter(object sender, EventArgs e)
        {
            if (TextBox_Conection.Text == "Строка подключения") TextBox_Conection.Clear();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(TextBox_Conection.Text);
                connection.Open();
                // Еслы не выброшено исключение вызываем основную функцию
                connection.Close();
                groupBox_Connect.Visible = false;
                ConnectServer(TextBox_Conection.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
