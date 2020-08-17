using System;

namespace lib.test.impl
{
    /// <summary>
    /// Целочисленные математические операции
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Название операции. 
        /// </summary>
        string PluginName { get; }

        /// <summary>
        /// Версия библиотеки
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Изображение знака операции 32х32
        /// </summary>
        System.Drawing.Image Image { get; }

        /// <summary>
        /// Описание операции
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Выполнение операции.
        /// </summary>
        /// <param name="input1">Первый целочисленный операнд</param>
        /// <param name="input2">Второй целочисленный операнд</param>
        /// <returns>Целочисленный результат</returns>
        int Run(int input1, int input2);

    }
}