using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;
using Resources = boneSigils.Artwork.Resources;
using boneSigils.cards;


namespace boneSigils
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency(SigilGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(StarterdeckGUID, BepInDependency.DependencyFlags.SoftDependency)]
	public partial class Plugin : BaseUnityPlugin
	{
		public const string APIGUID = "cyantist.inscryption.api";
		public const string SigilGUID = "extraVoid.inscryption.voidSigils";
		public const string StarterdeckGUID = "zorro.inscryption.infiniscryption.sidedecks";
		public const string PluginGuid = "extraVoid.inscryption.void_bone_pack";
		private const string PluginName = "Void Bone Pack";
		private const string PluginVersion = "1.5.0";

		public static string Directory;
		internal static ManualLogSource Log;

		private void Awake()
		{
			Log = base.Logger;

			Harmony harmony = new(PluginGuid);
			harmony.PatchAll();


			AddDrawWasp();
			AddPupate();
			AddSigilsToBook();
			DairyCowSpecialAbility.AddSteakAbility();
			MurderOfCrowsSpecialAbility.AddMurderAbility();
			WaspSwarm.AddCard();
			DairyCow.AddCard();
			Steak.AddCard();
			PileOfBones.AddCard();
			MurderOfCrows.AddCard();
			TanukiPup.AddCard();
			BellTurtle.AddCard();
			BellTurtleBroken.AddCard();
			Scrap.AddCard();


		}
	}
}