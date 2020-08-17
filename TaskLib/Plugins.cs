using System;

namespace lib.test.impl
{
    //-------------------------------------//   
    //Класс-контейнер
    /// <summary>
    /// Набор математических операций
    /// </summary>
    public static class Plugins
    {
        /// <summary>
        /// Список названий реализованных операций
        /// </summary>
        public static string[] GetPluginNames => new string[]
        { "Sum","Dif", "Mul", "Exp", "Div", "Mod" };

        /// <summary>
        /// Число реализованных операций
        /// </summary>
        public static int PluginsCount => GetPluginNames.Length;

        /// <summary>
        /// Получение экземпляра класса соответствующего операции
        /// </summary>
        /// <param name="pluginName">Имя опереции из списка GetPluginNames</param>
        /// <returns></returns>
        public static IPlugin GetPlugin(string pluginName)
        {
            switch (pluginName)
            {
                case "Sum":
                    return new Sum();
                case "Dif":
                    return new Dif();
                case "Mul":
                    return new Dif();
                case "Exp":
                    return new Exp();
                case "Div":
                    return new Div();
                case "Mod":
                    return new Mod();
                default:
                    return null;
            }
        }

        //-------------------------------------//
        //Определение операций     

        /// <summary>
        /// Сумма
        /// </summary>
        class Sum : Operation
        {
            public Sum() : base("Sum", "Суммирование. Operation Sum", Textures.Resources.sum) { }

            public override int Run(int a, int b)
            {
                return (a + b);
            }
        }

        /// <summary>
        /// Разность
        /// </summary>
        class Dif : Operation, IPlugin
        {
            public Dif() : base("Dif", "Вычитание. Operation Difference", Textures.Resources.dif) { }

            public override int Run(int a, int b)
            {
                return checked(a - b);
            }
        }

        /// <summary>
        /// Произведение
        /// </summary>
        class Mul : Operation, IPlugin
        {
            public Mul() : base("Mul", "Произведение. Operation Multiply", Textures.Resources.mul) { }

            public override int Run(int a, int b)
            {
                return checked(a * b);
            }
        }

        /// <summary>
        /// Возведение в степень (только положительную)
        /// </summary>
        class Exp : Operation, IPlugin
        {
            public Exp() : base("Exp", "Возведение в степень. Exponentiation", Textures.Resources.exp) { }

            public override int Run(int x, int n)
            {
                if (n >= 0)
                {
                    int result = 1;
                    for (int i = 0; i < n; i++)
                    {
                        result = checked(result * x);
                    }
                    return result;
                }
                else
                {
                    throw new Exception("Данный метод не может возвести в отрицательную степень");
                }
            }
        }

        /// <summary>
        /// Целая часть от деления
        /// При делении на 0, происходит системное прерывание
        /// и генерируется стандартное исключениие.
        /// Проверку на ввод 0 необходимо проводить при использовании функции.
        /// </summary>
        class Div : Operation, IPlugin
        {
            
            public Div() : base("Div", "Целая часть от деления. Integer part of the division", Textures.Resources.div) { }

            public override int Run(int a, int b)
            {
                return (int)(a / b);
            }
        }

        /// <summary>
        /// Остаток от деления
        /// При делении на 0, происходит прерывание
        /// и генерируется стандартное исключениие
        /// Проверку на ввод 0 необходимо проводить при использовании функции.
        /// </summary>
        class Mod : Operation, IPlugin
        {
            public Mod() : base("Mod", "Остаток от деления. Remainder of division", Textures.Resources.mod) { }

            public override int Run(int a, int b)
            {
                return a % b;
            }
        }
    }
}
