// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class KP_remastered2Target : TargetRules
{
    public KP_remastered2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

        ExtraModuleNames.Add("UE4Game");
	}

	//
	// TargetRules interface.
	//

	public override void SetupGlobalEnvironment(
		TargetInfo Target,
		ref LinkEnvironmentConfiguration OutLinkEnvironmentConfiguration,
		ref CPPEnvironmentConfiguration OutCPPEnvironmentConfiguration
		)
	{
	}
}
