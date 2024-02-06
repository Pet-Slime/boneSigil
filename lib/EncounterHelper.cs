﻿using System;
using System.Collections.Generic;
using System.Linq;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Encounters;

namespace boneSigils
{
    public class EncounterHelper
    {

        public static EncounterBlueprintData BuildBlueprint(string name, List<Tribe> tribes, List<Ability> redundant, bool regionLocked, int minDifficulty, int maxDifficulty,
            List<CardInfo> randomReplacementCards, List<List<EncounterBlueprintData.CardBlueprint>> blueprintTurns)
        {
            var blueprint = ScriptableObject.CreateInstance<EncounterBlueprintData>();
            blueprint.name = name;
            blueprint.regionSpecific = regionLocked;
            blueprint.SetDifficulty(minDifficulty, maxDifficulty);
            blueprint.dominantTribes = tribes;
            blueprint.redundantAbilities = redundant;
            blueprint.randomReplacementCards = randomReplacementCards;
            blueprint.turns = blueprintTurns;

            return blueprint;
        }


        public static CardInfo GetCardInfo(string self)
        {
            return CardLoader.GetCardByName(self);
        }


        public static RegionData GetRegionData(string RegionName)
        {
            RegionData region = InscryptionAPI.Regions.RegionManager.BaseGameRegions[0];

            for (var index = 0; index < InscryptionAPI.Regions.RegionManager.BaseGameRegions.Count; index++)
            {
                if (InscryptionAPI.Regions.RegionManager.BaseGameRegions[index].name == RegionName)
                {
                    region = InscryptionAPI.Regions.RegionManager.BaseGameRegions[index];
                }
            }

            return region;
        }


        public static EncounterBlueprintData GetBlueprintData(string EncounterName)
        {
            EncounterBlueprintData Encounter = InscryptionAPI.Encounters.EncounterManager.BaseGameEncounters[0];

            for (var index = 0; index < InscryptionAPI.Encounters.EncounterManager.BaseGameEncounters.Count; index++)
            {
                if (InscryptionAPI.Encounters.EncounterManager.BaseGameEncounters[index].name == EncounterName)
                {
                    Encounter = InscryptionAPI.Encounters.EncounterManager.BaseGameEncounters[index];
                }
            }

            return Encounter;
        }


        public static List<CardInfo> AddRandomCards(params string[] turns)
        {
            List<CardInfo> randomReplacements = new List<CardInfo>();

            foreach (string turn in turns)
            {
                if (turn != "none")
                {
                    randomReplacements.Add(CardLoader.GetCardByName(turn));
                }
                else
                {
                    return randomReplacements;
                }
            }

            return randomReplacements;
        }

    }
}