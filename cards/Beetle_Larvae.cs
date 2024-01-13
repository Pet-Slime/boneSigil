using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Beetle_Larvae
	{
		public static void AddCard()
		{
			string name = "void_Beetle_Larva";
			string displayName = "Beetle Larva";
			string description = "A monsterously sized larvae, and a tasty one to boot!";
			int baseAttack = 1;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 3;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Insect);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(boneSigils.ability_Pupate.ability);

			List<Trait> Traits = new List<Trait>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("void_beetle_larva.png");
			Texture2D pixelTexture = SigilUtils.GetTextureFromPath("pixelportrait_beetle_larvae.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("void_beetle_larva_e.png");

			CardInfo newCard = SigilUtils.CreateCardWithDefaultSettings(
				InternalName: name,
				DisplayName: displayName,
				attack: baseAttack,
				health: baseHealth,
				texture_base: DefaultTexture,
				texture_emission: eTexture,
				texture_pixel: pixelTexture,
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
