using UnrealBuildTool;

public class UMGAutomatedTesting : ModuleRules
{
	public UMGAutomatedTesting(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// PublicDependencyModuleNames.AddRange(new string[] {"UMG", "Slate", "SlateCore"});
		PrivateDependencyModuleNames.AddRange(new string[] {"Core"});

		//The path for the header files
		PublicIncludePaths.AddRange(new string[] {"UMGAutomatedTesting/Public"});

		//The path for the source files
		PrivateIncludePaths.AddRange(new string[] {"UMGAutomatedTesting/Private"});
	}
}
