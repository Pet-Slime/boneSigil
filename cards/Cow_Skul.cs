using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Cow_Skul
    {
        public static void AddCard()
        {
            string internalName = "void_Cow_Skul";
            string displayName = "Cow Skeleton";
            string description = "Not much left.";
            int attack = 0;
            int health = 2;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> cardMetaCategories = new List<CardMetaCategory>();
            List<Tribe> list = new List<Tribe>();
            list.Add((Tribe)4);
            List<Ability> list2 = new List<Ability>();
            list2.Add(Cow_Skul.CustomAbility1);
            List<Trait> list3 = new List<Trait>();
            list3.Add((Trait)12);
            list3.Add((Trait)8);
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Cow_Skul.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Cow_Skul_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, cardMetaCategories, list, list3, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice");
    }
}