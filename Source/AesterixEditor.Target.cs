

using UnrealBuildTool;
using System.Collections.Generic;

public class AesterixEditorTarget : TargetRules
{
	public AesterixEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Aesterix" } );
	}
}
