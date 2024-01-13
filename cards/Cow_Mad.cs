using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Cow_Mad
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Blight");
		public static void AddCard()
		{
			string name = "void_Cow_Mad";
			string displayName = "The Dying Bull";
			string description = "The Mad Bull, out for bones with not much time left.";
			int baseAttack = 2;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 5;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Hooved);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(ability_MadCow.ability);
			Abilities.Add(CustomAbility1);

			List<Trait> Traits = new List<Trait>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("void_cow_mad.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("void_cow_mad_e.png");

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
			newCard.SetIceCube("void_Cow_Skul");
			newCard.description = description;
			CardManager.Add("void", newCard);
		}
	}
}
