using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Salmon
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice");
		public static void AddCard()
		{
			string name = "void_Salmon";
			string displayName = "Undead Salmon";
			string description = "Undead here . . . how?";
			int baseAttack = 2;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 3;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.QuadrupleBones);
			Abilities.Add(CustomAbility1);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Undead);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("void_undeadSalmon.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("void_undeadSalmon_e.png");

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
