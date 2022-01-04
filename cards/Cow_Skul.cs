using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Cow_Skul
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Hooved);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.QuadrupleBones);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Terrain);
			Traits.Add(Trait.Undead);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Cow_Skul.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Cow_Skul_e.png");

			IceCubeIdentifier iceCubeId = null;
			EvolveIdentifier evolveId = new EvolveIdentifier("Void_Cow_Skul", 2);
			TailIdentifier tail = null;

			NewCard.Add(name: "Void_Cow_Skul",
				displayedName: "Cow Skeleton",
				baseAttack: 0,
				baseHealth: 1,
				metaCategories,
				cardComplexity: CardComplexity.Intermediate,
				temple: CardTemple.Nature,
				description: "Not much left of The Mad Bull",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 0,
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
				evolveId,
				iceCubeId,
				tail);
		}
	}
}
