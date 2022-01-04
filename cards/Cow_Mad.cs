using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Cow_Mad
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Hooved);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Evolve);

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Blight"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_cow_mad.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_cow_mad_e.png");

			IceCubeIdentifier iceCubeId = new IceCubeIdentifier("Void_Cow_Skul");
			EvolveIdentifier evolveId = new EvolveIdentifier("Void_Cow_Skul", 2);
			TailIdentifier tail = null;

			NewCard.Add(name: "void_cow_mad",
				displayedName: "The Mad Bull",
				baseAttack: 3,
				baseHealth: 4,
				metaCategories,
				cardComplexity: CardComplexity.Intermediate,
				temple: CardTemple.Nature,
				description: "The Mad Bull, out for bones with not much time left.",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 5,
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
