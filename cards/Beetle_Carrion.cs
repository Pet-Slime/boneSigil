using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Beetle_Carrion
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");
		public static void AddCard()
		{
			string name = "void_Beetle_Carrion";
			string displayName = "Carrion Beetle";
			string description = "A hard shell and a taste of flesh, they can find any fresh corpse.";
			int baseAttack = 1;
			int baseHealth = 4;
			int bloodCost = 0;
			int boneCost = 6;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Insect);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.CorpseEater);
			Abilities.Add(CustomAbility1);

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Void_Beetle.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Void_Beetle_e.png");

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
			newCard.appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);
			newCard.description = description;
			CardManager.Add("void", newCard);
		}
	}
}
