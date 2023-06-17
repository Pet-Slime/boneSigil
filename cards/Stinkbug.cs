using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Stinkbug
    {
        // Token: 0x0600007B RID: 123 RVA: 0x00006FC8 File Offset: 0x000051C8
        public static void AddCard()
        {
            string internalName = "void_Stinkbug";
            string displayName = "Stinkbug";
            string description = "A stinkbug.";
            int attack = 1;
            int health = 2;
            int bloodCost = 0;
            int boneCost = 3;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                0,
                (CardMetaCategory)1
            };
            List<Tribe> list2 = new List<Tribe>
            {
                (Tribe)6
            };
            List<Ability> list3 = new List<Ability>
            {
                (Ability)83
            };
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_stinkbug.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_stinkbug_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}