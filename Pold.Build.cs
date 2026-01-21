// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Pold : ModuleRules
{
	public Pold(ReadOnlyTargetRules Target) : base(Target)
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
			"Slate",
			"OnlineServicesInterface", 
	        "CoreOnline"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Pold",
			"Pold/Variant_Platforming",
			"Pold/Variant_Platforming/Animation",
			"Pold/Variant_Combat",
			"Pold/Variant_Combat/AI",
			"Pold/Variant_Combat/Animation",
			"Pold/Variant_Combat/Gameplay",
			"Pold/Variant_Combat/Interfaces",
			"Pold/Variant_Combat/UI",
			"Pold/Variant_SideScrolling",
			"Pold/Variant_SideScrolling/AI",
			"Pold/Variant_SideScrolling/Gameplay",
			"Pold/Variant_SideScrolling/Interfaces",
			"Pold/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
