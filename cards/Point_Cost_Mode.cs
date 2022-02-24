using DiskCardGame;
using APIPlugin;

namespace boneSigils.cards
{
	public static class Point_Cost_Mode
	{
		public static void AddCard()
		{
			var cards = ScriptableObjectLoader<CardInfo>.AllData;
			CardInfo card;
			int PowerLevel;

			card = cards.Find((CardInfo x) => x.name == "Void_Angler");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);
	
			card = cards.Find((CardInfo x) => x.name == "Void_Leaf_Ant");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);
	
			card = cards.Find((CardInfo x) => x.name == "Void_Bat");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Bear");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Beetle_Bombardier");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Beetle");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "void_beetle_larva");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Rino_beetle");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Scarab_Jewel");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Bone_Lord");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_burrow");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "void_cow_mad");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "void_cow_wild");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Coco_Crab");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Crab_Fiddler");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Crab_Spider");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Dragon");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "void_egg");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);
 
			card = cards.Find((CardInfo x) => x.name == "Void_Enchidna");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost"))
			{
				card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4) - 8;
			}

			card = cards.Find((CardInfo x) => x.name == "void_giraffe");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Mantis_Shrimp");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "void_murder_of_crows");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Owl_Familiar");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Rabbit");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "void_torpedoRay");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("extraVoid.inscryption.LifeCost"))
			{
				card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4) - 8;
			}

			card = cards.Find((CardInfo x) => x.name == "void_ruby_creature");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Salmon");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Jade_Serpent");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Tanuki");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "void_tanuki_mythical");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Tortoise_Bell");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Tortoise_Bell_Broken");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "void_tortoise_long");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_tortoise_small");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_tortoise_spiny");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Vulture");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Wasp");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Wolf");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			Plugin.Log.LogWarning("Wolf Power level is: " + card.PowerLevel);
			PowerLevel = card.PowerLevel - 1;
			Plugin.Log.LogWarning("Wolf bone cost is: " + PowerLevel);
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);

			card = cards.Find((CardInfo x) => x.name == "Void_Wolverine");
			//Subtract 1 from the power level of a card, as every card gets 1 free health, but power level includes it.
			PowerLevel = card.PowerLevel - 1;
			card.bonesCost = PowerLevel - Plugin.configPointCostBonus.Value - (card.BloodCost * 4);
		}
	}
}
