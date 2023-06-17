using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Egg
    {
        public static void AddCard()
        {
            string internalName = "void_Egg";
            string displayName = "Vulture Egg";
            string description = "An egg of a vulture, left among rocks.";
            int attack = 0;
            int health = 3;
            int bloodCost = 0;
            int boneCost = 3;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)2);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)5);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_egg.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_egg_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            CardExtensions.SetEvolve(cardInfo, "Void_Vulture", 2, null);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}