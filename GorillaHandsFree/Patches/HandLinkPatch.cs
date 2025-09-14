using HarmonyLib;

namespace GorillaDistantHands.Patches
{
    [HarmonyPatch(typeof(HandLink), nameof(HandLink.SliceUpdate))]
    internal class HandLinkPatch
    {
        public static bool Prefix(HandLink __instance)
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
