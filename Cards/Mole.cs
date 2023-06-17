using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Mole
    {
        public static void AddCard()
        {
            string text = "void_Mole";
            string text2 = "Strange Mole";
            string description = "Another one of the trapper's toys.";
            int num = 1;
            int num2 = 3;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)8);
            list2.Add(Mole.CustomAbility1);
            List<Trait> list3 = new List<Trait>();
            list3.Add((Trait)14);
            list3.Add((Trait)12);
            List<SpecialTriggeredAbility> list4 = new List<SpecialTriggeredAbility>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_burrow.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_strange_mole.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/void_burrow_e.png");
            string internalName = text;
            string displayName = text2;
            int attack = num;
            int health = num2;
            Texture2D texture_base = textureFromPath;
            Texture2D texture_emission = textureFromPath3;
            Texture2D texture_pixel = textureFromPath2;
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, texture_base, texture_emission, list, tribes, list3, list2, texture_pixel, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            cardInfo.appearanceBehaviour.Add((CardAppearanceBehaviour.Appearance)2);
            CardExtensions.SetTail(cardInfo, "void_Scrap", null);
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x0400002A RID: 42
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Frightful");
    }
}