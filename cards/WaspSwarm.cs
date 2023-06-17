using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace boneSigils.cards
{
    public static class WaspSwarm
    {
        public static void AddCard()
        {
            string internalName = "void_Wasp_Swarm";
            string displayName = "Wasp Swarm";
            string description = "Where there is one, there is many.";
            int attack = 2;
            int health = 3;
            int bloodCost = 0;
            int boneCost = 7;
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
                ability_drawwasp.ability,
                WaspSwarm.CustomAbility1
            };
            List<Trait> traits = new List<Trait>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Wasp.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Wasp_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, traits, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardExtensions.SetTail(cardInfo, "void_Wasp_Swarm", null);
            cardInfo.defaultEvolutionName = "Monstrous";
            CardManager.Add("void", cardInfo);
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Multi-Strike");
    }
}