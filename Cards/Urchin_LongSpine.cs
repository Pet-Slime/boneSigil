using boneSigils.Managers;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace boneSigils.Cards
{
    public static class Urchin_LongSpine
    {
        public static void AddCard()
        {
            string internalName = "void_Urchin_LongSpine";
            string displayName = "Banded Diadem";
            string description = "Becareful where you step when going over water.";
            int attack = 1;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 4;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                (CardMetaCategory)1,
                0
            };
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>
            {
                Urchin_LongSpine.CustomAbility1
            };
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_urchin_LongSpine.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_urchin_LongSpine_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Poisonous");
    }
}
