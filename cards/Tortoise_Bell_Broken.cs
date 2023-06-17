using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Tortoise_Bell_Broken
    {
        // Token: 0x06000083 RID: 131 RVA: 0x000074AC File Offset: 0x000056AC
        public static void AddCard()
        {
            string text = "void_Tortoise_Bell_Broken";
            string text2 = "Broken Bell Turtle";
            string description = "A broken bell turtle, left out in the wild. Poor thing. Seems like it has two hits left...";
            int num = 1;
            int num2 = 1;
            int bloodCost = 0;
            int boneCost = 3;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                0
            };
            List<Tribe> list2 = new List<Tribe>
            {
                (Tribe)5
            };
            List<Ability> list3 = new List<Ability>
            {
                (Ability)54
            };
            List<Trait> list4 = new List<Trait>
            {
                (Trait)12
            };
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Tortoise_Bell_Broken.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_bell_turtle.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/Void_Tortoise_Bell_Broken_e.png");
            string internalName = text;
            string displayName = text2;
            int attack = num;
            int health = num2;
            Texture2D texture_base = textureFromPath;
            Texture2D texture_emission = textureFromPath3;
            Texture2D texture_pixel = textureFromPath2;
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, texture_base, texture_emission, list, list2, list4, list3, texture_pixel, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            cardInfo.appearanceBehaviour.Add((CardAppearanceBehaviour.Appearance)2);
            CardExtensions.SetEvolve(cardInfo, "void_Tortoise_Bell", 1, null);
            CardManager.Add("void", cardInfo);
        }
    }
}
