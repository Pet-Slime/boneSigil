using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Steak
    {
        public static void AddCard()
        {
            string internalName = "void_Steak";
            string displayName = "Fresh Steak";
            string description = "Mhm, steak.";
            int attack = 0;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> cardMetaCategories = new List<CardMetaCategory>();
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list = new List<Ability>();
            list.Add(Steak.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Steak.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Steak.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, cardMetaCategories, tribes, traits, list, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardExtensions.AddAppearances(cardInfo, new CardAppearanceBehaviour.Appearance[]
            {
                (CardAppearanceBehaviour.Appearance)7
            });
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x04000033 RID: 51
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Nutritious");
    }
}