using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
	public static class Angler_Lure
	{
		public static void AddCard()
		{
			string name = "void_Angler_Lure";
			string displayName = "Broken Lure";
			string description = "A Lure pulled from an angler.";
			int baseAttack = 0;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> Tribes = new List<Tribe>();
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.TotemGUID))
            {
                Plugin.Log.LogMessage("Lily Totems found, Angeler's Lure is now aquatic");
                Tribes.Add(GuidManager.GetEnumValue<Tribe>("Lily.BOT", "aquatic"));
            }

            List<Ability> Abilities = new List<Ability>();

			List<Trait> Traits = new List<Trait>();


			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_angler_light.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_angler_light_e.png");
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
			newCard.description = description;
			CardManager.Add("void", newCard);
		}
	}
}
