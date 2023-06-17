using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Rabbit
    {
        public static void AddCard()
        {
            string internalName = "void_Rabbit";
            string displayName = "Beast of Caerbannog";
            string description = "Some call it Tim.";
            int attack = 1;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                0
            };
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>
            {
                (Ability)4
            };
            List<Trait> list3 = new List<Trait>
            {
                (Trait)19
            };
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Rabbit.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Rabbit_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, list3, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Agile");
    }
}