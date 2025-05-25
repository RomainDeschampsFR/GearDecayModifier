using HarmonyLib;
using MelonLoader;
using Il2Cpp;

namespace GearDecayModifier
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Degrade), new Type[] { typeof(float) })]
    internal class GearItem_Degrade
    {
        private static void Prefix(GearItem __instance, ref float hp)
        {
            float decay_multiplier = Main.ApplyDecayModifier(__instance);

            hp *= decay_multiplier;
        }
    }

    [HarmonyPatch(typeof(GearItem), nameof(GearItem.DecayOverTODHours), new Type[] { typeof(float), typeof(float) })]
    internal class GearItem_DecayOverTODHours
    {
        private static void Prefix(GearItem __instance, float deltaTODHours, float scale)
        {
            MelonLogger.Msg("DecayOverTODHours called");
        }
    }
}
