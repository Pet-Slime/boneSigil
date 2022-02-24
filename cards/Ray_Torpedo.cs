using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Ray_Torpedo
	{
		public static void AddCard()
		{
			var BloodCost = 2;
			var energycost = 0;
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost"))
			{
				Plugin.Log.LogMessage("Found Life cost API, Adjusting Ray's Cost");
				BloodCost = 0;
				energycost = -8;
			}
			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Zapper"));
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Electric"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_torpedoRay.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_torpedoRay_e.png");

			IceCubeIdentifier iceCubeId = null;

			Texture2D tailTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Angler_Alt.png");
			TailIdentifier tail = new TailIdentifier("Void_Angler_Lure", tailTexture, null);

			NewCard.Add(name: "void_torpedoRay",
				displayedName: "Torpedo Ray",
				baseAttack: 3,
				baseHealth: 3,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "A shocking Discovery!",
				hideAttackAndHealth: false,
				bloodCost: BloodCost,
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
