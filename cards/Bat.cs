using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Bat
    {
        public static void AddCard()
        {
            string internalName = "void_Bat";
            string displayName = "Spectral Bat";
            string description = "Rarely seen, this bat haunts the shadows.";
            int attack = 4;
            int health = 5;
            int bloodCost = 1;
            int boneCost = 7;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add(Bat.CustomAbility2);
            List<Trait> list3 = new List<Trait>();
            list3.Add((Trait)10);
            List<SpecialTriggeredAbility> list4 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list5 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Bat.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Bat_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, list3, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility2 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Possessor");
    }
}