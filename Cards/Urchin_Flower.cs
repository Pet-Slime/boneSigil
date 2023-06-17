using boneSigils.Managers;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace boneSigils.Cards
{
    public static class Urchin_Flower
    {
        public static void AddCard()
        {
            string internalName = "void_Urchin_Flower";
            string displayName = "Flower Urchin";
            string description = "Becareful where you step when going over water.";
            int attack = 2;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 7;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                (CardMetaCategory)1,
                0
            };
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>
            {
                Urchin_Flower.CustomAbility1,
                (Ability)13
            };
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_urchin_flower.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_urchin_flower_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x0400003A RID: 58
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Submerged Ambush");
    }
}
