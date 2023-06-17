using System.Collections;
using System.Collections.Generic;
using System.Linq;
using APIPlugin;
using boneSigils.Managers;
using DiskCardGame;
using InscryptionAPI.Card;
using UnityEngine;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils
{
    public class MurderOfCrowsSpecialAbility : SpecialCardBehaviour
    {
        public SpecialTriggeredAbility SpecialAbility
        {
            get
            {
                return MurderOfCrowsSpecialAbility.specialAbility;
            }
        }

        public override bool RespondsToResolveOnBoard()
        {
            return true;
        }

        public override IEnumerator OnResolveOnBoard()
        {
            Singleton<ViewManager>.Instance.SwitchToView((View)4, false, true);
            PlayableCard crows = (PlayableCard)base.Card;
            List<CardSlot> OPCards = Singleton<BoardManager>.Instance.GetSlots(false);
            List<CardSlot> PLCards = Singleton<BoardManager>.Instance.GetSlots(true);
            crows.Anim.StrongNegationEffect();
            crows.Anim.PlaySacrificeParticles();

            IEnumerator KillCard(PlayableCard target, CardSlot slot)
            {
                target.Anim.LightNegationEffect();
                crows.Anim.PlaySacrificeParticles();
                target.Anim.PlaySacrificeParticles();
                yield return new WaitForSeconds(0.2f);
                yield return target.Die(false, target, true);
                yield return new WaitForSeconds(0.3f);
                if (slot.Card == null)
                {
                    PlayableCard murdered = CardSpawner.SpawnPlayableCard(CardLoader.GetCardByName("void_PileOfBones"));
                    yield return Singleton<BoardManager>.Instance.ResolveCardOnBoard(murdered, slot, 0.1f, null, true);
                }
            }

            foreach (CardSlot opCardSlot in OPCards)
            {
                if (opCardSlot.Card != null)
                {
                    PlayableCard target = opCardSlot.Card;
                    CardSlot slot = opCardSlot;

                    if (!target.Info.HasTrait((Trait)16) && slot != crows.Slot && !target.Info.HasTrait((Trait)12) && !target.Info.HasTrait((Trait)13))
                    {
                        yield return KillCard(target, slot);
                    }

                    target = null;
                    slot = null;
                }
            }

            foreach (CardSlot plCardSlot in PLCards)
            {
                if (plCardSlot.Card != null)
                {
                    PlayableCard target = plCardSlot.Card;
                    CardSlot slot = plCardSlot;

                    if (!target.Info.HasTrait((Trait)16) && slot != crows.Slot && !target.Info.HasTrait((Trait)12) && !target.Info.HasTrait((Trait)13))
                    {
                        yield return KillCard(target, slot);
                    }

                    target = null;
                    slot = null;
                }
            }

            yield return new WaitForSeconds(0.2f);
            Singleton<ViewManager>.Instance.Controller.LockState = 0;
            yield break;
        }

        public static SpecialTriggeredAbility specialAbility;
    }
}
