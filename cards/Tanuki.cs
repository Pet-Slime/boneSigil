using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Tanuki
    {
        public static void AddCard()
        {
            string internalName = "void_Tanuki";
            string displayName = "Tanuki";
            string description = "Ahhh the tanuki, a canine who likes to scavenge around.";
            int attack = 1;
            int health = 3;
            int bloodCost = 0;
            int boneCost = 4;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add(0);
            list.Add((CardMetaCategory)1);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)3);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)5);
            list3.Add((Ability)101);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_tanuki.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_tanuki_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardExtensions.SetEvolve(cardInfo, "void_Tanuki_Mythical", 2, null);
            CardManager.Add("void", cardInfo);
        }
    }
}
