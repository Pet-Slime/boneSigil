using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Axolotl
	{
		public static readonly Ability CustomAbility = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice");

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
			}

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(CustomAbility);
			Abilities.Add(Ability.QuadrupleBones);

			List<Trait> Traits = new List<Trait> { (Trait)5103 };
			Traits.Add(Trait.Undead);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("void_undeadAxolotle.png");
			Texture2D pixelTexture = SigilUtils.GetTextureFromPath("pixelportrait_axol.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("void_undeadAxolotle_e.png");

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
