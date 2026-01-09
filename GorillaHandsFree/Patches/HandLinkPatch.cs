using HarmonyLib;

namespace GorillaHandsFree.Patches
{
    [HarmonyPatch(typeof(TakeMyHand_HandLink), nameof(TakeMyHand_HandLink.SliceUpdate))]
    internal class HandLinkPatch
    {
        public static bool Prefix(TakeMyHand_HandLink __instance)
        {
            if (Plugin.Enabled && Plugin.InModdedRoom)
            {
                __instance.interactionPoint?.enabled = false;
                return false;
            }

            return true;
        }
    }
}
