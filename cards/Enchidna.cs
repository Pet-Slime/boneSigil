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
    public static class Enchidna
    {
        // Token: 0x0600005E RID: 94 RVA: 0x00005474 File Offset: 0x00003674
        public static void AddCard()
        {
            string internalName = "void_Enchidna";
            string displayName = "Enchidna";
            string description = "One of the few mammals to use Electroreception.";
            int attack = 2;
            int health = 4;
            int bloodCost = 2;
            int boneCost = 4;
            int energyCost = 0;
            bool flag = Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost");
            if (flag)
            {
                Plugin.Log.LogMessage("Found Life cost API, Adjusting Enchidna's Cost from blood to money");
                bloodCost = 0;
                energyCost = -8;
            }
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)1);
            list.Add(0);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> list2 = new List<Ability>();
            list2.Add((Ability)15);
            list2.Add(Enchidna.CustomAbility1);
            List<Trait> traits = new List<Trait>();
            List<SpecialTriggeredAbility> list3 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list4 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_enchidna.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_enchidna_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, tribes, traits, list2, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }

        // Token: 0x04000028 RID: 40
        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Electric");
    }
}