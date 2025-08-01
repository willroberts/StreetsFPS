// © 2023 Will Roberts

using UnrealBuildTool;
using System.Collections.Generic;

public class StreetsFPSEditorTarget : TargetRules
{
	public StreetsFPSEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "StreetsFPS" } );
	}
}
