using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Bone_Lord
    {
        public static void AddCard()
        {
            string internalName = "void_Bone_Lord";
            string displayName = "The Bone Lord's Avatar";
            string description = "The Lord of Bones has decided to send an avatar to help you.";
            int attack = 7;
            int health = 7;
            int bloodCost = 2;
            int boneCost = 10;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)3);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)28);
            list2.Add((Ability)14);
            List<Trait> list3 = new List<Trait>();
            list3.Add((Trait)8);
            list3.Add((Trait)20);
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_horn.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_horn_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, list3, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            cardInfo.appearanceBehaviour.Add((CardAppearanceBehaviour.Appearance)7);
            CardManager.Add("void", cardInfo);
        }
    }
}