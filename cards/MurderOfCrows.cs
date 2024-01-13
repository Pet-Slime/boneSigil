using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class MurderOfCrows
	{
		public static void AddCard()
		{
			string name = "void_Crows_Murder";
			string displayName = "Murder of Crows";
			string description = "A flock of black clouds swam and then leave, with the only thing remaining are bones.";
			int baseAttack = 2;
			int baseHealth = 3;
			int bloodCost = 0;
			int boneCost = 6;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Flying);

			List<Trait> Traits = new List<Trait>();

			List<GemType> gemCost = new List<GemType>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Void_Murder_of_Crows.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Void_Murder_of_Crows_e.png");

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
			newCard.AddSpecialAbilities(MurderOfCrowsSpecialAbility.specialAbility);
			newCard.appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);
			newCard.description = description;
			CardManager.Add("void", newCard);
		}
	}
}
