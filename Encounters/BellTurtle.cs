using System.Collections.Generic;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Encounters;

namespace boneSigils.Encounters
{
    internal class BellTurtle
    {
        public static void AddEncounter()
        {
            //Name of the encounter
            string name = "BellTurtle";

            //Vanilla region names are: Forest, Wetlands, and Alpine
            string regionName = "Wetlands";

            //What is the most common tribe?
            List<Tribe> dominate = new List<Tribe>();
            dominate.Add(Tribe.Reptile);

            //Are any abilities redundent? Thus shouldnt be used on a totem
            List<Ability> redundant = new List<Ability>();
            redundant.Add(Ability.DeathShield);
            redundant.Add(Ability.Reach);

            //Is this encounter locked to a region?
            bool regionLocked = false;

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterHelper.AddRandomCards("void_Mole");

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = new List<List<EncounterBlueprintData.CardBlueprint>>();

            List<EncounterBlueprintData.CardBlueprint> turn_1 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Tortoise_Bell"),
                randomReplaceChance = 10
            });
            turn_1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("TrapFrog"),
                randomReplaceChance = 10
            });

            List<EncounterBlueprintData.CardBlueprint> turn_2 = new List<EncounterBlueprintData.CardBlueprint>();

            List<EncounterBlueprintData.CardBlueprint> turn_3 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("TrapFrog"),
                randomReplaceChance = 10
            });

            List<EncounterBlueprintData.CardBlueprint> turn_4 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("void_Tortoise_Bell"),
                randomReplaceChance = 10
            });

            List<EncounterBlueprintData.CardBlueprint> turn_5 = new List<EncounterBlueprintData.CardBlueprint>();

            List<EncounterBlueprintData.CardBlueprint> turn_6 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Tortoise_Bell"),
                randomReplaceChance = 10
            });

            List<EncounterBlueprintData.CardBlueprint> turn_7 = new List<EncounterBlueprintData.CardBlueprint>();
            turn_7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("TrapFrog"),
                randomReplaceChance = 10
            });
            turn_7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("void_Tortoise_Bell_Broken"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("void_Tortoise_Bell"),
                randomReplaceChance = 10
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