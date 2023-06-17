using System;
using System.Collections.Generic;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using boneSigils.Artwork;
using boneSigils.cards;
using boneSigils.Cards;
using boneSigils.Encounters;
using boneSigils.Managers;
using DiskCardGame;
using HarmonyLib;
using InscryptionAPI.Card;
using UnityEngine;

namespace boneSigils
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency(SigilGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(StarterdeckGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency("extraVoid.inscryption.LifeCost", BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency("org.memez4life.inscryption.customsigils", BepInDependency.DependencyFlags.SoftDependency)]
	public partial class Plugin : BaseUnityPlugin
	{

        public const string APIGUID = "cyantist.inscryption.api";
        public const string SigilGUID = "extraVoid.inscryption.voidSigils";
        public const string StarterdeckGUID = "zorro.inscryption.infiniscryption.sidedecks";
        public const string PluginGuid = "extraVoid.inscryption.void_bone_pack";
        private const string PluginName = "Void Bone Pack";
        private const string PluginVersion = "3.0.0";
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
            //Plugin basics
            Plugin.Log = base.Logger;
            Plugin.Directory = base.Info.Location.Replace("boneSigils.dll", "");

            //Plugin Configs
            Plugin.configVanillaTweaks = base.Config.Bind<bool>("Vanilla Tweaks", "Should they exist?", true, "Turn on or off the vanilla tweaks that the bone pack does.");
            Plugin.configBullRush = base.Config.Bind<bool>("Encounters", "Bull Rush", true, "Turn on or off the encounter.");
            Plugin.configCrabRush = base.Config.Bind<bool>("Encounters", "Crab Stall", true, "Turn on or off the encounter.");
            Plugin.configBeetleRush = base.Config.Bind<bool>("Encounters", "Beetle Rush", true, "Turn on or off the encounter.");
            Plugin.configReptileKing = base.Config.Bind<bool>("Encounters", "Reptile King", true, "Turn on or off the encounter.");
            Plugin.configBeaverStall = base.Config.Bind<bool>("Encounters", "Beaver Stall", true, "Turn on or off the encounter.");
            Plugin.configPointCostMode = base.Config.Bind<bool>("Point Cost Mode", "Point Cost Mode", false, "Turn on to change the bone cost of every card to better follow the value the vanilla point system. This mod values blood at 4 points.");
            Plugin.configPointCostBonus = base.Config.Bind<int>("Point Cost Mode", "Point Cost Bonus", 0, "Change the value here to make cards more or less expensive in point cost mode");

            //Add Patches
            Harmony harmony = new Harmony("extraVoid.inscryption.void_bone_pack");
            harmony.PatchAll();

            //Add sigils
            this.AddDrawWasp();
            this.AddPupate();
            Plugin.AddSigilsToBook();

            //Add special abilities
            MurderOfCrowsSpecialAbility.specialAbility = SpecialTriggeredAbilityManager.Add("extraVoid.inscryption.void_bone_pack", "Crow Murder", typeof(MurderOfCrowsSpecialAbility)).Id;
            DairyCowSpecialAbility.specialAbility = SpecialTriggeredAbilityManager.Add("extraVoid.inscryption.void_bone_pack", "Fresh Steak", typeof(DairyCowSpecialAbility)).Id;
            
            //Add cards
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
            Tanuki.AddCard();
            Tanuki_Mythical.AddCard();
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
        }


        private void Start()
        {
            bool value = Plugin.configVanillaTweaks.Value;
            if (value)
            {
                Plugin.Log.LogMessage("Vanilla config fired 1");
                Vanilla_Tweaks.AddCard();
            }
            bool value2 = Plugin.configPointCostMode.Value;
            if (value2)
            {
                Point_Cost_Mode.AddCard();
            }
            bool value3 = Plugin.configBeetleRush.Value;
            if (value3)
            {
                BeetleRush.AddEncounter();
            }
            bool value4 = Plugin.configBullRush.Value;
            if (value4)
            {
                Bulls.AddEncounter();
            }
            bool value5 = Plugin.configCrabRush.Value;
            if (value5)
            {
                Crabs.AddEncounter();
            }
            bool value6 = Plugin.configReptileKing.Value;
            if (value6)
            {
                ReptileKing.AddEncounter();
            }
            bool value7 = Plugin.configBeaverStall.Value;
            if (value7)
            {
                BeaverStall.AddEncounter();
            }
            Vanilla_Tweaks.TryCreatePack();
            KCM_StartingDeck_Bones.AddStartingDeck();
        }
	}
}