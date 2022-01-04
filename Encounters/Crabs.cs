using System;
using System.Collections.Generic;
using BepInEx;
using BepInEx.Logging;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils.Encounters
{
    internal class Crabs
    {
		public static void AddEncounter()
		{
            //Name of the encounter
            string name = "CrabStall";

            //Vanilla region names are: Forest, Wetlands, and Alpine
            string regionName = "Wetlands";

            //What is the most common tribe?
            List<Tribe> dominate = new List<Tribe>();
            dominate.Add(Tribe.Bird);

            //Are any abilities redundent? Thus shouldnt be used on a totem
            List<Ability> redundant = new List<Ability>();
            redundant.Add(Ability.Submerge);

            //Is this encounter locked to a region?
            bool regionLocked = false;

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = EncounterUtil.BuildEncounter(
                "Void_Crab_Spider", "none",
                "Kingfisher", "none", 
                "none", "Void_Crab_Spider",
                "none", "Kingfisher",
                "Void_Crab_Spider", "none");

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterUtil.AddRandomCards("Kingfisher", "Kingfisher", "Void_Mantis_Shrimp", "Shark");

            List<EncounterBlueprintData.TurnModBlueprint> difficultyMod = new List<EncounterBlueprintData.TurnModBlueprint>();
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Coco_Crab"), applyAtDifficulty = 13, turn = 2 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Coco_Crab"), applyAtDifficulty = 13, turn = 4 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Crab_Fiddler"), applyAtDifficulty = 17, turn = 1 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Crab_Fiddler"), applyAtDifficulty = 17, turn = 5 });

            NewEncounter.Add(
                        name,
                        regionName,
                        difficultyMod,
                        dominate,
                        redundant,
                        unlockedCardPrerequisites: null,
                        regionLocked,
                        minDifficulty: 1,
                        maxDifficulty: 30,
                        randomReplacements,
                        turns,
                        regular: true,
                        bossPrep: false,
                        oldPreviewDifficulty: 0);
        }

        
	}
}
