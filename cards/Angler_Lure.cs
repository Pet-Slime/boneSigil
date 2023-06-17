using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Angler_Lure
    {
        public static void AddCard()
        {
            string text = "void_Angler_Lure";
            string text2 = "Broken Lure";
            string description = "A Lure pulled from an angler.";
            int num = 0;
            int num2 = 2;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> cardMetaCategories = new List<CardMetaCategory>();
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> abilities = new List<Ability>();
            List<Trait> traits = new List<Trait>();
            List<SpecialTriggeredAbility> list = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list2 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_angler_light.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_angler_light_e.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_blank.png");
            string internalName = text;
            string displayName = text2;
            int attack = num;
            int health = num2;
            Texture2D texture_base = textureFromPath;
            Texture2D texture_emission = textureFromPath2;
            Texture2D texture_pixel = textureFromPath3;
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, texture_base, texture_emission, cardMetaCategories, tribes, traits, abilities, texture_pixel, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}
