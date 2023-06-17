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
    public static class Axolotl
    {
        // Token: 0x0600003E RID: 62 RVA: 0x00004354 File Offset: 0x00002554
        public static void AddCard()
        {
            string text = "void_Axolotl";
            string text2 = "Undead Axolotl";
            string description = "Undead here? How... Her world must be leaking in...";
            int num = 0;
            int num2 = 1;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            bool flag = !Chainloader.PluginInfos.ContainsKey("zorro.inscryption.infiniscryption.sidedecks");
            if (flag)
            {
                Plugin.Log.LogMessage("Did not find side decks, adding Undead Axolotl to the default pools");
                list.Add(0);
                list.Add((CardMetaCategory)1);
            }
            else
            {
                Plugin.Log.LogMessage("Found side decks, removing Undead Axolotl from the default pools");
            }
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)5);
            List<Ability> list3 = new List<Ability>();
            list3.Add(Axolotl.CustomAbility);
            list3.Add((Ability)12);
            List<Trait> list4 = new List<Trait>
            {
                (Trait)5103
            };
            list4.Add((Trait)8);
            List<SpecialTriggeredAbility> list5 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list6 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_undeadAxolotle.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_axol.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/void_undeadAxolotle_e.png");
            string internalName = text;
            string displayName = text2;
            int attack = num;
            int health = num2;
            Texture2D texture_base = textureFromPath;
            Texture2D texture_emission = textureFromPath3;
            Texture2D texture_pixel = textureFromPath2;
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, texture_base, texture_emission, list, list2, list4, list3, texture_pixel, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x0400001B RID: 27
        public static readonly Ability CustomAbility = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice");
    }
}
