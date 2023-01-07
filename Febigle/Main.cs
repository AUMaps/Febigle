global using Il2CppInterop.Runtime;
global using Il2CppInterop.Runtime.Attributes;
global using Il2CppInterop.Runtime.InteropTypes;
global using Il2CppInterop.Runtime.InteropTypes.Arrays;
global using Il2CppInterop.Runtime.Injection;

global using BepInEx;
global using BepInEx.Configuration;
global using BepInEx.Unity.IL2CPP;
global using HarmonyLib;
global using Hazel;
global using System.Collections.Generic;
global using System.Linq;
global using System;
global using System.IO;
global using UnityEngine;
global using Febigle.Debug;
global using Object = UnityEngine.Object;

namespace Febigle;

[BepInPlugin(Id, "Febigle", Version)]
[BepInProcess("Among Us.exe")]
public partial class FebiglePlugin : BasePlugin
{
    public const string Id = "jp.AUMaps.Febigle";
    public const string Version = "0.0.1";
    internal static BepInEx.Logging.ManualLogSource Logger;

    public Harmony Harmony { get; } = new(Id);
    public static FebiglePlugin Instance;

    public override void Load()
    {
        Logger = Log;
        Instance = this;
        Harmony.PatchAll();
    }
}