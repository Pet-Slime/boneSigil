using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using boneSigils.Managers;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
    public static class Cow_Dairy
    {
        public static void AddCard()
        {
            string internalName = "void_Cow_Dairy";
            string displayName = "Dairy Cow";
            string description = "A cow fit for slaughter.";
            int attack = 0;
            int health = 2;
            int bloodCost = 0;
            int boneCost = 4;
            int energyCost = 0;
            List<CardMetaCategory> list = new List<CardMetaCategory>();
            list.Add((CardMetaCategory)3);
            List<Tribe> list2 = new List<Tribe>();
            list2.Add((Tribe)4);
            List<Ability> list3 = new List<Ability>();
            list3.Add((Ability)22);
            List<Trait> list4 = new List<Trait>();
            list4.Add((Trait)20);
            List<SpecialTriggeredAbility> list5 = new List<SpecialTriggeredAbility>();
            list5.Add(DairyCowSpecialAbility.specialAbility);
            Texture2D textureFromPath = SigilUtils.GetTextureFromPath("Artwork/Void_Dairy_Cow.png");
            Texture2D textureFromPath2 = SigilUtils.GetTextureFromPath("Artwork/Void_Dairy_Cow_e.png");
            CardInfo cardInfo = SigilUtils.CreateCardWithDefaultSettings(internalName, displayName, attack, health, textureFromPath, textureFromPath2, list, list2, list4, list3, null, bloodCost, boneCost, energyCost);
            CardExtensions.AddSpecialAbilities(cardInfo, new SpecialTriggeredAbility[]
            {
                DairyCowSpecialAbility.specialAbility
            });
            CardExtensions.SetIceCube(cardInfo, "void_Cow_Skul", null);
            cardInfo.appearanceBehaviour.Add((CardAppearanceBehaviour.Appearance)7);
            cardInfo.description = description;
            CardManager.Add("void", cardInfo);
        }
    }
}