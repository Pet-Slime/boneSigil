using System;
using System.Collections;
using System.Collections.Generic;
using DiskCardGame;
using System.IO;
using APIPlugin;
using UnityEngine;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils
{
    public class DairyCowSpecialAbility : SpecialCardBehaviour
    {
        public SpecialTriggeredAbility SpecialAbility => specialAbility;
        public static SpecialTriggeredAbility specialAbility;


        public static void AddSteakAbility()
        {
            StatIconInfo iconInfo = new StatIconInfo();
            iconInfo.rulebookName = "Steak";
            iconInfo.rulebookDescription = "Leaves behind Steak when killed";
            iconInfo.iconType = SpecialStatIcon.None;
            iconInfo.iconGraphic = SigilUtils.LoadTextureFromResource(Resources.void_steak_ability);
            iconInfo.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Modular, AbilityMetaCategory.Part1Rulebook };

            SpecialAbilityIdentifier identifier = SpecialAbilityIdentifier.GetID(Plugin.PluginGuid, "DairyCowSpecialAbility");

            NewSpecialAbility newSpecialAbility = new NewSpecialAbility(typeof(DairyCowSpecialAbility), identifier, iconInfo);
            specialAbility = newSpecialAbility.specialTriggeredAbility;        
        }

        public override bool RespondsToDie(bool wasSacrifice, PlayableCard killer)
        {
            return base.PlayableCard.OnBoard;
        }

        public override IEnumerator OnDie(bool wasSacrifice, PlayableCard killer)
        {
            yield return new WaitForSeconds(0.35f);
            yield return Singleton<CardSpawner>.Instance.SpawnCardToHand(CardLoader.GetCardByName("Void_Steak"), null, 0.25f, null);
            yield return new WaitForSeconds(0.35f);
            yield break;
        }
        
        }
}