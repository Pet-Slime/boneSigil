using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Crab_Leg
    {
        // Token: 0x06000058 RID: 88 RVA: 0x00005140 File Offset: 0x00003340
        public static void AddCard()
        {
            string internalName = "void_Crab_Leg";
            string displayName = "Crab Leg";
            string description = "The leg of a crab.";
            int attack = 0;
            int health = 2;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> cardMetaCategories = new List<CardMetaCategory>();
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list = new List<Ability>();
            list.Add(Crab_Leg.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_crab_leg.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_crab_leg_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, cardMetaCategories, tribes, traits, list, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x04000026 RID: 38
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Nutritious");
    }
}
