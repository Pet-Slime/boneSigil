using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Axolotl
	{
		public static void AddCard()
		{

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

			List<Trait> Traits = new List<Trait> { (Trait)5103 };
			Traits.Add(Trait.Undead);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();

			customAbilities.Add(AbilityIdentifier.GetID("org.memez4life.inscryption.customsigils", "Bone prince 3"));
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_undeadAxolotle.png");

			Texture2D pixelTexture = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_axol.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_undeadAxolotle_e.png");

			IceCubeIdentifier iceCubeId = null;

			TailIdentifier tail = null;

			NewCard.Add(name: "Void_Axolotl",
				displayedName: "Undead Axolotl",
				baseAttack: 0,
				baseHealth: 1,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "Undead here? How... Her world must be leaking in...",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 0,
				energyCost: 0,
				gemsCost: null,
				specialStatIcon: SpecialStatIcon.None,
				Tribes,
				Traits,
				specialAbilities,
				Abilities,
				customAbilities,
				specialAbilitiesIdsParam: null,
				evolveParams: null,
				defaultEvolutionName: null,
				tailParams: null,
				iceCubeParams: null,
				flipPortraitForStrafe: false,
				onePerDeck: false,
				appearanceBehaviour,
				DefaultTexture,
				altTex: null,
				titleGraphic: null,
				pixelTex: pixelTexture,
				eTexture,
				animatedPortrait: null,
				decals: null,
				evolveId: null,
				iceCubeId,
				tail);


		}
	}
}
