using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Vulture
    {
        public static void AddCard()
        {
            string internalName = "void_Vulture";
            string displayName = "Bearded Vulture";
            string description = "A Vulture that consumes bone.";
            int attack = 0;
            int health = 5;
            int bloodCost = 0;
            int boneCost = 9;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
        {
            0,
            (CardMetaCategory)1
        };
            List<Tribe> list2 = new List<Tribe>
        {
            (Tribe)2
        };
            List<Ability> list3 = new List<Ability>
        {
            (Ability)19
        };
            List<Trait> list4 = new List<Trait>
        {
            (Trait)19
        };
            List<SpecialTriggeredAbility> list5 = new List<SpecialTriggeredAbility>
        {
            (SpecialTriggeredAbility)8
        };
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Vulture.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Vulture_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, list4, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            cardInfo.SetStatIcon((SpecialStatIcon)2);
            cardInfo.SetSpecialAbilities(SpecialTriggeredAbility.Lammergeier);
            CardManager.Add("void", cardInfo);
        }
    }
}
