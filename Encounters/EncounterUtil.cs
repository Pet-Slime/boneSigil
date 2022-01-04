using System;
using System.Collections.Generic;
using BepInEx;
using BepInEx.Logging;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;
using Resources = boneSigils.Artwork.Resources;

namespace boneSigils.Encounters
{
    internal class EncounterUtil
    {
        public static List<List<EncounterBlueprintData.CardBlueprint>> BuildEncounter(
            string turn1_1 = "none", string turn1_2 = "none",
            string turn2_1 = "none", string turn2_2 = "none",
            string turn3_1 = "none", string turn3_2 = "none",
            string turn4_1 = "none", string turn4_2 = "none",
            string turn5_1 = "none", string turn5_2 = "none",
            string turn6_1 = "none", string turn6_2 = "none",
            string turn7_1 = "none", string turn7_2 = "none",
            string turn8_1 = "none", string turn8_2 = "none",
            string turn9_1 = "none", string turn9_2 = "none")
        {

            List<EncounterBlueprintData.CardBlueprint> turn_1 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn1_1 != "none")
            {
                turn_1.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn1_1) });
            }
            if (turn1_2 != "none")
            {
                turn_1.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn1_2) });
            }

            List<EncounterBlueprintData.CardBlueprint> turn_2 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn2_1 != "none")
            {
                turn_2.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn2_1) });
            }
            if (turn2_2 != "none")
            {
                turn_2.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn2_2) });
            }

            List<EncounterBlueprintData.CardBlueprint> turn_3 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn3_1 != "none")
            {
                turn_3.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn3_1) });
            }
            if (turn3_2 != "none")
            {
                turn_3.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn3_2) });
            }

            List<EncounterBlueprintData.CardBlueprint> turn_4 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn4_1 != "none")
            {
                turn_4.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn4_1) });
            }
            if (turn4_2 != "none")
            {
                turn_4.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn4_2) });
            }

            List<EncounterBlueprintData.CardBlueprint> turn_5 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn5_1 != "none")
            {
                turn_5.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn5_1) });
            }
            if (turn5_2 != "none")
            {
                turn_5.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn5_2) });
            }

            List<EncounterBlueprintData.CardBlueprint> turn_6 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn6_1 != "none")
            {
                turn_6.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn6_1) });
            }
            if (turn6_2 != "none")
            {
                turn_6.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn6_2) });
            }

            List<EncounterBlueprintData.CardBlueprint> turn_7 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn7_1 != "none")
            {
                turn_7.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn7_1) });
            }
            if (turn7_2 != "none")
            {
                turn_7.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn7_2) });
            }

            List<EncounterBlueprintData.CardBlueprint> turn_8 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn8_1 != "none")
            {
                turn_8.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn8_1) });
            }
            if (turn8_2 != "none")
            {
                turn_8.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn8_2) });
            }

            List<EncounterBlueprintData.CardBlueprint> turn_9 = new List<EncounterBlueprintData.CardBlueprint>();
            if (turn9_1 != "none")
            {
                turn_9.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn9_1) });
            }
            if (turn9_2 != "none")
            {
                turn_9.Add(new EncounterBlueprintData.CardBlueprint { card = CardLoader.GetCardByName(turn9_2) });
            }

            List<List<EncounterBlueprintData.CardBlueprint>> turns = new List<List<EncounterBlueprintData.CardBlueprint>>();
            turns.Add(turn_1);
            turns.Add(turn_2);
            turns.Add(turn_3);
            turns.Add(turn_4);
            turns.Add(turn_5);
            turns.Add(turn_6);
            turns.Add(turn_7);
            turns.Add(turn_8);
            turns.Add(turn_9);

            return turns;
        }

        public static List<CardInfo> AddRandomCards(string turn1 = "none", string turn2 = "none", string turn3 = "none", string turn4 = "none", string turn5 = "none", string turn6 = "none", string turn7 = "none", string turn8 = "none", string turn9 = "none")
        {

            List<CardInfo> randomReplacements = new List<CardInfo>();
            if (turn1 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn1));
            } else
            {
                return randomReplacements;
            }
            if (turn2 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn2));
            }
            else
            {
                return randomReplacements;
            }
            if (turn3 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn3));
            }
            else
            {
                return randomReplacements;
            }
            if (turn4 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn4));
            }
            else
            {
                return randomReplacements;
            }
            if (turn5 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn5));
            }
            else
            {
                return randomReplacements;
            }
            if (turn6 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn6));
            }
            else
            {
                return randomReplacements;
            }
            if (turn7 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn7));
            }
            else
            {
                return randomReplacements;
            }
            if (turn8 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn8));
            }
            else
            {
                return randomReplacements;
            }
            if (turn9 != "none")
            {
                randomReplacements.Add(CardLoader.GetCardByName(turn9));
            }
            else
            {
                return randomReplacements;
            }
            return randomReplacements;
        }
    }
}
