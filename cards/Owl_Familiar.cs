using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Owl_Familiar
    {
        public static void AddCard()
        {
            string text = "void_Owl_Familiar";
            string text2 = "Owl Familar";
            string description = "A small owl, who helps out allies when they can.";
            int num = 1;
            int num2 = 1;
            int bloodCost = 0;
            int boneCost = 3;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)2);
            List<Ability> list3 = new List<Ability>();
            list3.Add(Owl_Familiar.CustomAbility1);
            list3.Add(Owl_Familiar.CustomAbility2);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Owl_Familiar.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_owl_familiar.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/Void_Owl_Familiar_e.png");
            string internalName = text;
            string displayName = text2;
            int attack = num;
            int health = num2;
            Texture2D texture_base = textureFromPath;
            Texture2D texture_emission = textureFromPath3;
            Texture2D texture_pixel = textureFromPath2;
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, texture_base, texture_emission, list, list2, traits, list3, texture_pixel, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x0400002C RID: 44
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Familiar");

        // Token: 0x0400002D RID: 45
        public static readonly Ability CustomAbility2 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Bone Picker");
    }
}