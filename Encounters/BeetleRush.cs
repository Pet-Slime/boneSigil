using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;

namespace boneSigils.Encounters
{
    internal class BeetleRush
    {
		public static void AddEncounter()
		{
            //Name of the encounter
            string name = "BeetleRush";

            //Vanilla region names are: Forest, Wetlands, and Alpine
            string regionName = "Wetlands";

            //What is the most common tribe?
            List<Tribe> dominate = new List<Tribe>();
            dominate.Add(Tribe.Insect);

            //Are any abilities redundent? Thus shouldnt be used on a totem
            List<Ability> redundant = new List<Ability>();

            //Is this encounter locked to a region?
            bool regionLocked = true;

            

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterUtil.AddRandomCards("Mantis", "Cockroach", "Mole");

            List<EncounterBlueprintData.TurnModBlueprint> difficultyMod = new List<EncounterBlueprintData.TurnModBlueprint>();

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = new List<List<EncounterBlueprintData.CardBlueprint>>();

            List<EncounterBlueprintData.CardBlueprint> turn_1 = new List<EncounterBlueprintData.CardBlueprint>();
                turn_1.Add(new EncounterBlueprintData.CardBlueprint { 
                    card = CardLoader.GetCardByName("void_beetle_larva"), 
                    difficultyReplace = true,
                    difficultyReq = 13,
                    replacement = CardLoader.GetCardByName("void_scarab_jewel"),
                    randomReplaceChance = 25
                });
                turn_1.Add(new EncounterBlueprintData.CardBlueprint
                {
                    card = CardLoader.GetCardByName("void_beetle_larva"),
                    difficultyReplace = true,
                    difficultyReq = 18,
                    replacement = CardLoader.GetCardByName("Void_Rino_beetle"),
                    randomReplaceChance = 25
                });

            List<EncounterBlueprintData.CardBlueprint> turn_2 = new List<EncounterBlueprintData.CardBlueprint>();
                turn_2.Add(new EncounterBlueprintData.CardBlueprint
                {
                    card = CardLoader.GetCardByName("Bee"),
                    difficultyReplace = true,
                    difficultyReq = 18,
                    replacement = CardLoader.GetCardByName("void_scarab_jewel"),
                    randomReplaceChance = 25
                });
                turn_2.Add(new EncounterBlueprintData.CardBlueprint
                {
                    card = CardLoader.GetCardByName("Bee"),
                    difficultyReplace = true,
                    difficultyReq = 18,
                    replacement = CardLoader.GetCardByName("void_scarab_jewel"),
                    randomReplaceChance = 25
                });

            List<EncounterBlueprintData.CardBlueprint> turn_3 = new List<EncounterBlueprintData.CardBlueprint>();
                turn_3.Add(new EncounterBlueprintData.CardBlueprint { 
                    card = CardLoader.GetCardByName("void_beetle_larva"), 
                    difficultyReplace = true, 
                    difficultyReq = 13, 
                    replacement = CardLoader.GetCardByName("Void_Beetle_Bombardier") 
                });
                turn_3.Add(new EncounterBlueprintData.CardBlueprint {
                    card = CardLoader.GetCardByName("void_beetle_larva"),
                    difficultyReplace = true,
                    difficultyReq = 18,
                    replacement = CardLoader.GetCardByName("Void_Rino_beetle")
                });

            List<EncounterBlueprintData.CardBlueprint> turn_4 = new List<EncounterBlueprintData.CardBlueprint>();
                turn_4.Add(new EncounterBlueprintData.CardBlueprint
                {
                    card = CardLoader.GetCardByName("void_beetle_larva"),
                    difficultyReplace = true,
                    difficultyReq = 18,
                    replacement = CardLoader.GetCardByName("Void_Rino_beetle")
                });

            turns.Add(turn_1);
            turns.Add(turn_2);
            turns.Add(turn_3);
            turns.Add(turn_4);



            NewEncounter.Add(
                        name,
                        regionName,
                        difficultyMod,
                        dominate,
                        redundant,
                        unlockedCardPrerequisites: null,
                        regionLocked,
                        minDifficulty: 1,
                        maxDifficulty: 30,
                        randomReplacements,
                        turns,
                        regular: true,
                        bossPrep: false,
                        oldPreviewDifficulty: 0);
        }

        
	}
}
