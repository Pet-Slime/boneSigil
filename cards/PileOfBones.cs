using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class PileOfBones
    {
        public static void AddCard()
        {
            string internalName = "void_PileOfBones";
            string displayName = "Pile Of Bones";
            string description = "aaa";
            int attack = 0;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> cardMetaCategories = new List<CardMetaCategory>();
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list = new List<Ability>();
            list.Add((Ability)12);
            List<Trait> list2 = new List<Trait>();
            list2.Add((Trait)12);
            List<CardAppearanceBehaviour.Appearance> list3 = new List<CardAppearanceBehaviour.Appearance>();
            list3.Add((CardAppearanceBehaviour.Appearance)2);
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_pileofbones.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_pileofbones.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, cardMetaCategories, tribes, list2, list, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardExtensions.SetTerrain(cardInfo);
            CardManager.Add("void", cardInfo);
        }
    }
}
