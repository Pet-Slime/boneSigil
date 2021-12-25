using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils.cards
{
	public static class BellTurtleBroken
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.DeathShield);

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.LoadTextureFromResource(Resources.Void_Tortoise_Bell_Broken);

			Texture2D eTexture = SigilUtils.LoadTextureFromResource(Resources.Void_Tortoise_Bell_Broken_e);

			EvolveIdentifier evolveID = new EvolveIdentifier("Void_Tortoise_Bell", 1, null);

			NewCard.Add(name: "Void_Tortoise_Bell_Broken",
				displayedName: "Broken Bell Turtle",
				baseAttack: 0,
				baseHealth: 1,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "A broken bell turtle, left out in the wild. Poor thing. Seems like it has two hits left...",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 2,
				energyCost: 0,
				gemsCost: null,
				specialStatIcon: SpecialStatIcon.None,
				Tribes,
				Traits,
				specialAbilities,
				Abilities,
				customAbilities,
				specialAbilitiesIdsParam: null,
				evolveParams: null,
				defaultEvolutionName: null,
				tailParams: null,
				iceCubeParams: null,
				flipPortraitForStrafe: false,
				onePerDeck: false,
				appearanceBehaviour,
				DefaultTexture,
				altTex: null,
				titleGraphic: null,
				pixelTex: null,
				eTexture,
				animatedPortrait: null,
				decals: null,
				evolveID,
				iceCubeId: null,
				tailId: null);
		}
	}
}
