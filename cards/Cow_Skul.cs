using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Cow_Skul
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice");
		public static void AddCard()
		{
			string name = "void_Cow_Skul";
			string displayName = "Bulvine Bones";
			string description = "Not much left.";
			int baseAttack = 0;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Hooved);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(CustomAbility1);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Terrain);
			Traits.Add(Trait.Undead);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Void_Cow_Skul.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Void_Cow_Skul_e.png");

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
