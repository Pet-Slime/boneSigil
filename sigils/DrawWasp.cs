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
			const string rulebookDescription = "[creature] create a wasp swarm in your hand when played";
			const string LearnDialogue = "Where there is one, there is many."; 

            Texture2D tex_a1 = SigilUtils.LoadTextureFromResource(Resources.ability_drawwasp);
			Texture2D tex_a2 = SigilUtils.LoadTextureFromResource(Resources.ability_drawwasp);
			int powerlevel = -3;
			bool LeshyUsable = false;
			bool part1Shops = true;
			bool canStack = false;

			// set ability to behaviour class
			ability_drawwasp.ability = SigilUtils.CreateAbilityWithDefaultSettingsKCM(rulebookName, rulebookDescription, typeof(ability_drawwasp), tex_a1, tex_a2, LearnDialogue,
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
				CardInfo cardByName = CardLoader.GetCardByName("void_Wasp_Swarm");
				cardByName.Mods.AddRange(base.Card.TemporaryMods);
				return cardByName;
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