using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using BepInEx.Bootstrap;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Ray_Torpedo
    {
        // Token: 0x06000072 RID: 114 RVA: 0x00006A98 File Offset: 0x00004C98
        public static void AddCard()
        {
            string internalName = "void_Ray_Torpedo";
            string displayName = "Torpedo Ray";
            string description = "A ray that uses electromatism to sting and stun prey.";
            int attack = 3;
            int health = 3;
            int bloodCost = 2;
            int boneCost = 4;
            int energyCost = 0;
            bool flag = Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost");
            if (flag)
            {
                Plugin.Log.LogMessage("Found Life cost API, Adjusting Ray's Cost");
                bloodCost = 0;
                energyCost = -8;
            }
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add(Ray_Torpedo.CustomAbility1);
            list2.Add(Ray_Torpedo.CustomAbility2);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_torpedoRay.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_torpedoRay_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x04000030 RID: 48
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Zapper");

        // Token: 0x04000031 RID: 49
        public static readonly Ability CustomAbility2 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Electric");
    }
}