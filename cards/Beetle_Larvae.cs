using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Beetle_Larvae

	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Insect);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(boneSigils.ability_Pupate.ability);

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Nutritious"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_beetle_larva.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_beetle_larva_e.png");

			IceCubeIdentifier iceCubeId = null;

			TailIdentifier tail = null;

			NewCard.Add(name: "void_beetle_larva",
				displayedName: "Beetle Larva",
				baseAttack: 1,
				baseHealth: 3,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "A monsterously sized larvae, and a tasty one to boot!",
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
				defaultEvolutionName: "Overgrown",
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
				iceCubeId,
				tail);
		}
	}
}
