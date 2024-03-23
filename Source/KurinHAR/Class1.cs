using System.Collections.Generic;
using RimWorld;
using Verse;
using UnityEngine;
/// using HarmonyLib;
using HugsLib.Core;
using HugsLib;
using HugsLib.Settings;
using HugsLib.Utils;

namespace KurinHAR
{
	public class KurinSettings : ModSettings
	{

		public override string ModIdentifier
		{
			get { return "KurinSettings"; }
		}
		public static bool toggle;

		//Log.Warning("Endgame Buildings" + ": Settings loaded.");
		public override void DefsLoaded()
		{
			toggle = Settings.GetHandle<bool>(
				"myToggle",
				"Allow Kurin to wear any clothing".Translate(),
				"Toggle on to enable clothing race restrictions on Kurin pawns".Translate(),
				false);
		}

		public override void ExposeData()
		{
		}
	}
}
