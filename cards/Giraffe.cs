using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Giraffe
    {
        public static void AddCard()
        {
            string internalName = "void_Giraffe";
            string displayName = "Giraffe";
            string description = "A herbivore that loves to chew on bones.";
            int attack = 1;
            int health = 5;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)4);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)3);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_giraffe.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_giraffe_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}
