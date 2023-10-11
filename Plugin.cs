using BepInEx;
using BepInEx.Configuration;

namespace AlwaysSeeWardRadius;

[BepInPlugin(ModGUID, ModName, ModVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string
        ModName = "AlwaysSeeWardRadius",
        ModVersion = "1.1.0",
        ModGUID = $"com.{ModAuthor}.{ModName}",
        ModAuthor = "Frogger";

    public static ConfigEntry<bool> enabledConfig;

    private void Awake()
    {
        CreateMod(this, ModName, ModAuthor, ModVersion);
        enabledConfig = config("General", "Enabled", true, "");
    }
}