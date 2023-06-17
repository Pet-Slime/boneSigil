using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class MurderOfCrows
    {
        public static void AddCard()
        {
            string internalName = "void_Crows_Murder";
            string displayName = "Murder of Crows";
            string description = "A flock of black clouds swam and then leave, with the only thing remaining are bones.";
            int attack = 2;
            int health = 3;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)3);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)2);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)19);
            List<Trait> traits = new List<Trait>();
            List<GemType> list4 = new List<GemType>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Murder_of_Crows.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Murder_of_Crows_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            CardExtensions.AddSpecialAbilities(cardInfo, new SpecialTriggeredAbility[]
            {
                MurderOfCrowsSpecialAbility.specialAbility
            });
            cardInfo.appearanceBehaviour.Add((CardAppearanceBehaviour.Appearance)7);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}