// © 2023 Will Roberts

using UnrealBuildTool;
using System.Collections.Generic;

public class StreetsFPSTarget : TargetRules
{
	public StreetsFPSTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "StreetsFPS" } );
	}
}
