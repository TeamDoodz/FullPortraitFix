using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DiskCardGame;
using HarmonyLib;

namespace FullPortraitFix.Patchers {
	[HarmonyPatch(typeof(FullCardPortrait))]
	[HarmonyPatch("ApplyAppearance")]
	static class MoreFullPortraitsPatch {

		private static void Postfix(FullCardPortrait __instance) {
			var card = __instance.GetComponent<Card>();

			PortraitType portraitType = PortraitTypeUtil.FromAppearance(card.Info.appearanceBehaviour);
			if(portraitType == PortraitType.Terrain) {
				MainPlugin.logger.LogInfo($"Card {card.Info.name} is a full-portrait terrain");
				card.RenderInfo.baseTextureOverride = MainPlugin.assets.LoadPNG("card_terrain_empty_nostats");
			}
		}

	}
}
