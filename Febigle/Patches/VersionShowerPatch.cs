using HarmonyLib;
using UnityEngine;
using TMPro;
using Febigle.Debug;

namespace Febigle.Patches;

[HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
public static class VersionShowerPatch
{
    public static void Prefix(VersionShower __instance)
    {
        SetModVersionText(__instance);
    }

    private static void SetModVersionText(VersionShower vs)
    {
        var credits = Object.Instantiate(vs.text);
        credits.text = FebiglePlugin.FEBIGLE_GUID + " Ver." + FebiglePlugin.FEBIGLE_MOD_VERSION;
        credits.fontSize = vs.text.fontSize;
        credits.alignment = TextAlignmentOptions.Right;
        credits.transform.localPosition = new(-vs.transform.position.x, vs.transform.position.y, vs.transform.position.z);

        ModLogger.Info("Mod Version Shower is activated!", "[Version Shower]");
    }
}