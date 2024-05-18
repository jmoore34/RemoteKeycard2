
using InventorySystem.Items;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;
using System.Diagnostics;
using System.Linq;

namespace RemoteKeycard2
{
    public class EventHandlers {

        [PluginEvent(ServerEventType.PlayerInteractDoor)]
        public bool OnInteractingDoor(PlayerInteractDoorEvent ev) {
            ev.Player.SendBroadcast("D O O R", 3);
            foreach (ItemBase item in ev.Player.Items) {
                if (ev.Door.RequiredPermissions.CheckPermissions(item, ev.Player.ReferenceHub)) {
                    ev.Player.SendBroadcast("A C C E S S", 3);
                    return false;
                }
            }
            return ev.CanOpen;
        }
     }
}