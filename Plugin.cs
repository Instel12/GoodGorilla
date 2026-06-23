using BepInEx;
using HarmonyLib;

namespace GoodGorilla
{
    [BepInPlugin("instel.goodgorilla", "GoodGorilla", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private Harmony harmony = new Harmony("instel.goodgorilla");

        public void Awake()
        {
            harmony = new Harmony("instel.goodgorilla");
            harmony.PatchAll();
        }

        public void OnDisable() => harmony.UnpatchSelf();
    }
}
