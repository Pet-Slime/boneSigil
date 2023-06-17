using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class Tortoise_Bell
    {
        // Token: 0x06000081 RID: 129 RVA: 0x00007380 File Offset: 0x00005580
        public static void AddCard()
        {
            string internalName = "void_Tortoise_Bell";
            string displayName = "Bell Turtle";
            string description = "A gift from the trapper, made of clockwork and gold.";
            int attack = 0;
            int health = 3;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)5);
            List<Ability> list3 = new List<Ability>();
            list3.Add(Tortoise_Bell.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Tortoise_Bell.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Tortoise_Bell_e.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/Void_Tortoise_Bell_alt.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardExtensions.SetIceCube(cardInfo, "void_Tortoise_Bell_Broken", null);
            CardExtensions.SetTail(cardInfo, "void_Scrap", textureFromPath3, null, null);
            CardExtensions.SetTerrain(cardInfo);
            cardInfo.appearanceBehaviour.Add((CardAppearanceBehaviour.Appearance)6);
            cardInfo.SetStatIcon((SpecialStatIcon)4);
            cardInfo.SetSpecialAbilities(SpecialTriggeredAbility.BellProximity);
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x04000036 RID: 54
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Resistant");
    }
}