using System.Collections.Generic;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Encounters;

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
            bool regionLocked = true;

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterHelper.AddRandomCards("void_Urchin_LongSpine", "void_Urchin_Flower", "void_Urchin_Sea", "void_Shrimp_Mantis");

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = new List<List<EncounterBlueprintData.CardBlueprint>>();

            List<EncounterBlueprintData.CardBlueprint> turn_1 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Spider")
            });
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Kingfisher"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Crab_Coco"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_2 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_2.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Leg"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Crab_Fiddler"),
                randomReplaceChance = 25
            });
            turn_2.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Leg"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Crab_Coco"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_3 = new List<EncounterBlueprintData.CardBlueprint>();

            List<EncounterBlueprintData.CardBlueprint> turn_4 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Leg"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Crab_Fiddler"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_5 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Crab_Spider")
            });
            turns.Add(turn_1);
            turns.Add(turn_2);
            turns.Add(turn_3);
            turns.Add(turn_4);
            turns.Add(turn_5);

            var encounter = boneSigils.EncounterHelper.BuildBlueprint(name, dominate, redundant, regionLocked, 0, 30, randomReplacements, turns);
            CarbEncounter = encounter;
            EncounterManager.Add(encounter);

            InscryptionAPI.Regions.RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), encounter);

        }

        public static EncounterBlueprintData CarbEncounter;
    }
}