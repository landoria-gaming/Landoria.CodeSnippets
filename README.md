# Landoria.CodeSnippets

Reusable source snippets for Landoria Valheim mods.

## Usage

```xml
<Import Project="..\Landoria.CodeSnippets\Landoria.CodeSnippets.targets" />
```

```csharp
using Landoria.Shared;

ConfigWatcher.Initialize(
    Config,
    Logger,
    "Mod Name",
    () => Preference.RestoreDefaults(Config));

private void Update()
{
    ConfigWatcher.Update();
}

private void OnDestroy()
{
    ConfigWatcher.Dispose();
}
```
