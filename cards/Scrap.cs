using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Scrap
    {
        public static void AddCard()
        {
            string internalName = "void_Scrap";
            string displayName = "Scrap";
            string description = "Junk left behind by the Trapper.";
            int attack = 0;
            int health = 2;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> cardMetaCategories = new List<CardMetaCategory>();
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> abilities = new List<Ability>();
            List<Trait> list = new List<Trait>();
            list.Add((Trait)12);
            List<SpecialTriggeredAbility> list2 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list3 = new List<CardAppearanceBehaviour.Appearance>();
            list3.Add((CardAppearanceBehaviour.Appearance)2);
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Screws.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Screws.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, cardMetaCategories, tribes, list, abilities, null, bloodCost, boneCost, energyCost);
            CardExtensions.SetTerrain(cardInfo);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}