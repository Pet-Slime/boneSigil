using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Serpent_Jade
    {
        public static void AddCard()
        {
            string internalName = "void_Jade_Serpent";
            string displayName = "Jade Serpent";
            string description = "A serpent who's scales shimmer like jade.";
            int attack = 3;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)5);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)37);
            List<Trait> list4 = new List<Trait>();
            list4.Add((Trait)17);
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Jade_Serpent.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Jade_Serpent_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, list4, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}
