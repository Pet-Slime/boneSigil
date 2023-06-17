using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Wolverine
    {
        public static void AddCard()
        {
            string internalName = "void_Wolverine";
            string displayName = "Hungry Wolverine";
            string description = "Tenacious creatures, that can help you find bones.";
            int attack = 0;
            int health = 3;
            int bloodCost = 0;
            int boneCost = 4;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                0,
                (CardMetaCategory)1
            };
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>
            {
                (Ability)28,
                Wolverine.CustomAbility1
            };
            List<Trait> list3 = new List<Trait>
            {
                (Trait)19
            };
            List<SpecialTriggeredAbility> list4 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list5 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Wolverine.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Wolverine_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, list3, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Vicious");
    }
}