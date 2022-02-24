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
		private NewAbility AddPupate()
		{
			// setup ability
			const string rulebookName = "Pupate";
			const string rulebookDescription = "[creature] will become a random beetle after 3 turns.";
			// const string TextureFile = "Artwork/void_pathetic.png";

			AbilityInfo info = SigilUtils.CreateInfoWithDefaultSettings(rulebookName, rulebookDescription, true, -1);
			info.canStack = false;

			Texture2D tex = SigilUtils.LoadTextureFromResource(Resources.ability_pupate_3);

			var abIds = SigilUtils.GetAbilityId(info.rulebookName);
			
			NewAbility newAbility = new NewAbility(info, typeof(ability_Pupate), tex, abIds);

			// set ability to behaviour class
			ability_Pupate.ability = newAbility.ability;

			return newAbility;
		}
	}

	public class ability_Pupate : AbilityBehaviour
	{
		public override Ability Ability => ability;

		public static Ability ability;

		int count = 3;

		public override bool RespondsToUpkeep(bool playerUpkeep)
		{
			return base.Card.OpponentCard != playerUpkeep;
		}


		public override IEnumerator OnUpkeep(bool playerUpkeep)
		{
			List<string> list = new List<string>
			{
			"Void_Beetle",
			"Void_Beetle_Bombardier",
			"Void_Rino_beetle",
			"Void_Scarab_Jewel"
			};

			if (count == 0)
            {
				string cardName = list[UnityEngine.Random.Range(0, (list.Count))];
				CardInfo cardinfo = CardLoader.GetCardByName(cardName);
				bool evolveInheritsInfoMods = this.EvolveInheritsInfoMods;
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
				yield return TransformIntoCard(cardinfo, new Action(this.RemoveTemporaryModsWithEvolve));
				yield return new WaitForSeconds(this.PostTransformWait);
				yield return base.LearnAbility(0.5f);

			} else
            {

				count--;

				Texture2D tex1 = SigilUtils.LoadTextureFromResource(Resources.ability_pupate_2);

				Texture2D tex2 = SigilUtils.LoadTextureFromResource(Resources.ability_pupate_1);

				if (count == 2) {
					base.Card.RenderInfo.OverrideAbilityIcon(ability_Pupate.ability, tex1);
					base.Card.RenderCard();
				}

				if (count == 1) {
					base.Card.RenderInfo.OverrideAbilityIcon(ability_Pupate.ability, tex2);
					base.Card.RenderCard();
				}	
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