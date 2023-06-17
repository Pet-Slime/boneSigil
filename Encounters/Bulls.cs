using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using boneSigils.Managers;

namespace boneSigils.Encounters
{
    internal class Bulls
    {
        // Token: 0x06000033 RID: 51 RVA: 0x00003758 File Offset: 0x00001958
        public static void AddEncounter()
        {
            string name = "BullRush";
            string regionName = "Alpine";
            List<Tribe> list = new List<Tribe>
            {
                DiskCardGame.Tribe.Hooved
            };
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)3);
            bool regionLocked = true;
            List<CardInfo> randomReplacementCards = EncounterHelper.AddRandomCards("Elk", "ElkCub", "Mole", "Wolf", "WolfCub", "none", "none", "none", "none");
            List<List<EncounterBlueprintData.CardBlueprint>> list3 = new List<List<EncounterBlueprintData.CardBlueprint>>();
            List<EncounterBlueprintData.CardBlueprint> list4 = new List<EncounterBlueprintData.CardBlueprint>();
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy")
            });
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Mad"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Cow_Wild"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list5 = new List<EncounterBlueprintData.CardBlueprint>();
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list6 = new List<EncounterBlueprintData.CardBlueprint>();
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list7 = new List<EncounterBlueprintData.CardBlueprint>();
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Mad"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Cow_Wild"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list8 = new List<EncounterBlueprintData.CardBlueprint>();
            list8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list9 = new List<EncounterBlueprintData.CardBlueprint>();
            list9.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list10 = new List<EncounterBlueprintData.CardBlueprint>();
            list10.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Mad"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Cow_Wild"),
                randomReplaceChance = 25
            });
            list3.Add(list4);
            list3.Add(list5);
            list3.Add(list6);
            list3.Add(list7);
            list3.Add(list8);
            list3.Add(list9);
            list3.Add(list10);
            EncounterBlueprintData encounterBlueprintData = EncounterHelper.BuildBlueprint(name, list, list2, regionLocked, 0, 30, randomReplacementCards, list3);
            EncounterManager.Add(encounterBlueprintData);
            RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), new EncounterBlueprintData[]
            {
                encounterBlueprintData
            });
        }
    }
}
