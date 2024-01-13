using HarmonyLib;
using DiskCardGame;
using InscryptionAPI.Card;
using UnityEngine;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using Resources = boneSigils.Artwork.Resources;


namespace boneSigils.Managers
{
    internal class KCM_StartingDeck_Bones
    {
        public static void AddStartingDeck()
        {


            Texture2D tex_a1 = SigilUtils.LoadTextureFromResource(Resources.void_KCM_starter_PureBone);
            Texture2D tex_a2 = SigilUtils.LoadTextureFromResource(Resources.void_KCM_starter_TrapperToys);
            Texture2D tex_a3 = SigilUtils.LoadTextureFromResource(Resources.void_KCM_starter_Activate);

            StarterDeckInfo PureBone = ScriptableObject.CreateInstance<StarterDeckInfo>();
            PureBone.title = "Pure Bone";
            PureBone.iconSprite = tex_a1.ConvertTexture(TextureHelper.SpriteType.StarterDeckIcon);
            PureBone.cards = new() { CardLoader.GetCardByName("void_Axolotl"), CardLoader.GetCardByName("void_Beetle_Larva"), CardLoader.GetCardByName("void_Owl_Familiar") };

            StarterDeckManager.Add(Plugin.PluginGuid, PureBone);


            StarterDeckInfo TrapperToys = ScriptableObject.CreateInstance<StarterDeckInfo>();
            TrapperToys.title = "Trapper's Toys";
            TrapperToys.iconSprite = tex_a2.ConvertTexture(TextureHelper.SpriteType.StarterDeckIcon);
            TrapperToys.cards = new() { CardLoader.GetCardByName("TrapFrog"), CardLoader.GetCardByName("void_Mole"), CardLoader.GetCardByName("void_Tortoise_Bell_Broken") };

            StarterDeckManager.Add(Plugin.PluginGuid, TrapperToys);

            StarterDeckInfo BoneActivate = ScriptableObject.CreateInstance<StarterDeckInfo>();
            BoneActivate.title = "Activate Bones";
            BoneActivate.iconSprite = tex_a3.ConvertTexture(TextureHelper.SpriteType.StarterDeckIcon);
            BoneActivate.cards = new() { CardLoader.GetCardByName("void_Camel"), CardLoader.GetCardByName("void_Barbet"), CardLoader.GetCardByName("void_Crow_Familiar") };

            StarterDeckManager.Add(Plugin.PluginGuid, BoneActivate);
        }
    }
}
