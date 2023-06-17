using boneSigils.Managers;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace boneSigils.Cards
{
    public static class Mouse_Scared
    {
        public static void AddCard()
        {
            string internalName = "void_Scared_Mouse";
            string displayName = "Scared Mouse";
            string description = "A frightened mouse, causing a panic. What's the worse it can do?";
            int attack = 0;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 4;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add(Mouse_Scared.CustomAbility);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_Scared_Mouse.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_Scared_Mouse_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Stampede");
    }
}
