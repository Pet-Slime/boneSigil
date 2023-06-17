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
    public static class Tanuki_Pup
    {
        public static void AddCard()
        {
            string text = "void_Tanuki_pup";
            string text2 = "Tanuki Pup";
            string description = "A young Tanuki, scavenging for bones.";
            int num = 0;
            int num2 = 1;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            bool flag = !Chainloader.PluginInfos.ContainsKey("zorro.inscryption.infiniscryption.sidedecks");
            if (flag)
            {
                Plugin.Log.LogMessage("Did not find side decks, adding tanuki pups to the default pools");
                list.Add(0);
                list.Add((CardMetaCategory)1);
            }
            else
            {
                Plugin.Log.LogMessage("Found side decks, removing tanuki pups from the default pools");
                list.Add(Tanuki_Pup.SIDE_DECK_CATEGORY);
            }
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)3);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)101);
            list3.Add((Ability)5);
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Tanuki_Pup.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_tanuki.png");
            Texture2D textureFromPath3 = SigilUtils.GetTextureFromPath("Artwork/Void_Tanuki_Pup_e.png");
            string internalName = text;
            string displayName = text2;
            int attack = num;
            int health = num2;
            Texture2D texture_base = textureFromPath;
            Texture2D texture_emission = textureFromPath3;
            Texture2D texture_pixel = textureFromPath2;
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, texture_base, texture_emission, list, list2, traits, list3, texture_pixel, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardExtensions.SetEvolve(cardInfo, "void_Tanuki", 3, null);
            CardManager.Add("void", cardInfo);
        }


        public static readonly CardMetaCategory SIDE_DECK_CATEGORY = GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.sidedecks", "SideDeck");
    }
}
