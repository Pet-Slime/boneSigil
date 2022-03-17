using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Rabbit
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Agile");
		public static void AddCard()
		{
			string name = "void_Rabbit";
			string displayName = "Beast of Caerbannog";
			int baseAttack = 1;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 6;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Deathtouch);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.KillsSurvivors);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Rabbit.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Rabbit_e.png");

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
			CardManager.Add(newCard);
		}
	}
}
