global using Il2CppInterop.Runtime;
global using Il2CppInterop.Runtime.Attributes;
global using Il2CppInterop.Runtime.InteropTypes;
global using Il2CppInterop.Runtime.InteropTypes.Arrays;
global using Il2CppInterop.Runtime.Injection;

using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;
using TMPro;

namespace Febigle;

[BepInPlugin(FEBIGLE_MOD_ID, FEBIGLE_GUID, FEBIGLE_MOD_VERSION)]
[BepInProcess("Among Us.exe")]
public partial class FebiglePlugin : BasePlugin
{
    public const string FEBIGLE_MOD_ID = "jp.AUMaps.Febigle";
    public const string FEBIGLE_MOD_VERSION = "0.0.1";
    public const string FEBIGLE_GUID = "Febigle";
    public const string FEBIGLE_COLOR_CODE = "";
    public const ShipStatus.MapType FEBIGLE_MAP_TYPE = (ShipStatus.MapType)6;
    internal static BepInEx.Logging.ManualLogSource Logger;

    public Harmony Harmony { get; } = new(FEBIGLE_MOD_ID);
    public static FebiglePlugin Instance;

    public override void Load()
    {
        Logger = Log;
        Instance = this;

        Harmony.PatchAll();
    }
}