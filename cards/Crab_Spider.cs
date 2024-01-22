﻿using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
	public static class Crab_Spider
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");
		public static void AddCard()
		{
			string name = "void_Crab_Spider";
			string displayName = "Spider Crab";
			string description = "A crab with long, easy to grab legs.";
			int baseAttack = 2;
			int baseHealth = 2;
			int bloodCost = 1;
			int boneCost = 4;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>(); 
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.TotemGUID))
            {
                Plugin.Log.LogMessage("Lily Totems found, Spider Crab is now aquatic");
                Tribes.Add(GuidManager.GetEnumValue<Tribe>("Lily.BOT", "aquatic"));
            }

            List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.TailOnHit);
			Abilities.Add(CustomAbility1);

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Crab_Spider.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Crab_Spider_e.png");

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
			newCard.SetTail("void_Crab_Leg", null);
			newCard.description = description;
			CardManager.Add("void", newCard);
		}
	}
}
