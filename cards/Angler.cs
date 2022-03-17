using BepInEx.Logging;
using System;
using System.Reflection;
using HarmonyLib;
using BepInEx;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI;
using InscryptionAPI.Saves;
using InscryptionAPI.Card;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using InscryptionAPI.Encounters;
using System.Linq;

namespace boneSigils.cards
{
	public static class Angler
	{

		public static readonly Ability CustomAbility = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Lure");

		public static void AddCard()
		{
			string name = "Void_Angler";
			string displayName = "Black Seadevil";
			int baseAttack = 2;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 4;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Submerge);
			Abilities.Add(CustomAbility);

			List<Trait> Traits = new List<Trait>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Angler.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Angler_e.png");
			Texture2D pTexture = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_blank.png");

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

			newCard.SetTail("Void_Angler_Lure", SigilUtils.GetTextureFromPath("Artwork/void_angler_alt.png"));


			CardManager.Add(newCard);
		}
	}
}
