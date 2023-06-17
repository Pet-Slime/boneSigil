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
    public static class Urchin_Sea
    {
        // Token: 0x0600008E RID: 142 RVA: 0x000079DC File Offset: 0x00005BDC
        public static void AddCard()
        {
            string internalName = "void_Urchin_Sea";
            string displayName = "Sea Urchin";
            string description = "Becareful where you step when going over water.";
            int attack = 1;
            int health = 1;
            int bloodCost = 0;
            int boneCost = 5;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>
            {
                (CardMetaCategory)1,
                0
            };
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>
            {
                (Ability)13,
                Urchin_Sea.CustomAbility1
            };
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_sea_urchin.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_sea_urchin_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x0400003C RID: 60
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Submerged Ambush");
    }
}
