using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils.cards
{
	public static class Vanilla_Tweaks
	{
		public static void AddCard()
		{
			var cards = ScriptableObjectLoader<CardInfo>.AllData;

			for (int index = 0; index < cards.Count; index++)
			{
				CardInfo info = cards[index];
				if (info.name == "Rattler")
				{
					info.bonesCost = 5;
				}
				if (info.name == "RatKing")
				{
					info.bonesCost = 2;
					info.cost = 1;
				}
				if (info.name == "Opossum")
				{
					info.bonesCost = 1;
					info.abilities.Add(Ability.BoneDigger);
				}
				if (info.name == "Coyote")
				{
					info.bonesCost = 3;
				}
				if (info.name == "Bat")
				{
					info.bonesCost = 3;
				}
				if (info.name == "Vulture")
				{
					info.bonesCost = 5;
					info.cost = 1;
				}
			}
		}
	}
}
