using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Ant_ArmorCutter
    {
        // Token: 0x0600003C RID: 60 RVA: 0x0000423C File Offset: 0x0000243C
        public static void AddCard()
        {
            string internalName = "void_Leaf_Ant";
            string displayName = "Armored Ant";
            string description = "A leaf cutter ant that has a mineral shell and lives in the trees.";
            int attack = 0;
            int health = 4;
            int bloodCost = 1;
            int boneCost = 3;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)6);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)23);
            list3.Add(Ant_ArmorCutter.CustomAbility);
            List<Trait> list4 = new List<Trait>();
            list4.Add((Trait)11);
            List<SpecialTriggeredAbility> list5 = new List<SpecialTriggeredAbility>();
            list5.Add((SpecialTriggeredAbility)6);
            List<CardAppearanceBehaviour.Appearance> list6 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Leaf_Ant.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Leaf_Ant_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, list4, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.SetStatIcon(SpecialStatIcon.Ants);
            cardInfo.SetSpecialAbilities(SpecialTriggeredAbility.Ant);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x0400001A RID: 26
        public static readonly Ability CustomAbility = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Thick Shell");
    }
}
