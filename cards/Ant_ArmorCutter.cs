using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Ant_ArmorCutter
	{
		public static readonly Ability CustomAbility = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");

		public static void AddCard()
		{
			string name = "void_Leaf_Ant";
			string displayName = "Armored Ant";
			string description = "A leaf cutter ant that has a mineral shell and lives in the trees.";
			int baseAttack = 0;
			int baseHealth = 4;
			int bloodCost = 1;
			int boneCost = 3;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Insect);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Reach);
			Abilities.Add(CustomAbility);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Ant);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Leaf_Ant.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Leaf_Ant_e.png");

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
			newCard.SetStatIcon(SpecialStatIcon.Ants);
			newCard.SetSpecialAbilities(SpecialTriggeredAbility.Ant);
			newCard.description = description;
			CardManager.Add("void", newCard);
		}
	}
}
