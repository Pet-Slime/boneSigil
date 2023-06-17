using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Mole
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Frightful");
		public static void AddCard()
		{
			string name = "void_Mole";
			string displayName = "Drill Mole";
			string description = "Another one of the trapper's toys.";
			int baseAttack = 1;
			int baseHealth = 3;
			int bloodCost = 0;
			int boneCost = 6;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.WhackAMole);
			Abilities.Add(CustomAbility1);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Uncuttable);
			Traits.Add(Trait.Terrain);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_burrow.png");
			Texture2D pixelTexture = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_strange_mole.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_burrow_e.png");

			CardInfo newCard = SigilUtils.CreateCardWithDefaultSettings(
				InternalName: name,
				DisplayName: displayName,
				attack: baseAttack,
				health: baseHealth,
				texture_base: DefaultTexture,
				texture_emission: eTexture,
				texture_pixel: pixelTexture,
				cardMetaCategories: metaCategories,
				tribes: Tribes,
				traits: Traits,
				abilities: Abilities,
				bloodCost: bloodCost,
				boneCost: boneCost,
				energyCost: energyCost
				);
			newCard.description = description;
			newCard.appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.TerrainBackground);
			newCard.SetTail("void_Scrap", null);
			CardManager.Add("void", newCard);
		}
	}
}
