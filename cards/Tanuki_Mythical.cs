using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Tanuki_Mythical
    {
        public static void AddCard()
        {
            string internalName = "void_Tanuki_Mythical";
            string displayName = "Mythical Tanuki";
            string description = "The crafty tanuki, who can steal anything from any beast.";
            int attack = 2;
            int health = 5;
            int bloodCost = 0;
            int boneCost = 8;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add(0);
            list.Add((CardMetaCategory)1);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)3);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)101);
            list3.Add(Tanuki_Mythical.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_tanuki_mythical.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_tanuki_mythical_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x04000034 RID: 52
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thief");
    }
}