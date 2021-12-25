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
	public static class DairyCow
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Hooved);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.TripleBlood);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Goat);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetAbilityIdentifier("extraVoid.inscryption.voidSigils", "Nutritious"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(DairyCowSpecialAbility.specialAbility);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			Texture2D DefaultTexture = SigilUtils.LoadTextureFromResource(Resources.void_dairy_cow);

			Texture2D eTexture = SigilUtils.LoadTextureFromResource(Resources.void_dairy_cow_e);

			NewCard.Add(name: "void_dairy_cow",
				displayedName: "Cow",
				baseAttack: 0,
				baseHealth: 3,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "A cow fit for slaughter",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 3,
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
				evolveId: null,
				iceCubeId: null,
				tailId: null);
		}
	}
}
