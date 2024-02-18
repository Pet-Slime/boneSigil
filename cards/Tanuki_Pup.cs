using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
	public static class Tanuki_Pup
	{
		public static readonly CardMetaCategory SIDE_DECK_CATEGORY = GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.sidedecks", "SideDeck");
		public static void AddCard()
		{
			string name = "void_Tanuki_pup";
			string displayName = "Tanuki Pup";
			string description = "A young Tanuki, scavenging for bones.";
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
				metaCategories.Add(SIDE_DECK_CATEGORY);
			}

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Canine);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.OpponentBones);
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
			newCard.description = description;
            newCard.SetExtendedProperty("SideDeckValue", 5);
            newCard.SetEvolve("void_Tanuki", 2);
			CardManager.Add("void", newCard);
		}
	}
}
