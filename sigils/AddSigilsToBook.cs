﻿using System.Collections;
using APIPlugin;
using DiskCardGame;
using UnityEngine;
using System;
using System.Collections.Generic;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils
{
	public partial class Plugin
	{
		private static void AddSigilsToBook()
		{
			//This is to make bone digger show up in act 1
			var ability = ScriptableObjectLoader<AbilityInfo>.AllData;

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index];
				if (info.ability == Ability.BoneDigger)
				{
					info.powerLevel = -1;
				}
			}
		}
	}
}