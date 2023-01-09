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
        GameObject gameObject = new("FebigleVersionText");
        gameObject.transform.parent = vs.transform.parent;
        TextMeshPro tmp = gameObject.AddComponent<TextMeshPro>();
        tmp.text = FebiglePlugin.FEBIGLE_GUID + " Ver." + FebiglePlugin.FEBIGLE_MOD_VERSION;
        tmp.fontSize = vs.text.fontSize;
        tmp.alignment = TextAlignmentOptions.Right;
        tmp.transform.localPosition = new(-10f - vs.transform.position.x, vs.transform.position.y, vs.transform.position.z);

        ModLogger.Info("Mod Version Shower is activated!", "[Version Shower]");
    }
}