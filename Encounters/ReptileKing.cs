using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using boneSigils.Managers;

namespace boneSigils.Encounters
{
    internal class ReptileKing
    {
        // Token: 0x06000037 RID: 55 RVA: 0x00003C4C File Offset: 0x00001E4C
        public static void AddEncounter()
        {
            string name = "ReptileKing";
            string regionName = "Wetlands";
            List<Tribe> list = new List<Tribe>();
            list.Add(DiskCardGame.Tribe.Reptile);
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)4);
            bool regionLocked = true;
            List<CardInfo> randomReplacementCards = EncounterHelper.AddRandomCards("Skink", "Snapper", "Bullfrog", "none", "none", "none", "none", "none", "none");
            List<List<EncounterBlueprintData.CardBlueprint>> list3 = new List<List<EncounterBlueprintData.CardBlueprint>>();
            List<EncounterBlueprintData.CardBlueprint> list4 = new List<EncounterBlueprintData.CardBlueprint>();
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck")
            });
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("Rattler"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list5 = new List<EncounterBlueprintData.CardBlueprint>();
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("Adder"),
                randomReplaceChance = 25
            });
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Adder"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list6 = new List<EncounterBlueprintData.CardBlueprint>();
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Dragon")
            });
            List<EncounterBlueprintData.CardBlueprint> list7 = new List<EncounterBlueprintData.CardBlueprint>();
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Jade_Serpent"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list8 = new List<EncounterBlueprintData.CardBlueprint>();
            list8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("Adder"),
                randomReplaceChance = 25
            });
            list8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Rattler"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list9 = new List<EncounterBlueprintData.CardBlueprint>();
            list9.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Dragon")
            });
            List<EncounterBlueprintData.CardBlueprint> list10 = new List<EncounterBlueprintData.CardBlueprint>();
            list10.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Adder"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list11 = new List<EncounterBlueprintData.CardBlueprint>();
            list11.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Rattler"),
                randomReplaceChance = 25
            });
            list11.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Rattler"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> list12 = new List<EncounterBlueprintData.CardBlueprint>();
            list12.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Dragon")
            });
            list3.Add(list4);
            list3.Add(list5);
            list3.Add(list6);
            list3.Add(list7);
            list3.Add(list8);
            list3.Add(list9);
            list3.Add(list10);
            list3.Add(list11);
            list3.Add(list12);
            EncounterBlueprintData encounterBlueprintData = EncounterHelper.BuildBlueprint(name, list, list2, regionLocked, 0, 30, randomReplacementCards, list3);
            EncounterManager.Add(encounterBlueprintData);
            RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), new EncounterBlueprintData[]
            {
                encounterBlueprintData
            });
        }
    }
}
