
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;
using System.Linq;

namespace RemoteKeycard2
{

    public class Plugin
    {
        public static Plugin Singleton;

        [PluginConfig]
        public Config Config;

        private const string Version = "0.0.1";

        [PluginEntryPoint("RemoteKeycard2", Version, "NWAPI rewrite of RemoteKeycard", "Jonathan Moore")]
        void LoadPlugin()
        {
            Singleton = this;
            EventManager.RegisterEvents(this, new EventHandlers());
            Log.Warning($"RemoteKeycard2 {Version} fully loaded");
        }

    }
}