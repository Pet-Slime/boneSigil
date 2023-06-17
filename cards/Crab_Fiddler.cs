using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Crab_fiddler
    {
        public static void AddCard()
        {
            string internalName = "void_Crab_Fiddler";
            string displayName = "Fiddler Crab";
            string description = "A mean crab with a large descrutive claw.";
            int attack = 2;
            int health = 2;
            int bloodCost = 1;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)72);
            list2.Add(Crab_fiddler.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            List<SpecialTriggeredAbility> list3 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list4 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Crab_Fiddler.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Crab_Fiddler_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            CardExtensions.SetTail(cardInfo, "void_Crab_Leg", null);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }


        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");
    }
}