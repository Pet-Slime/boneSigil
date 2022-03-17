﻿using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Tanuki_Pup
	{
		public static void AddCard()
		{
			string name = "Void_Tanuki_pup";
			string displayName = "Tanuki Pup";
			int baseAttack = 0;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			if (!BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.StarterdeckGUID))
            {
				Plugin.Log.LogMessage("Did not find side decks, adding tanuki pups to the default pools");
				metaCategories.Add(CardMetaCategory.ChoiceNode);
				metaCategories.Add(CardMetaCategory.TraderOffer);

			} else
			{
				Plugin.Log.LogMessage("Found side decks, removing tanuki pups from the default pools");
			}

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Canine);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.BoneDigger);
			Abilities.Add(Ability.Evolve);

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Tanuki_Pup.png");
			Texture2D pixelTexture = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_tanuki.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Tanuki_Pup_e.png");

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
			newCard.SetEvolve("void_Tanuki", 3);
			CardManager.Add(newCard);
		}
	}
}
