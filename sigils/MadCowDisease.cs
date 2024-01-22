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
		private void AddMadCowDiseasee()
		{
			// setup ability
			const string rulebookName = "Mad Cow";
			const string rulebookDescription = "[creature] will become Bulvine Bones after two turns.";
			const string LearnDialogue = "We all most go sometime. Some sooner than others.";
			Texture2D tex_a1 = SigilUtils.LoadTextureFromResource(Resources.ability_MadCow_2);
			Texture2D tex_a2 = SigilUtils.LoadTextureFromResource(Resources.ability_pupate_3_a2);
			int powerlevel = -3;
			bool LeshyUsable = false;
			bool part1Shops = false;
			bool canStack = false;

			// set ability to behaviour class
			ability_MadCow.ability = SigilUtils.CreateAbilityWithDefaultSettingsKCM(rulebookName, rulebookDescription, typeof(ability_MadCow), tex_a1, tex_a2, LearnDialogue,
																					true, powerlevel, LeshyUsable, part1Shops, canStack).ability;
		}
	}

	public class ability_MadCow : AbilityBehaviour
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
            int num = 2;
            this.numTurnsInPlay++;
            int num2 = Mathf.Max(1, num - this.numTurnsInPlay); 
            base.Card.RenderInfo.OverrideAbilityIcon(this.Ability, SigilUtils.GetTextureFromPath("Artwork/ability_MadCow_"+num2.ToString()+".png"));
            base.Card.RenderCard();
            if (this.numTurnsInPlay >= num)
            {
                CardInfo evolution = CardLoader.GetCardByName("void_Cow_Skul");
                if (this.EvolveInheritsInfoMods)
                {
                    foreach (CardModificationInfo cardModificationInfo in base.Card.Info.Mods.FindAll((CardModificationInfo x) => !x.nonCopyable))
                    {
                        CardModificationInfo cardModificationInfo2 = (CardModificationInfo)cardModificationInfo.Clone();
                        if (cardModificationInfo2.HasAbility(Ability.Evolve))
                        {
                            cardModificationInfo2.abilities.Remove(Ability.Evolve);
                        }
                        evolution.Mods.Add(cardModificationInfo2);
                    }
                }
                yield return base.PreSuccessfulTriggerSequence();
                yield return base.Card.TransformIntoCard(evolution, new Action(this.RemoveTemporaryModsWithEvolve), null);
                yield return new WaitForSeconds(this.PostTransformWait);
                yield return base.LearnAbility(0.5f);
                evolution = null;
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