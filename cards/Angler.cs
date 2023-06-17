using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using boneSigils.Managers;

namespace boneSigils.cards
{
    public static class Angler
    {

        public static void AddCard()
        {
            string text = "void_Angler";
            string text2 = "Black Seadevil";
            string description = "A light in the dark ocean, it isn't friendly.";
            int num = 2;
            int num2 = 1;
            int bloodCost = 0;
            int boneCost = 4;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)13);
            list2.Add(Angler.CustomAbility);
            List<Trait> traits = new List<Trait>();
            List<SpecialTriggeredAbility> list3 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list4 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Angler.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Angler_e.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_blank.png");
            string internalName = text;
            string displayName = text2;
            int attack = num;
            int health = num2;
            Texture2D texture_base = textureFromPath;
            Texture2D texture_emission = textureFromPath2;
            Texture2D texture_pixel = textureFromPath3;
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, texture_base, texture_emission, list, tribes, traits, list2, texture_pixel, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardExtensions.SetTail(cardInfo, "void_Angler_Lure", SigilUtils.GetTextureFromPath("Artwork/void_angler_alt.png"), null, null);
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Lure");
    }
}