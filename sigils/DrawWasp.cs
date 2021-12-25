using System.Collections;
using APIPlugin;
using DiskCardGame;
using UnityEngine;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils
{
	public partial class Plugin
	{
		private NewAbility AddDrawWasp()
		{
			// setup ability
			const string rulebookName = "Draw Wasp";
			const string rulebookDescription = "[creature] draws a wasp swarm when played";
			// const string TextureFile = "Artwork/void_pathetic.png";

			AbilityInfo info = SigilUtils.CreateInfoWithDefaultSettings(rulebookName, rulebookDescription, true, 0);

			Texture2D tex = SigilUtils.LoadTextureFromResource(Resources.ability_drawwasp);

			var abIds = SigilUtils.GetAbilityId(info.rulebookName);
			
			NewAbility newAbility = new NewAbility(info, typeof(ability_drawwasp), tex, abIds);

			// set ability to behaviour class
			ability_drawwasp.ability = newAbility.ability;

			return newAbility;
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
				return CardLoader.GetCardByName("Void_Wasp");
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
			yield return base.LearnAbility(0f);
			yield break;
		}

	}
}