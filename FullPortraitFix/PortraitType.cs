using System;
using System.Collections.Generic;
using System.Text;
using DiskCardGame;

namespace FullPortraitFix {
	public enum PortraitType {
		None,
		Rare,
		Terrain
	}
	public static class PortraitTypeUtil {
		public static PortraitType FromAppearance(List<CardAppearanceBehaviour.Appearance> appearances) {
			if (appearances.Contains(CardAppearanceBehaviour.Appearance.TerrainBackground)) return PortraitType.Terrain;
			if (appearances.Contains(CardAppearanceBehaviour.Appearance.RareCardBackground)) return PortraitType.Rare;
			return PortraitType.None;
		}
	}
}
