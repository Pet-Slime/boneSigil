using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using boneSigils.Managers;

namespace boneSigils.Encounters
{
    internal class BellTurtle
    {
        // Token: 0x06000031 RID: 49 RVA: 0x0000344C File Offset: 0x0000164C
        public static void AddEncounter()
        {
            string name = "BellTurtle";
            string regionName = "Wetlands";
            List<Tribe> list = new List<Tribe>();
            list.Add(DiskCardGame.Tribe.Reptile);
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)54);
            list2.Add((Ability)23);
            bool regionLocked = false;
            List<CardInfo> randomReplacementCards = EncounterHelper.AddRandomCards("void_Mole", "none", "none", "none", "none", "none", "none", "none", "none");
            List<List<EncounterBlueprintData.CardBlueprint>> list3 = new List<List<EncounterBlueprintData.CardBlueprint>>();
            List<EncounterBlueprintData.CardBlueprint> list4 = new List<EncounterBlueprintData.CardBlueprint>();
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Tortoise_Bell"),
                randomReplaceChance = 10
            });
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("TrapFrog"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> item = new List<EncounterBlueprintData.CardBlueprint>();
            List<EncounterBlueprintData.CardBlueprint> list5 = new List<EncounterBlueprintData.CardBlueprint>();
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("TrapFrog"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> list6 = new List<EncounterBlueprintData.CardBlueprint>();
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Tortoise_Bell"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> item2 = new List<EncounterBlueprintData.CardBlueprint>();
            List<EncounterBlueprintData.CardBlueprint> list7 = new List<EncounterBlueprintData.CardBlueprint>();
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Tortoise_Bell"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> list8 = new List<EncounterBlueprintData.CardBlueprint>();
            list8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("TrapFrog"),
                randomReplaceChance = 10
            });
            list8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Tortoise_Bell"),
                randomReplaceChance = 10
            });
            list3.Add(list4);
            list3.Add(item);
            list3.Add(list5);
            list3.Add(list6);
            list3.Add(item2);
            list3.Add(list7);
            list3.Add(list8);
            EncounterBlueprintData encounterBlueprintData = EncounterHelper.BuildBlueprint(name, list, list2, regionLocked, 0, 30, randomReplacementCards, list3);
            EncounterManager.Add(encounterBlueprintData);
            RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), new EncounterBlueprintData[]
            {
                encounterBlueprintData
            });
        }
    }
}