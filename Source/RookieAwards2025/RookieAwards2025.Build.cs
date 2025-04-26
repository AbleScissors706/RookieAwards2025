// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RookieAwards2025 : ModuleRules
{
	public RookieAwards2025(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
