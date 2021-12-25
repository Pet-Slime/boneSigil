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
	public static class Steak
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetAbilityIdentifier("extraVoid.inscryption.voidSigils", "Nutritious"));

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			Texture2D DefaultTexture = SigilUtils.LoadTextureFromResource(Resources.void_steak);

			Texture2D eTexture = SigilUtils.LoadTextureFromResource(Resources.void_steak);

			NewCard.Add(name: "Void_Steak",
				displayedName: "Fresh Steak",
				baseAttack: 0,
				baseHealth: 1,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "Yummy",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 0,
				energyCost: 0,
				gemsCost: null,
				specialStatIcon: SpecialStatIcon.None,
				Tribes,
				traits: null,
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
