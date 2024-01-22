using DiskCardGame;
using HarmonyLib;
using System;
using InscryptionAPI.Card;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace boneSigils.Managers
{
    internal class PointCost
    {
        [HarmonyPatch(typeof(LoadingScreenManager), "LoadGameData")]
        public class LoadingScreenManager_LoadGameData
        {
            public static void Postfix()
            {

                if (Plugin.configPointCostMode.Value) {

                    var cards = ScriptableObjectLoader<CardInfo>.AllData;

                    for (int index = 0; index < cards.Count; index++)
                    {
                        CardInfo card = cards[index];
                        int PowerLevel;
                        int CardCost;
                        int PointCost;
                        String name = card.name;

                        switch (name)
                        {
                            case "void_Angler":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Leaf_Ant":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Bat":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Bear":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Beetle_Bombardier":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Beetle_Carrion":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Beetle_Larva":
                                PowerLevel = card.PowerLevel - 1 + 3;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Beetle_Rhino":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Beetle_Scarab":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Bone_Lord":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Cow_Dairy":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Cow_Mad":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Cow_Wild":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Crab_Coco":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Crab_Fiddler":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Crab_Spider":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Dragon":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;

                            case "void_Egg":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Enchidna":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost"))
                                {
                                    PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4 - 8;
                                    CardCost = Math.Max(PointCost, 0);
                                    card.SetBonesCost(CardCost);
                                }
                                break;
                            case "void_Giraffe":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Shrimp_Mantis":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Mole":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Scared_Mouse":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Crows_Murder":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Owl_Familiar":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Rabbit":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;

                            case "void_Ray_Manta":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Ray_Torpedo":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost"))
                                {
                                    PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4 - 8;
                                    CardCost = Math.Max(PointCost, 0);
                                    card.SetBonesCost(CardCost);
                                }
                                break;

                            case "void_Ruby_Creature":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Salmon":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Jade_Serpent":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Stinkbug":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Tanuki":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Tanuki_Mythical":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Camel":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Crow_Familiar":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Barbet":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Tortoise_Bell":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Tortoise_Bell_Broken":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Tortoise_Long":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Tortoise_Small":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Tortoise_Spiny":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Urchin_Flower":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Urchin_LongSpine":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Urchin_Sea":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Vulture":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Wasp_Swarm":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Wolf":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                            case "void_Wolverine":
                                PowerLevel = card.PowerLevel - 1;
                                PointCost = PowerLevel - (Plugin.configPointCostBonus.Value * -1) - card.BloodCost * 4;
                                CardCost = Math.Max(PointCost, 0);
                                card.SetBonesCost(CardCost);
                                break;
                        }
                    }
                }
            }
        }
    }
}
