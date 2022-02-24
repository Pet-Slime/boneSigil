using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Dragon
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Deathtouch);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.KillsSurvivors);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Dragon.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Dragon_e.png");

			IceCubeIdentifier iceCubeId = null;
			EvolveIdentifier evolveId = null;
			TailIdentifier tail = null;

			NewCard.Add(name: "Void_Dragon",
				displayedName: "Komodo Dragon",
				baseAttack: 3,
				baseHealth: 5,
				metaCategories,
				cardComplexity: CardComplexity.Intermediate,
				temple: CardTemple.Nature,
				description: "The largest and toughest of the reptiles, with a poisonous bite that can kill anything.",
				hideAttackAndHealth: false,
				bloodCost: 1,
				bonesCost: 10,
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
