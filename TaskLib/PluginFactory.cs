using System;

namespace lib.test.impl
{
    /// <summary>
    /// Требование к классу Plugins
    /// </summary>
    //Не используется напрямую, т.к Plugins - статический класс
    interface PluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
