using System.Collections;
using System.Collections.Generic;
using System.Linq;
using APIPlugin;
using DiskCardGame;
using UnityEngine;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils
{
    public class MurderOfCrowsSpecialAbility : SpecialCardBehaviour
    {
        public SpecialTriggeredAbility SpecialAbility => specialAbility;
        public static SpecialTriggeredAbility specialAbility;





        public static void AddMurderAbility()
        {
            StatIconInfo iconInfo = new StatIconInfo();
            iconInfo.rulebookName = "Murder of Crows";
            iconInfo.rulebookDescription = "Turns nearly all cards other than itself into a pile of bones. Leaves Giant, Terrian, Pelts, and Pathatic Sacrifices.";
            iconInfo.iconType = SpecialStatIcon.None;
            iconInfo.iconGraphic = SigilUtils.LoadTextureFromResource(Resources.void_feather);
            iconInfo.metaCategories = new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Modular, AbilityMetaCategory.Part1Rulebook };

            SpecialAbilityIdentifier identifier = SpecialAbilityIdentifier.GetID(Plugin.PluginGuid, "MurderOfCrowsSpecialAbility");

            NewSpecialAbility newSpecialAbility = new NewSpecialAbility(typeof(MurderOfCrowsSpecialAbility), identifier, iconInfo);
            specialAbility = newSpecialAbility.specialTriggeredAbility;
        }

        public override bool RespondsToResolveOnBoard()
        {
            return true;
        }

        public override IEnumerator OnResolveOnBoard()
        {

            PlayableCard crows = (PlayableCard)base.Card;
            var OPCards = Singleton<BoardManager>.Instance.GetSlots(false);
            var PLCards = Singleton<BoardManager>.Instance.GetSlots(true);

            Ability Pathetic = APIPlugin.AbilityIdentifier.GetAbilityIdentifier("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice").id;


            crows.Anim.StrongNegationEffect();
            crows.Anim.PlaySacrificeParticles();

            // Clear Opponant Slots
            foreach (var slot in OPCards.Where(slot => slot && slot.Card))
            {
                PlayableCard target = slot.Card;
                if (!target.Info.HasTrait(Trait.Giant) &&
                    slot != crows.Slot &&
                    !target.Info.HasTrait(Trait.Terrain) &&
                    !target.Info.HasTrait(Trait.Pelt) &&
                    !target.Info.HasAbility(Pathetic))
                {
                    target.Anim.LightNegationEffect();
                    crows.Anim.PlaySacrificeParticles();
                    target.Anim.PlaySacrificeParticles();
                    yield return new WaitForSeconds(0.2f);
                    yield return target.Die(false, target, true);
                    yield return new WaitForSeconds(0.3f);
                    if (slot.Card == null)
                    {
                        PlayableCard murdered = CardSpawner.SpawnPlayableCard(CardLoader.GetCardByName("Void_PileOfBones"));
                        yield return Singleton<BoardManager>.Instance.ResolveCardOnBoard(murdered, slot);
                    }

                }
            }
            // Clear Player Slots
            foreach (var slot in PLCards.Where(slot => slot && slot.Card))
            {
                PlayableCard target = slot.Card;
                if (!target.Info.HasTrait(Trait.Giant) &&
                    slot != crows.Slot &&
                    !target.Info.HasTrait(Trait.Terrain) &&
                    !target.Info.HasTrait(Trait.Pelt) &&
                    !target.Info.HasAbility(Pathetic))
                {
                    target.Anim.LightNegationEffect();
                    crows.Anim.PlaySacrificeParticles();
                    target.Anim.PlaySacrificeParticles();
                    yield return new WaitForSeconds(0.2f);
                    yield return target.Die(false, target, true);
                    yield return new WaitForSeconds(0.3f);
                    if (slot.Card == null)
                    {
                        PlayableCard murdered = CardSpawner.SpawnPlayableCard(CardLoader.GetCardByName("Void_PileOfBones"));
                        yield return Singleton<BoardManager>.Instance.ResolveCardOnBoard(murdered, slot);
                    }
                }
                yield break;
            }
        }
    }
}