using BepInEx;
using BepInEx.Logging;
using BepInEx.Configuration;
using System;
using TDLib.FileManagement;
using HarmonyLib;

namespace FullPortraitFix {
	[BepInPlugin(GUID, Name, Version)]
	[BepInDependency("io.github.TeamDoodz.TDLib")]
	public class MainPlugin : BaseUnityPlugin {

		internal const string GUID = "io.github.TeamDoodz." + Name;
		internal const string Name = "FullPortraitFix";
		internal const string Version = "1.0.0";

		internal static AssetManager assets;

		internal static ManualLogSource logger; // pogger

		private void Awake() {
			logger = Logger;
			logger.LogMessage($"{Name} v{Version} Loaded!");
			assets = new AssetManager(Info);
			new Harmony(GUID).PatchAll();
		}

	}
}
