using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using HarmonyLib;
using boneSigils.cards;
using BepInEx.Configuration;


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
		public const string StarterdeckGUID = "zorro.inscryption.infiniscryption.kayceestarters";
		public const string PluginGuid = "extraVoid.inscryption.void_bone_pack";
		private const string PluginName = "Void Bone Pack";
		private const string PluginVersion = "2.0.0";

		public static string Directory;
		internal static ManualLogSource Log;


		internal static ConfigEntry<bool> configVanillaTweaks;


		private void Awake()
		{

			configVanillaTweaks = Config.Bind("Vanilla Tweaks", "Should they exist?", true, "Turn on or off the vanilla tweaks that the bone pack does.");


			Log = base.Logger;
			Directory = this.Info.Location.Replace("boneSigils.dll", "");

			Harmony harmony = new(PluginGuid);
			harmony.PatchAll();

			//Abilities
			AddDrawWasp();
			AddPupate();
			AddSigilsToBook();
			DairyCowSpecialAbility.AddSteakAbility();
			MurderOfCrowsSpecialAbility.AddMurderAbility();

			//Cards
			Angler.AddCard();
			Angler_Lure.AddCard();
			Ant_ArmorCutter.AddCard();
			Axolotl.AddCard();
			Bat.AddCard();
			Bear.AddCard();
			Beetle_Bombardier.AddCard();
			Beetle_Carrion.AddCard();
			Beetle_Larvae.AddCard();
			Beetle_Rhino.AddCard();
			Beetle_Scarab.AddCard();
			Bone_Lord.AddCard();
			Cow_Dairy.AddCard();
			Cow_Mad.AddCard();
			Cow_Skul.AddCard();
			Cow_Wild.AddCard();
			Crab_coco.AddCard();
			Crab_fiddler.AddCard();
			Crab_Leg.AddCard();
			Crab_Spider.AddCard();
			Dragon.AddCard();
			Egg.AddCard();
			Giraffe.AddCard();
			Mantis_Shrimp.AddCard();
			MurderOfCrows.AddCard();
			Owl_Familiar.AddCard();
			PileOfBones.AddCard();
			Rabbit.AddCard();
			Ruby_Creature.AddCard();
			Salmon.AddCard();
			Scrap.AddCard();
			Serpent_Jade.AddCard();
			Steak.AddCard();
			Stinkbug.AddCard();
			Tanuki.AddCard();
			Tanuki_Mythical.AddCard();
			Tanuki_Pup.AddCard();
			Tortoise_Bell.AddCard();
			Tortoise_Bell_Broken.AddCard();
			Tortoise_Long.AddCard();
			Tortoise_Small.AddCard();
			Tortoise_Spiny.AddCard();
			Vulture.AddCard();
			WaspSwarm.AddCard();
			Wolf.AddCard();
			Wolverine.AddCard();
		}

		private void Start()
		{
			if (configVanillaTweaks.Value)
            {
				Vanilla_Tweaks.AddCard();
			}
		}
	}
}