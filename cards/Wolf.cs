using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Wolf
    {
        public static void AddCard()
        {
            string internalName = "void_Wolf";
            string displayName = "Hurt Wolf";
            string description = "The hurt wolf calls for aid!";
            int attack = 1;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 4;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                0,
                (CardMetaCategory)1
            };
            List<Tribe> list2 = new List<Tribe>
            {
                (Tribe)3
            };
            List<Ability> list3 = new List<Ability>
            {
                Wolf.CustomAbility1
            };
            List<Trait> traits = new List<Trait>();
            List<SpecialTriggeredAbility> list4 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list5 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_wolf.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_wolf_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Tribal Tutor");
    }
}