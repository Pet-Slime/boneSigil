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
    public static class Ray_Manta
    {
        // Token: 0x06000070 RID: 112 RVA: 0x000069C0 File Offset: 0x00004BC0
        public static void AddCard()
        {
            string internalName = "void_Ray_Manta";
            string displayName = "Manta Ray";
            string description = "The largest of the rays, they swim together in circles, causing rough waters for other aquatic life.";
            int attack = 1;
            int health = 2;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add(Ray_Manta.CustomAbility1);
            list2.Add((Ability)13);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_ray_manta.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_ray_manta_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x0400002F RID: 47
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Turbulent Waters");
    }
}
