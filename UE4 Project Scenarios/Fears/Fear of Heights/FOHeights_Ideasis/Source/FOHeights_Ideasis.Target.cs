

using UnrealBuildTool;
using System.Collections.Generic;

public class FOHeights_IdeasisTarget : TargetRules
{
	public FOHeights_IdeasisTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "FOHeights_Ideasis" } );
	}
}
