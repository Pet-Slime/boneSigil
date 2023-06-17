using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Beetle_Larvae
    {

        public static void AddCard()
        {
            string text = "void_Beetle_Larva";
            string text2 = "Beetle Larva";
            string description = "A monsterously sized larvae, and a tasty one to boot!";
            int num = 1;
            int num2 = 3;
            int bloodCost = 0;
            int boneCost = 3;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)6);
            List<Ability> list3 = new List<Ability>();
            list3.Add(ability_Pupate.ability);
            List<Trait> traits = new List<Trait>();
            List<SpecialTriggeredAbility> list4 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list5 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_beetle_larva.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_beetle_larvae.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/void_beetle_larva_e.png");
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
    }
}
