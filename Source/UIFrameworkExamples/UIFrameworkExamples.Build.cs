// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UIFrameworkExamples : ModuleRules
{
	public UIFrameworkExamples(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule", "UMGExtensions" });
    }
}
