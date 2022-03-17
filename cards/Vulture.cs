using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Vulture
	{
		public static void AddCard()
		{
			string name = "void_Vulture";
			string displayName = "Bearded Vulture";
			string description = "A Vulture that consumes bone.";
			int baseAttack = 0;
			int baseHealth = 5;
			int bloodCost = 0;
			int boneCost = 9;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Flying);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.KillsSurvivors);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Lammergeier);


			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Vulture.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Vulture_e.png");

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
			newCard.specialStatIcon = SpecialStatIcon.Bones;
			newCard.specialAbilities.Add(SpecialTriggeredAbility.Lammergeier);
			CardManager.Add(newCard);
		}
	}
}
