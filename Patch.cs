using HarmonyLib;

namespace GoodGorilla
{
    [HarmonyPatch(typeof(VRRig), nameof(VRRig.NormalizeName))]
    class Patch
    {
        static void Postfix(bool doIt, string text, ref string __result)
        {
            if (text.Length > 12)
            {
                __result = $"<color=blue>{text}</color>";
            }
            if (__result == "BADGORILLA")
            {
                __result = $"<color=red>{text}</color>";
            }
        }
    }
}