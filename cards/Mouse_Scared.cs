using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Mouse_Scared
	{

		public static readonly Ability CustomAbility = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Stampede");

		public static void AddCard()
		{
			string name = "void_Scared_Mouse";
			string displayName = "Scared Mouse";
			string description = "A frightened mouse, causing a panic. What's the worse it can do?";
			int baseAttack = 0;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 4;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(CustomAbility);

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_Scared_Mouse.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_Scared_Mouse_e.png");

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
