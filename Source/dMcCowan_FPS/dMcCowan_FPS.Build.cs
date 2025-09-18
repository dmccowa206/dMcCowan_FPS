// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class dMcCowan_FPS : ModuleRules
{
	public dMcCowan_FPS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"dMcCowan_FPS",
			"dMcCowan_FPS/Variant_Horror",
			"dMcCowan_FPS/Variant_Horror/UI",
			"dMcCowan_FPS/Variant_Shooter",
			"dMcCowan_FPS/Variant_Shooter/AI",
			"dMcCowan_FPS/Variant_Shooter/UI",
			"dMcCowan_FPS/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
