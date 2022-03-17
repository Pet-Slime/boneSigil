using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Serpent_Jade
	{
		public static void AddCard()
		{
			string name = "Void_Jade_Serpent";
			string displayName = "Jade Serpent";
			string description = "A serpent who's scales shimmer like jade.";
			int baseAttack = 3;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 6;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.GainGemGreen);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Gem);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Jade_Serpent.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Jade_Serpent_e.png");

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
