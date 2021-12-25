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
	public static class MurderOfCrows
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Flying);

			List<Trait> Traits = new List<Trait>();

			List<GemType> gemCost = new List<GemType>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(MurderOfCrowsSpecialAbility.specialAbility);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			Texture2D DefaultTexture = SigilUtils.LoadTextureFromResource(Resources.void_murder_of_crows);

			Texture2D eTexture = SigilUtils.LoadTextureFromResource(Resources.void_murder_of_crows);

			NewCard.Add(name: "void_murder_of_crows",
				displayedName: "Murder of Crows",
				baseAttack: 2,
				baseHealth: 2,
				metaCategories,
				cardComplexity: CardComplexity.Advanced,
				temple: CardTemple.Nature,
				description: "A flock of black clouds swam and then leave, with the only thing remaining are bones",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 6,
				energyCost: 0,
				gemCost,
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
				evolveId: null,
				iceCubeId: null,
				tailId: null);
		}
	}
}
