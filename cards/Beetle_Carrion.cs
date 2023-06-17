using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Beetle_Carrion
    {
        public static void AddCard()
        {
            string internalName = "void_Beetle_Carrion";
            string displayName = "Carrion Beetle";
            string description = "A hard shell and a taste of flesh, they can find any fresh corpse.";
            int attack = 2;
            int health = 4;
            int bloodCost = 0;
            int boneCost = 7;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)3);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)6);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)11);
            list3.Add(Beetle_Carrion.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Beetle.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Beetle_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.appearanceBehaviour.Add((CardAppearanceBehaviour.Appearance)7);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x0400001F RID: 31
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");
    }
}
