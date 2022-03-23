using System.Collections.Generic;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Encounters;

namespace boneSigils.Encounters
{
    internal class Bulls
    {
        public static void AddEncounter()
        {
            //Name of the encounter
            string name = "BullRush";

            //Vanilla region names are: Forest, Wetlands, and Alpine
            string regionName = "Alpine";

            //What is the most common tribe?
            List<Tribe> dominate = new List<Tribe>();
            dominate.Add(Tribe.Hooved);

            //Are any abilities redundent? Thus shouldnt be used on a totem
            List<Ability> redundant = new List<Ability>();
            redundant.Add(Ability.Strafe);

            //Is this encounter locked to a region?
            bool regionLocked = true;

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterHelper.AddRandomCards("Elk", "ElkCub", "Mole", "Wolf", "WolfCub");

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = new List<List<EncounterBlueprintData.CardBlueprint>>();

            List<EncounterBlueprintData.CardBlueprint> turn_1 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy")
            });
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Mad"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Cow_Wild"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_2 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_2.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_3 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_4 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Mad"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Cow_Wild"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_5 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_6 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Dairy"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_7 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Cow_Mad"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Cow_Wild"),
                randomReplaceChance = 25
            });
            turns.Add(turn_1);
            turns.Add(turn_2);
            turns.Add(turn_3);
            turns.Add(turn_4);
            turns.Add(turn_5);
            turns.Add(turn_6);
            turns.Add(turn_7);

            var encounter = boneSigils.EncounterHelper.BuildBlueprint(name, dominate, redundant, regionLocked, 0, 30, randomReplacements, turns);

            EncounterManager.Add(encounter);

            InscryptionAPI.Regions.RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), encounter);

        }
    }
}