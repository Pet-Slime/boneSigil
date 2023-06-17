using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Beetle_Scarab
    {

        public static void AddCard()
        {
            string internalName = "void_Scarab_Jewel";
            string displayName = "Jeweled Scarab";
            string description = "The blue jewel on it's back shines bright.";
            int attack = 1;
            int health = 5;
            int bloodCost = 0;
            int boneCost = 7;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)6);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)39);
            list3.Add((Ability)8);
            List<Trait> list4 = new List<Trait>();
            list4.Add((Trait)17);
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_scarab_jewel.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_scarab_jewel_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, list4, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}