using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using boneSigils.Managers;

namespace boneSigils.Encounters
{
    internal class BeetleRush
    {
        // Token: 0x0600002F RID: 47 RVA: 0x0000310C File Offset: 0x0000130C
        public static void AddEncounter()
        {
            string name = "BeetleRush";
            string regionName = "Wetlands";
            List<Tribe> list = new List<Tribe>();
            list.Add((Tribe)6);
            List<Ability> redundant = new List<Ability>();
            bool regionLocked = true;
            List<CardInfo> randomReplacementCards = EncounterHelper.AddRandomCards("Cockroach", "Mole", "void_Beetle_Carrion", "none", "none", "none", "none", "none", "none");
            List<List<EncounterBlueprintData.CardBlueprint>> list2 = new List<List<EncounterBlueprintData.CardBlueprint>>();
            List<EncounterBlueprintData.CardBlueprint> list3 = new List<EncounterBlueprintData.CardBlueprint>();
            list3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Beetle_Larva"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Scarab_Jewel"),
                randomReplaceChance = 10
            });
            list3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Beetle_Larva"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Rhino_beetle"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> item = new List<EncounterBlueprintData.CardBlueprint>();
            List<EncounterBlueprintData.CardBlueprint> list4 = new List<EncounterBlueprintData.CardBlueprint>();
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Beetle_Larva"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Beetle_Bombardier"),
                randomReplaceChance = 10
            });
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Beetle_Larva"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Scarab_Jewel"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> list5 = new List<EncounterBlueprintData.CardBlueprint>();
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Beetle_Larva"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Beetle_Bombardier"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> item2 = new List<EncounterBlueprintData.CardBlueprint>();
            List<EncounterBlueprintData.CardBlueprint> list6 = new List<EncounterBlueprintData.CardBlueprint>();
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Beetle_Larva"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Scarab_Jewel"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> list7 = new List<EncounterBlueprintData.CardBlueprint>();
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Beetle_Larva"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Rhino_beetle"),
                randomReplaceChance = 10
            });
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Beetle_Larva"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Scarab_Jewel"),
                randomReplaceChance = 10
            });
            list2.Add(list3);
            list2.Add(item);
            list2.Add(list4);
            list2.Add(list5);
            list2.Add(item2);
            list2.Add(list6);
            list2.Add(list7);
            EncounterBlueprintData encounterBlueprintData = EncounterHelper.BuildBlueprint(name, list, redundant, regionLocked, 0, 30, randomReplacementCards, list2);
            EncounterManager.Add(encounterBlueprintData);
            RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), new EncounterBlueprintData[]
            {
                encounterBlueprintData
            });
        }
    }
}