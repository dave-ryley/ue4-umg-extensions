using UnrealBuildTool;

public class UMGExtensions : ModuleRules
{
    public UMGExtensions(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] {"UMG"});
        PrivateDependencyModuleNames.AddRange(new string[] {"Core", "Slate", "SlateCore"});
    }
}
