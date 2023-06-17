using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using System;

namespace boneSigils.Managers
{
    public static class Vanilla_Tweaks
    {
        public static readonly Ability CustomAbility1 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Toxin (Sickening)");
        public static readonly Ability CustomAbility2 = InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Electric");
        public static void AddCard()
        {

            CardInfo card = CardManager.BaseGameCards.CardByName("Rattler");
            Ability newAbility = CustomAbility1;
            card.Abilities.Clear();
            card.DefaultAbilities.Add(newAbility);

            card = CardManager.BaseGameCards.CardByName("RatKing");
            card.SetBonesCost(2);
            card.SetBloodCost(1);

            card = CardManager.BaseGameCards.CardByName("Opossum");
            card.Abilities.Clear();
            card.Abilities.Add(Ability.BoneDigger);

            card = CardManager.BaseGameCards.CardByName("Bat");
            card.SetBonesCost(2);

            card = CardManager.BaseGameCards.CardByName("Vulture");
            card.SetBonesCost(5);
            card.SetBloodCost(1);



            Plugin.Log.LogMessage("Vanilla config fired 2");

        }

        public static void TryCreatePack()
        {


            CardInfo card = CardManager.BaseGameCards.CardByName("TrapFrog");
            card.SetPixelPortrait(SigilUtils.GetTextureFromPath("Artwork/pixelportrait_trap_frog.png").ConvertTexture(TextureHelper.SpriteType.PixelPortrait));

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            try
            {
                CreateCardPack.CreatePack();
            }
            catch (Exception ex)
            {
                Plugin.Log.LogInfo("Could not create pack. Pack Manager API is not installed");
            }
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }
    }
}
