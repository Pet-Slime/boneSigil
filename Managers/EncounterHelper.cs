using DiskCardGame;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace boneSigils.Managers
{
    public class EncounterHelper
    {
        public static EncounterBlueprintData BuildBlueprint(string name, List<Tribe> tribes, List<Ability> redundant, bool regionLocked, int minDifficulty, int maxDifficulty, List<CardInfo> randomReplacementCards, List<List<EncounterBlueprintData.CardBlueprint>> blueprintTurns)
        {
            EncounterBlueprintData encounterBlueprintData = ScriptableObject.CreateInstance<EncounterBlueprintData>();
            encounterBlueprintData.name = name;
            encounterBlueprintData.regionSpecific = regionLocked;
            encounterBlueprintData.SetDifficulty(minDifficulty, maxDifficulty);
            encounterBlueprintData.dominantTribes = tribes;
            encounterBlueprintData.redundantAbilities = redundant;
            encounterBlueprintData.randomReplacementCards = randomReplacementCards;
            encounterBlueprintData.turns = blueprintTurns;
            return encounterBlueprintData;
        }


        public static CardInfo GetCardInfo(string self)
        {
            return CardLoader.GetCardByName(self);
        }


        public static RegionData GetRegionData(string RegionName)
        {
            RegionData result = RegionManager.BaseGameRegions[0];
            for (int i = 0; i < RegionManager.BaseGameRegions.Count; i++)
            {
                bool flag = RegionManager.BaseGameRegions[i].name == RegionName;
                if (flag)
                {
                    result = RegionManager.BaseGameRegions[i];
                }
            }
            return result;
        }


        public static List<CardInfo> AddRandomCards(params string[] turns)
        {
            List<CardInfo> list = new List<CardInfo>();

            foreach (string turn in turns)
            {
                if (turn != "none")
                {
                    list.Add(CardLoader.GetCardByName(turn));
                }
            }

            return list;
        }
    }
}