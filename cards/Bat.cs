using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Bat
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Blind);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Grazing"));
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Possessor"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Bat.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Bat_e.png");

			IceCubeIdentifier iceCubeId = null;

			TailIdentifier tail = null;

			NewCard.Add(name: "Void_Bat",
				displayedName: "Spectral Bat",
				baseAttack: 4,
				baseHealth: 5,
				metaCategories,
				cardComplexity: CardComplexity.Advanced,
				temple: CardTemple.Nature,
				description: "Rarely seen, this bat haunts the shadows.",
				hideAttackAndHealth: false,
				bloodCost: 1,
				bonesCost: 7,
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
				iceCubeId,
				tail);
		}
	}
}
