using DiskCardGame;
using InscryptionAPI.Card;
using System.Collections.Generic;

namespace boneSigils.Managers
{
    public static class Point_Cost_Mode
    {
        public static void AddCard()
        {
            List<CardInfo> AllCards = ScriptableObjectLoader<CardInfo>.AllData;
            for (int i = 0; i < AllCards.Count; i++)
            {
                CardInfo card = AllCards[i];
                string name = card.name;
                int PowerLevel;

                switch (name)
                {
                    case "void_Angler":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Leaf_Ant":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Bat":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Bear":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Beetle_Bombardier":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Beetle_Carrion":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Beetle_Larva":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Beetle_Rhino":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Beetle_Scarab":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Bone_Lord":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Cow_Dairy":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Cow_Mad":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Cow_Wild":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Crab_Coco":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Crab_Fiddler":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Crab_Spider":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Dragon":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;

                    case "void_Egg":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Enchidna":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost"))
                        {
                            card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4 - 8);
                        }
                        break;
                    case "void_Giraffe":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Shrimp_Mantis":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Mole":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Scared_Mouse":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Crows_Murder":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Owl_Familiar":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Rabbit":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;

                    case "void_Ray_Manta":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Ray_Torpedo":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost"))
                        {
                            card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4 - 8);
                        }
                        break;

                    case "void_Ruby_Creature":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Salmon":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Jade_Serpent":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Stinkbug":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Tanuki":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Tanuki_Mythical":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Camel":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Crow_Familiar":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Barbet":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Tortoise_Bell":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Tortoise_Bell_Broken":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Tortoise_Long":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Tortoise_Small":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Tortoise_Spiny":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Urchin_Flower":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Urchin_LongSpine":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Urchin_Sea":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Vulture":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Wasp_Swarm":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Wolf":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                    case "void_Wolverine":
                        PowerLevel = card.PowerLevel - 1;
                        card.SetBonesCost(PowerLevel - Plugin.configPointCostBonus.Value - card.BloodCost * 4);
                        break;
                }
            }
        }
    }
}
