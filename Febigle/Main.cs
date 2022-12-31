global using Il2CppInterop.Runtime;
global using Il2CppInterop.Runtime.Attributes;
global using Il2CppInterop.Runtime.InteropTypes;
global using Il2CppInterop.Runtime.InteropTypes.Arrays;
global using Il2CppInterop.Runtime.Injection;

using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Hazel;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
using UnityEngine;

namespace Febigle;

[BepInPlugin(Id, "Febigle", VersionString)]
[BepInProcess("Among Us.exe")]
public partial class FebiglePlugin : BasePlugin
{
    public const string Id = "jp.AUMaps.Febigle";
    public const string VersionString = "0.0.1";
    public static Version Version = Version.Parse(VersionString);
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