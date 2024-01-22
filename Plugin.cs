using BepInEx;
using BepInEx.Logging;
using DiskCardGame;
using HarmonyLib;
using boneSigils.cards;
using BepInEx.Configuration;
using InscryptionAPI.Card;
using System;
using UnityEngine;
using boneSigils.Managers;

namespace boneSigils
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency(SigilGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(StarterdeckGUID, BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency(TotemGUID, BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("extraVoid.inscryption.LifeCost", BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency("org.memez4life.inscryption.customsigils", BepInDependency.DependencyFlags.SoftDependency)]

	public partial class Plugin : BaseUnityPlugin
	{
		public const string APIGUID = "cyantist.inscryption.api";
		public const string SigilGUID = "extraVoid.inscryption.voidSigils";
		public const string StarterdeckGUID = "zorro.inscryption.infiniscryption.sidedecks";
        public const string TotemGUID = "Lily.BOT";
        public const string PluginGuid = "extraVoid.inscryption.void_bone_pack";
		private const string PluginName = "Void Bone Pack";
		private const string PluginVersion = "5.0.0";

		public static string Directory;
		internal static ManualLogSource Log;


		internal static ConfigEntry<bool> configVanillaTweaks; 
		internal static ConfigEntry<bool> configBullRush; 
		internal static ConfigEntry<bool> configCrabRush;
		internal static ConfigEntry<bool> configBeetleRush;
		internal static ConfigEntry<bool> configReptileKing;
		internal static ConfigEntry<bool> configBeaverStall;
		internal static ConfigEntry<bool> configPointCostMode;
		internal static ConfigEntry<int> configPointCostBonus;


		private void Awake()
		{

			configVanillaTweaks = Config.Bind("Vanilla Tweaks", "Should they exist?", true, "Turn on or off the vanilla tweaks that the bone pack does.");
			configBullRush = Config.Bind("Encounters", "Bull Rush", true, "Turn on or off the encounter.");
			configCrabRush = Config.Bind("Encounters", "Crab Stall", true, "Turn on or off the encounter.");
			configBeetleRush = Config.Bind("Encounters", "Beetle Rush", true, "Turn on or off the encounter.");
			configReptileKing = Config.Bind("Encounters", "Reptile King", true, "Turn on or off the encounter.");
			configBeaverStall = Config.Bind("Encounters", "Beaver Stall", true, "Turn on or off the encounter.");
			configPointCostMode = Config.Bind("Point Cost Mode", "Point Cost Mode", false, "Turn on to change the bone cost of every card to better follow the value the vanilla point system. This mod values blood at 4 points.");
			configPointCostBonus = Config.Bind("Point Cost Mode", "Point Cost Bonus", 0, "Change the value here to make cards more or less expensive in point cost mode");


			Log = base.Logger;
			Directory = this.Info.Location.Replace("boneSigils.dll", "");

			Harmony harmony = new(PluginGuid);
			harmony.PatchAll();

			//Abilities
			AddDrawWasp();
			AddPupate();
			AddMadCowDiseasee();
			AddSigilsToBook();
			MurderOfCrowsSpecialAbility.specialAbility = SpecialTriggeredAbilityManager.Add(Plugin.PluginGuid, "Crow Murder", typeof(MurderOfCrowsSpecialAbility)).Id;
			DairyCowSpecialAbility.specialAbility = SpecialTriggeredAbilityManager.Add(Plugin.PluginGuid, "Fresh Steak", typeof(DairyCowSpecialAbility)).Id;



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
			Mole.AddCard();
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
			Enchidna.AddCard();
			Giraffe.AddCard();
			Mouse_Scared.AddCard();
			Mantis_Shrimp.AddCard();
			MurderOfCrows.AddCard();
			Owl_Familiar.AddCard();
			PileOfBones.AddCard();
			Rabbit.AddCard();
			Ray_Manta.AddCard();
			Ray_Torpedo.AddCard();
			Ruby_Creature.AddCard();
			Salmon.AddCard();
			Scrap.AddCard();
			Serpent_Jade.AddCard();
			Steak.AddCard();
			Stinkbug.AddCard();
            Tanuki_Mythical.AddCard();
            Tanuki.AddCard();
            Tanuki_Pup.AddCard();
            Tortoise_Bell.AddCard();
			Tortoise_Bell_Broken.AddCard();
			Tortoise_Long.AddCard();
			Tortoise_Small.AddCard();
			Tortoise_Spiny.AddCard();
			Urchin_Flower.AddCard();
			Urchin_LongSpine.AddCard();
			Urchin_Sea.AddCard();
			Vulture.AddCard();
			WaspSwarm.AddCard();
			Wolf.AddCard();
			Wolverine.AddCard();

			TestCard1.AddCard();
			TestCard2.AddCard();
			TestCard3.AddCard();
		}

		private void Start()
        {
			if (configVanillaTweaks.Value)
			{
				Log.LogMessage("Vanilla config fired 1");
				Vanilla_Tweaks.AddCard();
			}
			

			KCM_StartingDeck_Bones.AddStartingDeck();

			Vanilla_Tweaks.TryCreatePack();


			//Encounters

			if (configBeetleRush.Value)
			{
				Encounters.BeetleRush.AddEncounter();
			}
			if (configBullRush.Value)
			{
				Encounters.Bulls.AddEncounter();
			}
			if (configCrabRush.Value)
			{
				Encounters.Crabs.AddEncounter();
			}
			if (configReptileKing.Value)
			{
				Encounters.ReptileKing.AddEncounter();
			}
			if (configBeaverStall.Value)
			{
				boneSigils.Encounters.BeaverStall.AddEncounter();
			}

        }
	}
}