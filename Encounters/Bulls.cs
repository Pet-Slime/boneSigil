using System.Collections.Generic;
using DiskCardGame;
using APIPlugin;

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
            redundant.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Ram").id);
            redundant.Add(Ability.Strafe);

            //Is this encounter locked to a region?
            bool regionLocked = true;

            //Encounter by turns
            List<List<EncounterBlueprintData.CardBlueprint>> turns = EncounterUtil.BuildEncounter(
                "void_dairy_cow", "ElkCub",
                "void_cow_mad", "void_dairy_cow",
                "void_dairy_cow", "none",
                "void_cow_mad", "Rabbit",
                "void_cow_wild", "Rabbit");

            //Add random Replacements
            List<CardInfo> randomReplacements = EncounterUtil.AddRandomCards("Moose", "Elk", "ElkCub", "Mole", "Wolf", "WolfCub");

            List<EncounterBlueprintData.TurnModBlueprint> difficultyMod = new List<EncounterBlueprintData.TurnModBlueprint>();
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("void_cow_wild"), applyAtDifficulty = 13, turn = 1 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("void_cow_mad"), applyAtDifficulty = 13, turn =  5});
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("void_cow_mad"), applyAtDifficulty = 18, turn = 1 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("void_cow_wild"), applyAtDifficulty = 18, turn = 2 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("Moose"), applyAtDifficulty = 18, turn = 3 });
            difficultyMod.Add(new EncounterBlueprintData.TurnModBlueprint { overlockCards = CardLoader.GetCardByName("void_cow_wild"), applyAtDifficulty = 18, turn = 5 });

            NewEncounter.Add(
                        name: name,
                        regionName: regionName,
                        turnMods: difficultyMod,
                        dominantTribes: dominate,
                        redundantAbilities: redundant,
                        unlockedCardPrerequisites: null,
                        regionSpecific: regionLocked,
                        minDifficulty: 1,
                        maxDifficulty: 30,
                        randomReplacementCards: randomReplacements,
                        turns: turns,
                        regular: true,
                        bossPrep: false,
                        oldPreviewDifficulty: 0);
        }

        
	}
}
