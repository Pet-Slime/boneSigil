using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Bear
    {
        public static void AddCard()
        {
            string internalName = "void_Bear";
            string displayName = "Kodiak";
            string description = "A bear that is an expert scavanger and fisher.";
            int attack = 3;
            int health = 6;
            int bloodCost = 1;
            int boneCost = 10;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add(Bear.CustomAbility1);
            List<Trait> list3 = new List<Trait>();
            list3.Add((Trait)5);
            List<SpecialTriggeredAbility> list4 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list5 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Bear.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Bear_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, list3, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Lure");
    }
}
