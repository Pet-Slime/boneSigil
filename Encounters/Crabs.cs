using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using boneSigils.Managers;

namespace boneSigils.Encounters
{
    internal class Crabs
    {
        // Token: 0x06000035 RID: 53 RVA: 0x000039FC File Offset: 0x00001BFC
        public static void AddEncounter()
        {
            string name = "CrabStall";
            string regionName = "Wetlands";
            List<Tribe> list = new List<Tribe>();
            list.Add(DiskCardGame.Tribe.Bird);
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)13);
            bool regionLocked = false;
            List<CardInfo> randomReplacementCards = EncounterHelper.AddRandomCards("void_Urchin_LongSpine", "void_Urchin_Flower", "void_Urchin_Sea", "void_Shrimp_Mantis", "none", "none", "none", "none", "none");
            List<List<EncounterBlueprintData.CardBlueprint>> list3 = new List<List<EncounterBlueprintData.CardBlueprint>>();
            List<EncounterBlueprintData.CardBlueprint> list4 = new List<EncounterBlueprintData.CardBlueprint>();
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Spider")
            });
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Kingfisher"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Crab_Coco"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list5 = new List<EncounterBlueprintData.CardBlueprint>();
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Leg"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Crab_Fiddler"),
                randomReplaceChance = 25
            });
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Leg"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Crab_Coco"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> item = new List<EncounterBlueprintData.CardBlueprint>();
            List<EncounterBlueprintData.CardBlueprint> list6 = new List<EncounterBlueprintData.CardBlueprint>();
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Leg"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Crab_Fiddler"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list7 = new List<EncounterBlueprintData.CardBlueprint>();
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Spider")
            });
            list3.Add(list4);
            list3.Add(list5);
            list3.Add(item);
            list3.Add(list6);
            list3.Add(list7);
            EncounterBlueprintData encounterBlueprintData = EncounterHelper.BuildBlueprint(name, list, list2, regionLocked, 0, 30, randomReplacementCards, list3);
            EncounterManager.Add(encounterBlueprintData);
            RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), new EncounterBlueprintData[]
            {
                encounterBlueprintData
            });
        }
    }
}
