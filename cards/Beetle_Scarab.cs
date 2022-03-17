using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Beetle_Scarab
	{
		public static void AddCard()
		{
			string name = "Void_Scarab_Jewel";
			string displayName = "Jeweled Scarab";
			string description = "The blue jewel on it's back shines bright.";
			int baseAttack = 1;
			int baseHealth = 5;
			int bloodCost = 0;
			int boneCost = 7;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Insect);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.GainGemBlue);
			Abilities.Add(Ability.WhackAMole);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Gem);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_scarab_jewel.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_scarab_jewel_e.png");

			CardInfo newCard = SigilUtils.CreateCardWithDefaultSettings(
				InternalName: name,
				DisplayName: displayName,
				attack: baseAttack,
				health: baseHealth,
				texture_base: DefaultTexture,
				texture_emission: eTexture,
				texture_pixel: null,
				cardMetaCategories: metaCategories,
				tribes: Tribes,
				traits: Traits,
				abilities: Abilities,
				bloodCost: bloodCost,
				boneCost: boneCost,
				energyCost: energyCost
				);
			newCard.description = description;
			CardManager.Add(newCard);
		}
	}
}
