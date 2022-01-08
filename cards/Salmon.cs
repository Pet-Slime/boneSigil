using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Salmon
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.QuadrupleBones);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Undead);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_undeadSalmon.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_undeadSalmon_e.png");

			IceCubeIdentifier iceCubeId = null;
			EvolveIdentifier evolveId = null;
			TailIdentifier tail = null;

			NewCard.Add(name: "Void_Salmon",
				displayedName: "Undead Salmon",
				baseAttack: 2,
				baseHealth: 1,
				metaCategories,
				cardComplexity: CardComplexity.Advanced,
				temple: CardTemple.Nature,
				description: "Undead here . . . how?",
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
				evolveId,
				iceCubeId,
				tail);
		}
	}
}
