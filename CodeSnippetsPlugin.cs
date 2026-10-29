using BepInEx;

namespace Landoria.Shared
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public sealed class CodeSnippetsPlugin : BaseUnityPlugin
    {
        private const string PluginGuid = "Landoria.CodeSnippets";
        private const string PluginName = "Landoria.CodeSnippets";
        private const string PluginVersion = "1.0.1";

        private void Awake()
        {
            Logger.LogInfo($"{PluginName} {PluginVersion} is loaded.");
        }
    }
}
