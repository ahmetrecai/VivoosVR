

using UnrealBuildTool;
using System.Collections.Generic;

public class FOHeights_IdeasisEditorTarget : TargetRules
{
	public FOHeights_IdeasisEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "FOHeights_Ideasis" } );
	}
}
