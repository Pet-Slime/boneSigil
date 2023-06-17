using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Tortoise_Spiny
    {
        public static void AddCard()
        {
            string internalName = "void_Tortoise_Spiny";
            string displayName = "Spiny Turtle";
            string description = "A hard shell with spikes to boot.";
            int attack = 1;
            int health = 5;
            int bloodCost = 1;
            int boneCost = 5;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                0,
                (CardMetaCategory)1
            };
            List<Tribe> list2 = new List<Tribe>
            {
                (Tribe)5
            };
            List<Ability> list3 = new List<Ability>
            {
                (Ability)15,
                Tortoise_Spiny.CustomAbility1
            };
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_tortoise_spiny.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_tortoise_spiny_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");
    }
}