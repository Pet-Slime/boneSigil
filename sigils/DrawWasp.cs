using System.Collections;
using APIPlugin;
using boneSigils.Managers;
using DiskCardGame;
using InscryptionAPI.Card;
using UnityEngine;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils
{
    public partial class Plugin
	{
		private void AddDrawWasp()
		{
            Texture2D text_a = SigilUtils.LoadTextureFromResource(Resources.ability_drawwasp);
            Texture2D text_a2 = SigilUtils.LoadTextureFromResource(Resources.ability_drawwasp);
            int powerLevel = -3;
            bool leshyUsable = false;
            bool part1Modular = true;
            bool stack = false;
            ability_drawwasp.ability = SigilUtils.CreateAbilityWithDefaultSettings("Draw Wasp", "[creature] draws a wasp swarm when played", typeof(ability_drawwasp), text_a, text_a2, "Where there is one, there is many.", true, powerLevel, leshyUsable, part1Modular, stack).ability;


		}
	}

    public class ability_drawwasp : DrawCreatedCard
    {
        public override Ability Ability
        {
            get
            {
                return ability_drawwasp.ability;
            }
        }
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


        public static Ability ability;
    }
}