using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class TestCard2
    {

		public static readonly Ability CustomAbility = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Take-Off (Bones)");

		public static void AddCard()
		{
			string name = "void_Crow_Familiar";
			string displayName = "Crow Familiar";
			string description = "A friendly little crow.";
			int baseAttack = 1;
			int baseHealth = 3;
			int bloodCost = 1;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(CustomAbility);

			List<Trait> Traits = new List<Trait>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("void_Crow_familiar.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("void_Crow_familiar_e.png");
			Texture2D pTexture = SigilUtils.GetTextureFromPath("pixelportrait_blank.png");

			CardInfo newCard = SigilUtils.CreateCardWithDefaultSettings(
				InternalName: name,
				DisplayName: displayName,
				attack: baseAttack,
				health: baseHealth,
				texture_base: DefaultTexture,
				texture_emission: eTexture,
				texture_pixel: pTexture,
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
