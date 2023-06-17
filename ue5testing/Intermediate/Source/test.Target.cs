using UnrealBuildTool;

public class testTarget : TargetRules
{
	public testTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("test");
	}
}
