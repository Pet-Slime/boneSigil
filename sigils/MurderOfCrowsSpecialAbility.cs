using System.Collections;
using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace boneSigils
{
    public class MurderOfCrowsSpecialAbility : SpecialCardBehaviour
	{
		public SpecialTriggeredAbility SpecialAbility => specialAbility;

		public static SpecialTriggeredAbility specialAbility;

		public readonly static SpecialTriggeredAbility TestSpecialAbility = SpecialTriggeredAbilityManager.Add(Plugin.PluginGuid, "Crow Murder", typeof(MurderOfCrowsSpecialAbility)).Id;



		public override bool RespondsToResolveOnBoard()
        {
            return true;
        }

        public override IEnumerator OnResolveOnBoard()
        {

			Singleton<ViewManager>.Instance.SwitchToView(View.Board, false, true);
			PlayableCard crows = (PlayableCard)base.Card;
			List<CardSlot> OPCards = Singleton<BoardManager>.Instance.GetSlots(false);
			List<CardSlot> PLCards = Singleton<BoardManager>.Instance.GetSlots(true);
			crows.Anim.StrongNegationEffect();
			crows.Anim.PlaySacrificeParticles();
			int num;
			for (int i = 0; i < OPCards.Count; i = num + 1)
			{
				bool flag = OPCards[i].Card != null;
				if (flag)
				{
					PlayableCard target = OPCards[i].Card;
					CardSlot slot = OPCards[i];
					bool flag2 = !target.Info.HasTrait(Trait.Giant) && slot != crows.Slot && !target.Info.HasTrait(Trait.Terrain) && !target.Info.HasTrait(Trait.Pelt);
					if (flag2)
					{
						target.Anim.LightNegationEffect();
						crows.Anim.PlaySacrificeParticles();
						target.Anim.PlaySacrificeParticles();
						yield return new WaitForSeconds(0.2f);
						yield return target.Die(false, target, true);
						yield return new WaitForSeconds(0.3f);
						bool flag3 = slot.Card == null;
						if (flag3)
						{
							PlayableCard murdered = CardSpawner.SpawnPlayableCard(CardLoader.GetCardByName("Void_PileOfBones"));
							yield return Singleton<BoardManager>.Instance.ResolveCardOnBoard(murdered, slot, 0.1f, null, true);
							murdered = null;
						}
					}
					target = null;
					slot = null;
				}
				num = i;
			}
			for (int j = 0; j < PLCards.Count; j = num + 1)
			{
				bool flag4 = PLCards[j].Card != null;
				if (flag4)
				{
					PlayableCard target2 = PLCards[j].Card;
					CardSlot slot2 = PLCards[j];
					bool flag5 = !target2.Info.HasTrait(Trait.Giant) && slot2 != crows.Slot && !target2.Info.HasTrait(Trait.Terrain) && !target2.Info.HasTrait(Trait.Pelt);
					if (flag5)
					{
						target2.Anim.LightNegationEffect();
						crows.Anim.PlaySacrificeParticles();
						target2.Anim.PlaySacrificeParticles();
						yield return new WaitForSeconds(0.2f);
						yield return target2.Die(false, target2, true);
						yield return new WaitForSeconds(0.3f);
						bool flag6 = slot2.Card == null;
						if (flag6)
						{
							PlayableCard murdered2 = CardSpawner.SpawnPlayableCard(CardLoader.GetCardByName("Void_PileOfBones"));
							yield return Singleton<BoardManager>.Instance.ResolveCardOnBoard(murdered2, slot2, 0.1f, null, true);
							murdered2 = null;
						}
					}
					target2 = null;
					slot2 = null;
				}
				num = j;
			}
			yield return new WaitForSeconds(0.2f);
			Singleton<ViewManager>.Instance.Controller.LockState = ViewLockState.Unlocked;
			yield break;
		}
    }
}