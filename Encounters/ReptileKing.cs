using System.Collections.Generic;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Encounters;

namespace boneSigils.Encounters
{
    internal class ReptileKing
    {
        public static void AddEncounter()
        {
            //Name of the encounter
            string name = "ReptileKing";

            //Vanilla region names are: Forest, Wetlands, and Alpine
            string regionName = "Wetlands";

            //What is the most common tribe?
            List<Tribe> dominate = new List<Tribe>();
            dominate.Add(Tribe.Reptile);

            //Are any abilities redundent? Thus shouldnt be used on a totem
            List<Ability> redundant = new List<Ability>();
            redundant.Add(Ability.Deathtouch);

            //Is this encounter locked to a region?
            bool regionLocked = true;

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterHelper.AddRandomCards("Skink", "Snapper", "Bullfrog");


            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = new List<List<EncounterBlueprintData.CardBlueprint>>();

            List<EncounterBlueprintData.CardBlueprint> turn_1 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck")
            });
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("Rattler"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_2 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_2.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("Adder"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_3 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Dragon"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_4 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Jade_Serpent"),
                randomReplaceChance = 25
            });

            List<EncounterBlueprintData.CardBlueprint> turn_5 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("Adder"),
                randomReplaceChance = 25
            });
            turn_5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Rattler"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> turn_6 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Dragon")
            });
            List<EncounterBlueprintData.CardBlueprint> turn_7 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Adder"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> turn_8 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Rattler"),
                randomReplaceChance = 25
            });
            turn_8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("Geck"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("Rattler"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> turn_9 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_9.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Dragon")
            });
            turns.Add(turn_1);
            turns.Add(turn_2);
            turns.Add(turn_3);
            turns.Add(turn_4);
            turns.Add(turn_5);
            turns.Add(turn_6);
            turns.Add(turn_7);
            turns.Add(turn_8);
            turns.Add(turn_9);


            var encounter = boneSigils.EncounterHelper.BuildBlueprint(name, dominate, redundant, regionLocked, 0, 30, randomReplacements, turns);

            EncounterManager.Add(encounter);

            InscryptionAPI.Regions.RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), encounter);

        }
    }
}