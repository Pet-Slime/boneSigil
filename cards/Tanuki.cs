using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Tanuki
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Canine);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Evolve);
			Abilities.Add(Ability.BoneDigger);

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_tanuki.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_tanuki_e.png");

			IceCubeIdentifier iceCubeId = null;
			EvolveIdentifier evolveId = new EvolveIdentifier("void_tanuki_mythical", 2);
			TailIdentifier tail = null;

			NewCard.Add(name: "Void_Tanuki",
				displayedName: "Tanuki",
				baseAttack: 1,
				baseHealth: 2,
				metaCategories,
				cardComplexity: CardComplexity.Intermediate,
				temple: CardTemple.Nature,
				description: "The crafty Tanuki, scavenging for it's next meal.",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 4,
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
