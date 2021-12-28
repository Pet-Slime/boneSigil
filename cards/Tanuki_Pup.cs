
using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils.cards
{
	public static class Tanuki_Pup
	{
		public static void AddCard()
		{

			int cost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			if (!BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.StarterdeckGUID))
            {
				Plugin.Log.LogMessage("Did not find side decks, adding tanuki pups to the default pools");
				metaCategories.Add(CardMetaCategory.ChoiceNode);
				metaCategories.Add(CardMetaCategory.TraderOffer);

			} else
			{
				Plugin.Log.LogMessage("Found side decks, removing tanuki pups from the default pools");
			}

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Canine);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.BoneDigger);
			Abilities.Add(Ability.Evolve);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetAbilityIdentifier("extraVoid.inscryption.voidSigils", "Ignite"));

			if (!BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.StarterdeckGUID))
			{
				Plugin.Log.LogMessage("Did not find side decks, tanuki pup now costs 1");
				cost = 1;

			}
			else
			{
				Plugin.Log.LogMessage("Found side decks, setting tanuki pup cost to 0");
			}


			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Tanuki_Pup.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Tanuki_Pup_e.png");

			NewCard.Add(name: "Void_Tanuki_pup",
				displayedName: "Tanuki Pup",
				baseAttack: 0,
				baseHealth: 1,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "A young Tanuki, scavenging for bones.",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: cost,
				energyCost: 0,
				gemsCost: null,
				specialStatIcon: SpecialStatIcon.None,
				Tribes,
				traits: new List<Trait>() { (Trait)5103 },
				specialAbilities: null,
				Abilities,
				customAbilities,
				specialAbilitiesIdsParam: null,
				evolveParams: null,
				defaultEvolutionName: null,
				tailParams: null,
				iceCubeParams: null,
				flipPortraitForStrafe: false,
				onePerDeck: false,
				appearanceBehaviour: null,
				DefaultTexture,
				altTex: null,
				titleGraphic: null,
				pixelTex: null,
				eTexture,
				animatedPortrait: null,
				decals: null,
				evolveId: new EvolveIdentifier("Void_Tanuki", 3, null),
				iceCubeId: null,
				tailId: null);
		}
	}
}
