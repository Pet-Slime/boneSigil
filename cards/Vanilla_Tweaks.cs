using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using System;

namespace boneSigils.cards
{
	public static class Vanilla_Tweaks
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Toxin (Sickening)");
		public static readonly Ability CustomAbility2 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Electric");
		public static void AddCard()
		{

			CardInfo card = CardManager.BaseGameCards.CardByName("Rattler");
			Ability newAbility = CustomAbility1;
			card.abilities.Clear();
			card.DefaultAbilities.Add(newAbility);

			card = CardManager.BaseGameCards.CardByName("RatKing");
			card.bonesCost = 2;
			card.cost = 1;

			card = CardManager.BaseGameCards.CardByName("Opossum");
			card.abilities.Clear();
			card.abilities.Add(Ability.BoneDigger);

			card = CardManager.BaseGameCards.CardByName("Bat");
			card.bonesCost = 3;

			card = CardManager.BaseGameCards.CardByName("Vulture");
			card.bonesCost = 5;
			card.cost = 1;



			Plugin.Log.LogMessage("Vanilla config fired 2");

		}

		public static void TryCreatePack()
		{


			CardInfo card = CardManager.BaseGameCards.CardByName("TrapFrog");
			card.pixelPortrait = TextureHelper.ConvertTexture(SigilUtils.GetTextureFromPath("Artwork/pixelportrait_trap_frog.png"), TextureHelper.SpriteType.PixelPortrait);

			try
			{
				Vanilla_Tweaks_2.CreatePack();
			}
			catch (Exception ex)
			{
				Plugin.Log.LogInfo("Could not create pack. Pack Manager API is not installed");
			}
		}
	}
}
