using System.Collections;
using APIPlugin;
using DiskCardGame;
using UnityEngine;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils
{
	public partial class Plugin
	{
		private void AddDrawWasp()
		{
			// setup ability
			const string rulebookName = "Draw Wasp";
			const string rulebookDescription = "[creature] draws a wasp swarm when played";
			const string LearnDialogue = "Where there is one, there is many.";
			Texture2D tex_a1 = SigilUtils.LoadTextureFromResource(Resources.ability_drawwasp);
			Texture2D tex_a2 = SigilUtils.LoadTextureFromResource(Resources.ability_drawwasp);
			int powerlevel = -2;
			bool LeshyUsable = false;
			bool part1Shops = true;
			bool canStack = false;

			// set ability to behaviour class
			ability_drawwasp.ability = SigilUtils.CreateAbilityWithDefaultSettings(rulebookName, rulebookDescription, typeof(ability_drawwasp), tex_a1, tex_a2, LearnDialogue,
																					true, powerlevel, LeshyUsable, part1Shops, canStack).ability;
		}
	}

	public class ability_drawwasp : DrawCreatedCard
	{
		public override Ability Ability => ability;

		public static Ability ability;

		public override CardInfo CardToDraw
		{
			get
			{
				CardInfo result = CardLoader.GetCardByName("Void_Wasp");
				return result;
			}
		}

		public override bool RespondsToResolveOnBoard()
		{
			return true;
		}

		public override IEnumerator OnResolveOnBoard()
		{
			yield return base.PreSuccessfulTriggerSequence();
			yield return base.CreateDrawnCard();
			yield return base.LearnAbility(0.5f);
			yield break;
		}

	}
}