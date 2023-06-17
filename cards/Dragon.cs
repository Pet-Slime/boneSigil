using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Dragon
    {
        public static void AddCard()
        {
            string internalName = "void_Dragon";
            string displayName = "Komodo Dragon";
            string description = "The largest and toughest of the reptiles, with a poisonous bite that can kill anything.";
            int attack = 2;
            int health = 5;
            int bloodCost = 1;
            int boneCost = 10;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)5);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)4);
            List<Trait> list4 = new List<Trait>();
            list4.Add((Trait)19);
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Dragon.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Dragon_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, list4, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}