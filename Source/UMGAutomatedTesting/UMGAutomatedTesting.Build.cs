using UnrealBuildTool;

public class UMGAutomatedTesting : ModuleRules
{
	public UMGAutomatedTesting(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// PublicDependencyModuleNames.AddRange(new string[] {"UMG", "Slate", "SlateCore"});
		PrivateDependencyModuleNames.AddRange(new string[] {"Core", "UMG", "Slate", "SlateCore", "UMGExtensions"});
	}
}
