using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Cow_Wild
    {
        public static void AddCard()
        {
            string internalName = "void_Cow_Wild";
            string displayName = "Charging Bull";
            string description = "You don't want to be infront of this bull.";
            int attack = 4;
            int health = 5;
            int bloodCost = 0;
            int boneCost = 13;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)4);
            List<Ability> list3 = new List<Ability>();
            list3.Add(Cow_Wild.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_cow_wild.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_cow_wild_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            CardExtensions.SetIceCube(cardInfo, "void_Cow_Skul", null);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Ram");
    }
}