using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Tortoise_Small
    {
        public static void AddCard()
        {
            string internalName = "void_Tortoise_Small";
            string displayName = "Spotted Tortoise";
            string description = "Small, yet tough. It seeks out bones to suckle on to help get minerals it lacks.";
            int attack = 1;
            int health = 3;
            int bloodCost = 1;
            int boneCost = 3;
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
                (Ability)28,
                Tortoise_Small.CustomAbility1
            };
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_tortoise_spotted.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_tortoise_spotted_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");
    }
}