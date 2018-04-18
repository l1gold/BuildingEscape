// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class c_03BuildingEscapeNEditorTarget : TargetRules
{
	public c_03BuildingEscapeNEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "c_03BuildingEscapeN" } );
	}
}
