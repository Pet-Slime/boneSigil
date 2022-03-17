using System.Collections;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils
{
    public class DairyCowSpecialAbility : SpecialCardBehaviour
    {
        public SpecialTriggeredAbility SpecialAbility => specialAbility;

        public static SpecialTriggeredAbility specialAbility;

        public static void addDairySpecial()
        {
            SpecialTriggeredAbility DairySpecialAbility = SpecialTriggeredAbilityManager.Add(Plugin.PluginGuid, "Fresh Steak", typeof(DairyCowSpecialAbility)).Id;
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