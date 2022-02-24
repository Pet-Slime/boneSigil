using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Burrow
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.SteelTrap);
			Abilities.Add(Ability.WhackAMole);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Uncuttable);
			Traits.Add(Trait.Terrain);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.TerrainBackground);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_burrow.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_burrow_e.png");

			IceCubeIdentifier iceCubeId = null;

			TailIdentifier tail = new TailIdentifier("Void_Scrap", DefaultTexture, null);

			NewCard.Add(name: "Void_burrow",
				displayedName: "Strange Mole",
				baseAttack: 1,
				baseHealth: 5,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "Another one of the trapper's toys.",
				hideAttackAndHealth: false,
				bloodCost: 0,
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
				evolveId: null,
				iceCubeId,
				tail);
		}
	}
}
