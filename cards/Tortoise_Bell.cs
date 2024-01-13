using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Tortoise_Bell
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Resistant");
		public static void AddCard()
		{
			string name = "void_Tortoise_Bell";
			string displayName = "Bell Turtle";
			string description = "A gift from the trapper, made of clockwork and gold.";
			int baseAttack = 0;
			int baseHealth = 3;
			int bloodCost = 0;
			int boneCost = 6;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(CustomAbility1);

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Void_Tortoise_Bell.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Void_Tortoise_Bell_e.png");
			Texture2D tailTexture = SigilUtils.GetTextureFromPath("Void_Tortoise_Bell_alt.png");

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
			newCard.SetIceCube("void_Tortoise_Bell_Broken");
			newCard.SetTail("void_Scrap", tailTexture);
			newCard.appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.GoldEmission);
			newCard.appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.TerrainBackground);
			newCard.SetStatIcon(SpecialStatIcon.Bell);
			newCard.SetSpecialAbilities(SpecialTriggeredAbility.BellProximity);
			CardManager.Add("void", newCard);
		}
	}
}
