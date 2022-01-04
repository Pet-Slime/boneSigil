using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Bone_Lord
	{
		public static void AddCard()
		{

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.BoneDigger);
			Abilities.Add(Ability.DrawCopyOnDeath);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Undead);

			List<AbilityIdentifier> customAbilities = new List<AbilityIdentifier>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.RareCardBackground);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/void_horn.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/void_horn_e.png");

			IceCubeIdentifier iceCubeId = null;

			TailIdentifier tail = null;

			NewCard.Add(name: "Void_Bone_Lord",
				displayedName: "The Bone Lord",
				baseAttack: 7,
				baseHealth: 7,
				metaCategories,
				cardComplexity: CardComplexity.Advanced,
				temple: CardTemple.Nature,
				description: "The Lord of Bones has decided to get his hands dirty this time.",
				hideAttackAndHealth: false,
				bloodCost: 2,
				bonesCost: 10,
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
