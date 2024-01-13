﻿using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Cow_Dairy
	{
		public static void AddCard()
		{
			string name = "void_Cow_Dairy";
			string displayName = "Dairy Cow";
			string description = "A cow fit for slaughter.";
			int baseAttack = 0;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 4;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Hooved);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.TripleBlood);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Goat);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(DairyCowSpecialAbility.specialAbility);


			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Void_Dairy_Cow.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Void_Dairy_Cow_e.png");

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
			newCard.AddSpecialAbilities(DairyCowSpecialAbility.specialAbility);
			newCard.SetIceCube("void_Cow_Skul");
			newCard.appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);
			newCard.description = description;
			CardManager.Add("void", newCard);
		}
	}
}
