using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Ruby_Creature
    {
        public static void AddCard()
        {
            string internalName = "void_Ruby_Creature";
            string displayName = "Vulpecula";
            string description = "A lost little canine, who's fur shines like stars, looking for home.";
            int attack = 2;
            int health = 2;
            int bloodCost = 0;
            int boneCost = 6;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add(0);
            list.Add((CardMetaCategory)1);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)3);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)38);
            list3.Add((Ability)28);
            List<Trait> list4 = new List<Trait>();
            list4.Add((Trait)17);
            List<SpecialTriggeredAbility> list5 = new List<SpecialTriggeredAbility>();
            List<CardAppearanceBehaviour.Appearance> list6 = new List<CardAppearanceBehaviour.Appearance>();
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/void_ruby_creature.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/void_ruby_creature_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, list4, list3, null, bloodCost, boneCost, energyCost);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}