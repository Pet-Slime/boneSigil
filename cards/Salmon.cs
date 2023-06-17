using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Salmon
    {
        // Token: 0x06000075 RID: 117 RVA: 0x00006C94 File Offset: 0x00004E94
        public static void AddCard()
        {
            string internalName = "void_Salmon";
            string displayName = "Undead Salmon";
            string description = "Undead here . . . how?";
            int attack = 2;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 3;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                0,
                (CardMetaCategory)1
            };
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>
            {
                (Ability)12,
                Salmon.CustomAbility1
            };
            List<Trait> list3 = new List<Trait>
            {
                (Trait)8
            };
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_undeadSalmon.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_undeadSalmon_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, list3, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x04000032 RID: 50
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice");
    }
}
