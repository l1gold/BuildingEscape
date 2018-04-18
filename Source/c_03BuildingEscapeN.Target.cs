// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class c_03BuildingEscapeNTarget : TargetRules
{
	public c_03BuildingEscapeNTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "c_03BuildingEscapeN" } );
	}
}
