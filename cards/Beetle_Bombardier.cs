using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Beetle_Bombardier
    {
        public static void AddCard()
        {
            string internalName = "void_Beetle_Bombardier";
            string displayName = "Bombardier Beetle";
            string description = "A beetle that shoots artillier goop, at foes and allies alike...";
            int attack = 2;
            int health = 4;
            int bloodCost = 0;
            int boneCost = 7;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)6);
            List<Ability> list3 = new List<Ability>();
            list3.Add(Beetle_Bombardier.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            List<SpecialTriggeredAbility> list4 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list5 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Beetle_Bombardier.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Beetle_Bombardier_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Bombardier");
    }
}
