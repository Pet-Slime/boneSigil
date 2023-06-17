using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Cow_Mad
    {
        public static void AddCard()
        {
            string internalName = "void_Cow_Mad";
            string displayName = "The Dying Bull";
            string description = "The Mad Bull, out for bones with not much time left.";
            int attack = 3;
            int health = 4;
            int bloodCost = 0;
            int boneCost = 5;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)4);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)5);
            list3.Add(Cow_Mad.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            List<SpecialTriggeredAbility> list4 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list5 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_cow_mad.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_cow_mad_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            CardExtensions.SetIceCube(cardInfo, "void_Cow_Skul", null);
            CardExtensions.SetEvolve(cardInfo, "void_Cow_Skul", 2, null);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Blight");
    }
}