using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Bone_Lord
	{
		public static void AddCard()
		{
			string name = "void_Bone_Lord";
			string displayName = "The Bone Lord";
			string description = "The Lord of Bones has decided to get his hands dirty this time.";
			int baseAttack = 7;
			int baseHealth = 7;
			int bloodCost = 2;
			int boneCost = 10;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.BoneDigger);
			Abilities.Add(Ability.DrawCopyOnDeath);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Undead);
			Traits.Add(Trait.Goat);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_horn.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_horn_e.png");

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
			newCard.appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);
			CardManager.Add("void", newCard);
		}
	}
}
