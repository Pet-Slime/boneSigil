using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Crab_coco
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.SplitStrike);

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Thick Shell"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Coco_Crab.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Coco_Crab_e.png");

			IceCubeIdentifier iceCubeId = null;
			EvolveIdentifier evolveId = null;
			TailIdentifier tail = new TailIdentifier("void_crab_leg");

			NewCard.Add(name: "Void_Coco_Crab",
				displayedName: "Coconut Crab",
				baseAttack: 1,
				baseHealth: 4,
				metaCategories,
				cardComplexity: CardComplexity.Intermediate,
				temple: CardTemple.Nature,
				description: "The Coconut crab has a thick shell, and sharp claws to boot",
				hideAttackAndHealth: false,
				bloodCost: 1,
				bonesCost: 6,
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
