using System;

namespace lib.test.impl
{
    abstract class Operation : IPlugin
    {
        /// <summary>
        /// Общая версия библиотеки
        /// </summary>
        public string Version => "1.0";

        public string PluginName { get; }

        public string Description { get; }

        public abstract int Run(int input1, int input2);

        public System.Drawing.Image Image { get; }

        /// <summary>
        /// Определение основных свойств операции
        /// </summary>
        /// <param name="pluginName">Название операции</param>
        /// <param name="description">Описание</param>
        /// <param name="image">Иконка операции (необязательно)</param>
        public Operation(string pluginName, string description, System.Drawing.Image image = null)
        {
            PluginName = pluginName;
            Description = description;
            Image = image;
        }

        //Строка ошибки
        protected string MesResOutOfInt = String.Format("Результат вышел за пределы" +
            " допустимых значений типа int [{0} : {1}]", Int32.MinValue, Int32.MaxValue);
    }
}
