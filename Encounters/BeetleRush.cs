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

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = EncounterUtil.BuildEncounter(
                "void_beetle_larva", "none", 
                "void_beetle_larva", "void_beetle_larva",
                "void_beetle_larva", "none",
                "void_beetle_larva", "void_beetle_larva");

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterUtil.AddRandomCards("Mantis", "Cockroach", "Mole");

            List<EncounterBlueprintData.TurnModBlueprint> difficultyMod = new List<EncounterBlueprintData.TurnModBlueprint>();
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Scarab_Jewel"), applyAtDifficulty = 8, turn = 1 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Scarab_Jewel"), applyAtDifficulty = 8, turn = 3 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Rino_beetle"), applyAtDifficulty = 13, turn = 2 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Rino_beetle"), applyAtDifficulty = 13, turn = 6 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Beetle"), applyAtDifficulty = 17, turn = 1 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Beetle"), applyAtDifficulty = 13, turn = 3 });

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
