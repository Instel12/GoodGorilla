using HarmonyLib;

namespace GoodGorilla
{
    [HarmonyPatch(typeof(VRRig), nameof(VRRig.NormalizeName))]
    class Patch
    {
        static bool Prefix(bool doIt, string text, ref string __result)
        {
            __result = text;
            return false;
        }
    }
}
