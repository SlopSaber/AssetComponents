# AssetComponents

Beat Saber class library for components used on custom sabers.

`AssetComponents.csproj` builds the current library. `Legacy/SaberComponents/SaberComponents.csproj` builds `SaberComponents.dll` for existing `.saber2` assets that reference the old assembly. Build each project separately. Set `DisableCopyToGame=true` to keep a build out of the game installation.

## Building

Create a `AssetComponents.csproj.user` file in the same directory as `AssetComponents.csproj`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project>
  <PropertyGroup>
    <BeatSaberDir><!-- Path to the target Beat Saber install --></BeatSaberDir>
    <UnityProjDir><!-- Path to the custom sabers unity project --></UnityProjDir>
  </PropertyGroup>
</Project>
```
