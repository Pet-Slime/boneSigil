using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;

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

            //Is this encounter locked to a region?
            bool regionLocked = true;

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = EncounterUtil.BuildEncounter(
                "Geck", "Geck",
                "Geck", "Geck",
                "Void_Dragon", "Geck",
                "Geck", "Geck");

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterUtil.AddRandomCards("Skink", "Snapper", "Bullfrog");

            List<EncounterBlueprintData.TurnModBlueprint> difficultyMod = new List<EncounterBlueprintData.TurnModBlueprint>();
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Adder"), applyAtDifficulty = 8, turn = 1 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Adder"), applyAtDifficulty = 8, turn = 4 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Adder"), applyAtDifficulty = 8, turn = 7 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Rattler"), applyAtDifficulty = 13, turn = 5 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Rattler"), applyAtDifficulty = 13, turn = 4 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Rattler"), applyAtDifficulty = 13, turn = 8 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Dragon"), applyAtDifficulty = 17, turn = 6 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Void_Dragon"), applyAtDifficulty = 17, turn = 9 });

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
