using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Mantis_Shrimp
    {
        public static void AddCard()
        {
            string internalName = "void_Shrimp_Mantis";
            string displayName = "Mantis Shrimp";
            string description = "A shrimp with a deadly punch, one that can boil water with the force of it.";
            int attack = 3;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                (CardMetaCategory)1,
                0
            };
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add(Mantis_Shrimp.CustomAbility1);
            list2.Add(Mantis_Shrimp.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Mantis_Shrimp.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Mantis_Shrimp_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x04000029 RID: 41
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Ambush");
    }
}