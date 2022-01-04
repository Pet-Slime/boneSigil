using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Tortoise_Bell
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();

			List<Trait> Traits = new List<Trait>();

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();
			customAbilities.Add(AbilityIdentifier.GetID("extraVoid.inscryption.voidSigils", "Resistant"));

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.BellProximity);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.GoldEmission);
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.TerrainBackground);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Tortoise_Bell.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Tortoise_Bell_e.png");

			IceCubeIdentifier iceCubeId = new IceCubeIdentifier("Void_Tortoise_Bell_Broken", null);


			Texture2D tailTexture = SigilUtils.GetTextureFromPath("Artwork/Void_Tortoise_Bell_alt.png");
			TailIdentifier tail = new TailIdentifier("Void_Scrap", tailTexture, null);

			NewCard.Add(name: "Void_Tortoise_Bell",
				displayedName: "Bell Turtle",
				baseAttack: 0,
				baseHealth: 3,
				metaCategories,
				cardComplexity: CardComplexity.Simple,
				temple: CardTemple.Nature,
				description: "A gift from the trapper, made of clockwork and gold.",
				hideAttackAndHealth: false,
				bloodCost: 0,
				bonesCost: 5,
				energyCost: 0,
				gemsCost: null,
				specialStatIcon: SpecialStatIcon.Bell,
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
