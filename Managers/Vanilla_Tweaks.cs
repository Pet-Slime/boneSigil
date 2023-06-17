using boneSigils.cards;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using InscryptionAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace boneSigils.Managers
{
    public static class Vanilla_Tweaks
    {
        public static void AddCard()
        {
            CardInfo cardInfo = CardManager.BaseGameCards.CardByName("Rattler");
            Ability customAbility = CustomAbility1;
            cardInfo.Abilities.Clear();
            cardInfo.DefaultAbilities.Add(customAbility);
            cardInfo = CardManager.BaseGameCards.CardByName("RatKing");
            cardInfo.SetBonesCost(2);
            cardInfo.SetBloodCost(1);
            cardInfo = CardManager.BaseGameCards.CardByName("Opossum");
            cardInfo.Abilities.Clear();
            cardInfo.Abilities.Add((Ability)28);
            cardInfo = CardManager.BaseGameCards.CardByName("Bat");
            cardInfo.SetBonesCost(3);
            cardInfo = CardManager.BaseGameCards.CardByName("Vulture");
            cardInfo.SetBonesCost(5);
            cardInfo.SetBloodCost(1);
            Plugin.Log.LogMessage("Vanilla config fired 2");
        }


        public static void TryCreatePack()
        {
            CardInfo cardInfo = CardManager.BaseGameCards.CardByName("TrapFrog");
            cardInfo.SetPixelPortrait(SigilUtils.GetTextureFromPath("Artwork/pixelportrait_trap_frog.png").ConvertTexture((TextureHelper.SpriteType)1, 0));
            #pragma warning disable IDE0059 // Unnecessary assignment of a value
            try
            {
                BoneCardPack.CreatePack();
            }
            catch (Exception ex)
            {
                Plugin.Log.LogInfo("Could not create pack. Pack Manager API is not installed");
            }
            #pragma warning restore IDE0059 // Unnecessary assignment of a value
        }

        public static readonly Ability CustomAbility1 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Toxin (Sickening)");

        public static readonly Ability CustomAbility2 = GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Electric");
    }
}
