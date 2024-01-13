using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Mantis_Shrimp
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Ambush");
		public static void AddCard()
		{
			string name = "void_Shrimp_Mantis";
			string displayName = "Mantis Shrimp";
			string description = "A shrimp with a deadly punch, one that can boil water with the force of it.";
			int baseAttack = 3;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 6;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(CustomAbility1);
			Abilities.Add(CustomAbility1);

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Void_Mantis_Shrimp.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Void_Mantis_Shrimp_e.png");

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
