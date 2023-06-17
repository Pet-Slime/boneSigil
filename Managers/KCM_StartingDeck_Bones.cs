using System;
using System.Collections.Generic;
using boneSigils.Artwork;
using DiskCardGame;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using UnityEngine;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils.Managers
{
    internal class KCM_StartingDeck_Bones
    {
        public static void AddStartingDeck()
        {
            Texture2D pureBone = SigilUtils.LoadTextureFromResource(Resources.void_KCM_starter_PureBone);


            StarterDeckInfo starterDeckInfo1 = ScriptableObject.CreateInstance<StarterDeckInfo>();
            starterDeckInfo1.title = "Pure Bone";
            starterDeckInfo1.iconSprite = pureBone.ConvertTexture(TextureHelper.SpriteType.StarterDeckIcon);
            starterDeckInfo1.cards = new List<CardInfo>
            {
                CardLoader.GetCardByName("void_Axolotl"),
                CardLoader.GetCardByName("void_Beetle_Larva"),
                CardLoader.GetCardByName("void_Owl_Familiar")
            };
            StarterDeckManager.Add("extraVoid.inscryption.void_bone_pack", starterDeckInfo1, 0);



            Texture2D trappersToys = SigilUtils.LoadTextureFromResource(Resources.void_KCM_starter_TrapperToys);


            StarterDeckInfo starterDeckInfo2 = ScriptableObject.CreateInstance<StarterDeckInfo>();
            starterDeckInfo2.title = "Trapper's Toys";
            starterDeckInfo2.iconSprite = trappersToys.ConvertTexture(TextureHelper.SpriteType.StarterDeckIcon);
            starterDeckInfo2.cards = new List<CardInfo>
            {
                CardLoader.GetCardByName("TrapFrog"),
                CardLoader.GetCardByName("void_Mole"),
                CardLoader.GetCardByName("void_Tortoise_Bell_Broken")
            };
            StarterDeckManager.Add("extraVoid.inscryption.void_bone_pack", starterDeckInfo2, 0);
        }
    }
}
