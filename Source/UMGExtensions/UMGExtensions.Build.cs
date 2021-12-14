using UnrealBuildTool;

public class UMGExtensions : ModuleRules
{
	public UMGExtensions(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// PublicDependencyModuleNames.AddRange(new string[] {"UMG"});
		PrivateDependencyModuleNames.AddRange(new string[] {"Core", "CoreUObject"});

		//The path for the header files
		PublicIncludePaths.AddRange(new string[] {"UMGExtensions/Public"});

		//The path for the source files
		PrivateIncludePaths.AddRange(new string[] {"UMGExtensions/Private"});
	}
}
