using System;
using System.Collections.Generic;
using boneSigils.Managers;
using DiskCardGame;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;

namespace boneSigils.Encounters
{
    internal class BeaverStall
    {
        public static void AddEncounter()
        {
            string name = "BeaverStall";
            string regionName = "Forest";
            List<Tribe> list = new List<Tribe>
            {
                DiskCardGame.Tribe.Canine
            };
            List<Ability> redundant = new List<Ability>();
            bool regionLocked = true;
            List<CardInfo> randomReplacementCards = EncounterHelper.AddRandomCards("Wolf", "WolfCub", "Alpha", "none", "none", "none", "none", "none", "none");
            List<List<EncounterBlueprintData.CardBlueprint>> list2 = new List<List<EncounterBlueprintData.CardBlueprint>>();
            List<EncounterBlueprintData.CardBlueprint> list3 = new List<EncounterBlueprintData.CardBlueprint>();
            list3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam")
            });
            list3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam")
            });
            list3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam")
            });
            list3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam")
            });
            List<EncounterBlueprintData.CardBlueprint> list4 = new List<EncounterBlueprintData.CardBlueprint>();
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Beaver")
            });
            List<EncounterBlueprintData.CardBlueprint> list5 = new List<EncounterBlueprintData.CardBlueprint>();
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Beaver")
            });
            List<EncounterBlueprintData.CardBlueprint> list6 = new List<EncounterBlueprintData.CardBlueprint>();
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam"),
                randomReplaceChance = 25
            });
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list7 = new List<EncounterBlueprintData.CardBlueprint>();
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Beaver"),
                randomReplaceChance = 25
            });
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Beaver"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list8 = new List<EncounterBlueprintData.CardBlueprint>();
            list8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list9 = new List<EncounterBlueprintData.CardBlueprint>();
            list9.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam"),
                randomReplaceChance = 25
            });
            list9.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Beaver"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list10 = new List<EncounterBlueprintData.CardBlueprint>();
            list10.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Beaver"),
                randomReplaceChance = 25
            });
            list10.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list11 = new List<EncounterBlueprintData.CardBlueprint>();
            list11.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Dam"),
                randomReplaceChance = 25
            });
            list2.Add(list3);
            list2.Add(list4);
            list2.Add(list5);
            list2.Add(list6);
            list2.Add(list7);
            list2.Add(list8);
            list2.Add(list9);
            list2.Add(list10);
            list2.Add(list11);
            EncounterBlueprintData encounterBlueprintData = EncounterHelper.BuildBlueprint(name, list, redundant, regionLocked, 0, 30, randomReplacementCards, list2);
            EncounterManager.Add(encounterBlueprintData);
            RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), new EncounterBlueprintData[]
            {
                encounterBlueprintData
            });
        }
    }
}
