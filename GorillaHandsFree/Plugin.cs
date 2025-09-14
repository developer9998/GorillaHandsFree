using BepInEx;
using HarmonyLib;
using Utilla.Attributes;

namespace GorillaDistantHands
{
    [ModdedGamemode, BepInDependency("org.legoandmars.gorillatag.utilla")]
    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public static bool Enabled, InModdedRoom;

        public void Awake() => Harmony.CreateAndPatchAll(typeof(Plugin).Assembly, Constants.GUID);

        public void OnEnable() => Enabled = true;

        public void OnDisable() => Enabled = false;

        [ModdedGamemodeJoin]
        public void OnJoin() => InModdedRoom = true;

        [ModdedGamemodeLeave]
        public void OnLeave() => InModdedRoom = false;
    }
}
