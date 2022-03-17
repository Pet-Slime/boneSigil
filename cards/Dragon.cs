using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Dragon
	{
		public static void AddCard()
		{
			string name = "void_Dragon";
			string displayName = "Komodo Dragon";
			int baseAttack = 3;
			int baseHealth = 5;
			int bloodCost = 1;
			int boneCost = 10;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Deathtouch);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.KillsSurvivors);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Dragon.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Dragon_e.png");

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
			CardManager.Add(newCard);
		}
	}
}
