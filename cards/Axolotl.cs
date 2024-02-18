using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
	public static class Axolotl
	{
		public static readonly Ability CustomAbility = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice");
        public static readonly CardMetaCategory SIDE_DECK_CATEGORY = GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.sidedecks", "SideDeck");

        public static void AddCard()
		{
			string name = "void_Axolotl";
			string displayName = "Undead Axolotl";
			string description = "Undead here? How... Her world must be leaking in...";
			int baseAttack = 0;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			if (!BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.StarterdeckGUID))
			{
				Plugin.Log.LogMessage("Did not find side decks, adding Undead Axolotl to the default pools");
				metaCategories.Add(CardMetaCategory.ChoiceNode);
				metaCategories.Add(CardMetaCategory.TraderOffer);
			}
			else
			{
				Plugin.Log.LogMessage("Found side decks, removing Undead Axolotl from the default pools");
                metaCategories.Add(SIDE_DECK_CATEGORY);
            }

			List<Tribe> Tribes = new List<Tribe>();
            if (!BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.TotemGUID))
            {
				Tribes.Add(Tribe.Reptile);
            } else
            {
                Plugin.Log.LogMessage("Lily Totems found, Axolotl is now undead aquatic instead of reptile");
                Tribes.Add(GuidManager.GetEnumValue<Tribe>("Lily.BOT", "undead"));
                Tribes.Add(GuidManager.GetEnumValue<Tribe>("Lily.BOT", "aquatic"));
            }
            

            List<Ability> Abilities = new List<Ability>();
			Abilities.Add(CustomAbility);
			Abilities.Add(Ability.QuadrupleBones);

			List<Trait> Traits = new List<Trait> { (Trait)5103 };
			Traits.Add(Trait.Undead);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_undeadAxolotle.png");
			Texture2D pixelTexture = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_axol.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_undeadAxolotle_e.png");

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
            CardManager.Add("void", newCard);
		}
	}
}
