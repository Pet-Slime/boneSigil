using DiskCardGame;
using InscryptionAPI.Card;

namespace boneSigils.cards
{
	public static class Vanilla_Tweaks
	{
		public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Toxin (Sickening)");
		public static void AddCard()
		{

			CardInfo card = CardManager.BaseGameCards.CardByName("Rattler");
			Ability newAbility = CustomAbility1;
			card.bonesCost = 5;
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

		}
	}
}
