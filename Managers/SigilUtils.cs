using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;
using DiskCardGame;
using InscryptionAPI.Card;
using UnityEngine;
using static System.IO.File;

namespace boneSigils.Managers
{
    public class SigilUtils
    {
        public static AbilityInfo CreateAbilityWithDefaultSettings(string rulebookName, string rulebookDescription, Type behavior, Texture2D text_a1, Texture2D text_a2, string LearnDialogue, bool withDialogue = false, int powerLevel = 0, bool leshyUsable = false, bool part1Modular = true, bool stack = false)
        {
            AbilityInfo abilityInfo = AbilityManager.New("extraVoid.inscryption.void_bone_pack", rulebookName, rulebookDescription, behavior, text_a1).SetPixelAbilityIcon(text_a2, null);
            if (withDialogue)
            {
                abilityInfo.abilityLearnedDialogue = SetAbilityInfoDialogue(LearnDialogue);
            }
            abilityInfo.powerLevel = powerLevel;
            abilityInfo.opponentUsable = leshyUsable;
            if (part1Modular)
            {
                abilityInfo.metaCategories = new List<AbilityMetaCategory>
                {
                    AbilityMetaCategory.Part1Modular,
                    0
                };
            }
            else
            {
                abilityInfo.metaCategories = new List<AbilityMetaCategory>
                {
                    0
                };
            }
            abilityInfo.canStack = stack;
            return abilityInfo;
        }


        public static CardInfo CreateCardWithDefaultSettings(string InternalName, string DisplayName, int attack, int health, Texture2D texture_base, Texture2D texture_emission, List<CardMetaCategory> cardMetaCategories, List<Tribe> tribes, List<Trait> traits, List<Ability> abilities, Texture2D texture_pixel = null, int bloodCost = 0, int boneCost = 0, int energyCost = 0)
        {
            CardInfo cardInfo = CardManager.New("void", InternalName, DisplayName, attack, health, "A puddle that errods all that touches it.");
            cardInfo.SetPortrait(texture_base, texture_emission, null);
            bool flag = texture_pixel == null;
            if (flag)
            {
                texture_pixel = GetTextureFromPath("Artwork/pixelportrait_blank.png");
                cardInfo.SetPixelPortrait(texture_pixel, null);
            }
            else
            {
                cardInfo.SetPixelPortrait(texture_pixel, null);
            }
            cardInfo.SetPixelPortrait(texture_pixel, null);
            cardInfo.metaCategories = cardMetaCategories;
            cardInfo.tribes = tribes;
            cardInfo.traits = traits;
            for (int i = 0; i < abilities.Count; i++)
            {
                cardInfo.AddAbilities(new Ability[]
                {
                    abilities[i]
                });
            }
            cardInfo.temple = 0;
            cardInfo.cardComplexity = (CardComplexity)2;
            cardInfo.SetBloodCost(bloodCost);
            cardInfo.SetBonesCost(boneCost);
            cardInfo.SetEnergyCost(energyCost);
            return cardInfo;
        }

        // Token: 0x06000008 RID: 8 RVA: 0x00002458 File Offset: 0x00000658
        public static DialogueEvent.LineSet SetAbilityInfoDialogue(string dialogue)
        {
            return new DialogueEvent.LineSet(new List<DialogueEvent.Line>
            {
                new DialogueEvent.Line
                {
                    text = dialogue
                }
            });
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00002488 File Offset: 0x00000688
        public static Texture2D GetTextureFromPath(string path)
        {
            byte[] array = ReadAllBytes(Path.Combine(Plugin.Directory, path));
            Texture2D texture2D = new Texture2D(2, 2);
            texture2D.LoadImage(array);
            return texture2D;
        }

        // Token: 0x0600000A RID: 10 RVA: 0x000024BC File Offset: 0x000006BC
        public static Texture2D LoadTextureFromResource(byte[] resourceFile)
        {
            Texture2D texture2D = new Texture2D(2, 2);
            texture2D.LoadImage(resourceFile);
            return texture2D;
        }

        // Token: 0x0600000B RID: 11 RVA: 0x000024E0 File Offset: 0x000006E0
        public static string GetFullPathOfFile(string fileToLookFor)
        {
            return Directory.GetFiles(Paths.PluginPath, fileToLookFor, SearchOption.AllDirectories)[0];
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002500 File Offset: 0x00000700
        public static byte[] ReadArtworkFileAsBytes(string nameOfCardArt)
        {
            return ReadAllBytes(GetFullPathOfFile(nameOfCardArt));
        }

        // Token: 0x0600000D RID: 13 RVA: 0x00002520 File Offset: 0x00000720
        public static Texture2D LoadImageAndGetTexture(string nameOfCardArt)
        {
            Texture2D texture2D = new Texture2D(2, 2);
            byte[] array = ReadArtworkFileAsBytes(nameOfCardArt);
            bool flag = texture2D.LoadImage(array);
            return texture2D;
        }

        // Token: 0x0600000E RID: 14 RVA: 0x0000254C File Offset: 0x0000074C
        public static CardSlot GetSlot(PlayableCard cardToGetSlot)
        {
            bool flag = cardToGetSlot.Slot != null;
            CardSlot result;
            if (flag)
            {
                result = cardToGetSlot.Slot;
            }
            else
            {
                CardSlot component = cardToGetSlot.transform.parent.GetComponent<CardSlot>();
                bool flag2 = component != null;
                if (flag2)
                {
                    result = component;
                }
                else
                {
                    int instanceID = cardToGetSlot.gameObject.GetInstanceID();
                    Plugin.Log.LogInfo("[SplashDamageAbility][GetSlot] Getting slot for " + instanceID.ToString());
                    List<CardSlot> list = new List<CardSlot>();
                    list.AddRange(Singleton<BoardManager>.Instance.GetSlots(false));
                    list.AddRange(Singleton<BoardManager>.Instance.GetSlots(true));
                    for (int i = 0; i < list.Count; i++)
                    {
                        CardSlot cardSlot = list[i];
                        bool flag3 = cardSlot.Index != 2;
                        if (!flag3)
                        {
                            PlayableCard card = cardSlot.Card;
                            bool flag4 = card == null;
                            if (!flag4)
                            {
                                bool flag5 = card.gameObject == cardToGetSlot.gameObject;
                                if (flag5)
                                {
                                    return cardSlot;
                                }
                                int instanceID2 = card.gameObject.GetInstanceID();
                            }
                        }
                    }
                    Plugin.Log.LogInfo("[SplashDamageAbility][GetSlot] Could not find slot for " + instanceID.ToString());
                    result = null;
                }
            }
            return result;
        }
    }
}