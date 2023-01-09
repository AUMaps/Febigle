using LogLevel = BepInEx.Logging.LogLevel;

namespace Febigle.Debug;

public class ModLogger
{
    public static void Info(string Text, string Tag = "") => SendLog($"{Tag} " + Text, LogLevel.Info);
    public static void Error(string Text, string Tag = "") => SendLog($"{Tag} " + Text, LogLevel.Error);
    public static void Warning(string Text, string Tag = "") => SendLog($"{Tag} " + Text, LogLevel.Warning);
    public static void Fatal(string Text, string Tag = "") => SendLog($"{Tag} " + Text, LogLevel.Fatal);
    public static void Message(string Text, string Tag = "") => SendLog($"{Tag} " + Text, LogLevel.Message);
    public static void Debug(string Text, string Tag = "") => SendLog($"{Tag} " + Text, LogLevel.Debug);

    static void SendLog(string Text, LogLevel level = LogLevel.Info)
    {
        switch (level)
        {
            case LogLevel.Info:
                FebiglePlugin.Logger.LogInfo(Text);
                break;
            case LogLevel.Error:
                FebiglePlugin.Logger.LogError(Text);
                break;
            case LogLevel.Warning:
                FebiglePlugin.Logger.LogWarning(Text);
                break;
            case LogLevel.Fatal:
                FebiglePlugin.Logger.LogFatal(Text);
                break;
            case LogLevel.Message:
                FebiglePlugin.Logger.LogMessage(Text);
                break;
            case LogLevel.Debug:
                FebiglePlugin.Logger.LogDebug(Text);
                break;
            default:
                FebiglePlugin.Logger.LogWarning("This is Invalid Level Log");
                FebiglePlugin.Logger.LogInfo(Text);
                break;
        }
    }
}