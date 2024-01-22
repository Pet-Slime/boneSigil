using System.Collections;
using APIPlugin;
using DiskCardGame;
using UnityEngine;
using System;
using System.Collections.Generic;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils
{
	public partial class Plugin
	{
		private void AddPupate()
		{
			// setup ability
			const string rulebookName = "Pupate";
			const string rulebookDescription = "[creature] will become a random beetle after 3 turns.";
			const string LearnDialogue = "What Beetle will it turn into?";
			Texture2D tex_a1 = SigilUtils.LoadTextureFromResource(Resources.ability_pupate_3);
			Texture2D tex_a2 = SigilUtils.LoadTextureFromResource(Resources.ability_pupate_3_a2);
			int powerlevel = -3;
			bool LeshyUsable = false;
			bool part1Shops = false;
			bool canStack = false;

			// set ability to behaviour class
			ability_Pupate.ability = SigilUtils.CreateAbilityWithDefaultSettingsKCM(rulebookName, rulebookDescription, typeof(ability_Pupate), tex_a1, tex_a2, LearnDialogue,
																					true, powerlevel, LeshyUsable, part1Shops, canStack).ability;
		}
	}

	public class ability_Pupate : AbilityBehaviour
	{
		public override Ability Ability => ability;

		public static Ability ability;

        private int numTurnsInPlay;

        public override bool RespondsToUpkeep(bool playerUpkeep)
		{
			return base.Card.OpponentCard != playerUpkeep;
		}


		public override IEnumerator OnUpkeep(bool playerUpkeep)
		{
			List<string> list = new List<string>
			{
			"void_Beetle_Carrion",
            "void_Beetle_Rhino",
            "void_Beetle_Scarab",
			"void_Beetle_Bombardier"
			};

            int num = 3;
            this.numTurnsInPlay++;
            int num2 = Mathf.Max(1, num - this.numTurnsInPlay);
            base.Card.RenderInfo.OverrideAbilityIcon(this.Ability, SigilUtils.GetTextureFromPath("Artwork/ability_pupate_" + num2.ToString() + ".png"));
            base.Card.RenderCard();
            if (this.numTurnsInPlay >= num)
            {
                string cardName = list[UnityEngine.Random.Range(0, (list.Count))];
                CardInfo cardinfo = CardLoader.GetCardByName(cardName);
                if (this.EvolveInheritsInfoMods)
                {
                    foreach (CardModificationInfo cardModificationInfo in base.Card.Info.Mods.FindAll((CardModificationInfo x) => !x.nonCopyable))
                    {
                        CardModificationInfo cardModificationInfo2 = (CardModificationInfo)cardModificationInfo.Clone();
                        if (cardModificationInfo2.HasAbility(Ability.Evolve))
                        {
                            cardModificationInfo2.abilities.Remove(Ability.Evolve);
                        }
                        cardinfo.Mods.Add(cardModificationInfo2);
                    }
                }
                yield return base.PreSuccessfulTriggerSequence();
                yield return base.Card.TransformIntoCard(cardinfo, new Action(this.RemoveTemporaryModsWithEvolve), null);
                yield return new WaitForSeconds(this.PostTransformWait);
                yield return base.LearnAbility(0.5f);
                cardinfo = null;
            }

            yield break;
		}

		protected virtual bool EvolveInheritsInfoMods
		{
			get
			{
				return true;
			}
		}

		private void RemoveTemporaryModsWithEvolve()
		{
			for (CardModificationInfo temporaryEvolveMod = this.GetTemporaryEvolveMod(); temporaryEvolveMod != null; temporaryEvolveMod = this.GetTemporaryEvolveMod())
			{
				base.Card.RemoveTemporaryMod(temporaryEvolveMod, true);
			}
		}

		private CardModificationInfo GetTemporaryEvolveMod()
		{
			return base.Card.TemporaryMods.Find((CardModificationInfo x) => x.abilities.Contains(Ability.Evolve));
		}

		protected virtual float PostTransformWait
		{
			get
			{
				return 0.5f;
			}
		}

		public IEnumerator TransformIntoCard(CardInfo evolvedInfo, Action onTransformedCallback = null, Action preTransformCallback = null)
		{
			Singleton<ViewManager>.Instance.SwitchToView(View.Board, false, false);
			yield return new WaitForSeconds(0.15f);
			base.Card.Anim.PlayTransformAnimation();
			yield return new WaitForSeconds(0.15f);
			if (preTransformCallback != null)
			{
				preTransformCallback();
			}
			base.Card.SetInfo(evolvedInfo);
			if (onTransformedCallback != null)
			{
				onTransformedCallback();
			}
			yield break;
		}
	}
}