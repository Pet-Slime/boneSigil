using System;
using System.Collections;
using DiskCardGame;
using InscryptionAPI.Card;
using UnityEngine;

namespace boneSigils
{
    public class DairyCowSpecialAbility : SpecialCardBehaviour
    {
        public SpecialTriggeredAbility SpecialAbility
        {
            get
            {
                return DairyCowSpecialAbility.specialAbility;
            }
        }

        public static void addDairySpecial()
        {
            SpecialTriggeredAbility id = SpecialTriggeredAbilityManager.Add("extraVoid.inscryption.void_bone_pack", "Fresh Steak", typeof(DairyCowSpecialAbility)).Id;
        }

        public override bool RespondsToDie(bool wasSacrifice, PlayableCard killer)
        {
            return base.PlayableCard.OnBoard;
        }

        public override IEnumerator OnDie(bool wasSacrifice, PlayableCard killer)
        {
            yield return new WaitForSeconds(0.35f);
            yield return Singleton<CardSpawner>.Instance.SpawnCardToHand(CardLoader.GetCardByName("void_Steak"), null, 0.25f, null);
            yield return new WaitForSeconds(0.35f);
            yield break;
        }

        public static SpecialTriggeredAbility specialAbility;
    }
}
