using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Enchidna
	{
		public static void AddCard()
		{
			var bloodcost = 2;
			var energycost = 0;
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost"))
			{
				Plugin.Log.LogMessage("Found Life cost API, Adjusting Enchidna's Cost");

				bloodcost = 0;
				energycost = -8;
			}
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Sharp);

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Electric"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_enchidna.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_enchidna_e.png");

			IceCubeIdentifier iceCubeId = null;

			TailIdentifier tail = null;

			NewCard.Add(name: "Void_Enchidna",
				displayedName: "Enchidna",
				baseAttack: 2,
				baseHealth: 4,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "One of the few mammals to use Electroreception.",
				hideAttackAndHealth: false,
				bloodCost: bloodcost,
				bonesCost: 3,
				energyCost: energycost,
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
				pixelTex: null,
				eTexture,
				animatedPortrait: null,
				decals: null,
				evolveId: null,
				iceCubeId,
				tail);
		}
	}
}
