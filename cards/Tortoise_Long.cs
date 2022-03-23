using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Tortoise_Long
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");
		public static void AddCard()
		{
			string name = "void_Tortoise_Long";
			string displayName = "Giant Tortoise";
			string description = "A giant tortoise, with a neck that could stretch.";
			int baseAttack = 1;
			int baseHealth = 7;
			int bloodCost = 1;
			int boneCost = 9;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Reach);
			Abilities.Add(CustomAbility1);


			bloodCost = 0;
			boneCost = 0;

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_tortoise_long.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_tortoise_long_e.png");

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
			CardManager.Add("void", newCard);
		}
	}
}
