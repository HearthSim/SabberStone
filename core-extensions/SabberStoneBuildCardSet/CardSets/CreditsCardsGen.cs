using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Undefined
{
	public class CreditsCardsGen
	{
		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [CRED_40] Ryan Masterson (*) - COST:4 [ATK:7/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Cast copies of Backstab, Cold Blood, and Eviscerate. <i>(targets chosen randomly).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_40", new Power {
				// TODO [CRED_40] Ryan Masterson && Test: Ryan Masterson_CRED_40
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [CRED_47] Dan Emmons (*) - COST:3 [ATK:3/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Design</b> 
			//       a solution 
			//        <i>(wherever it is)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_47", new Power {
				// TODO [CRED_47] Dan Emmons && Test: Dan Emmons_CRED_47
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [CRED_01] Jason Chayes (*) - COST:6 [ATK:7/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Enrage:</b> Just kidding! He never Enrages.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_01", new Power {
				// TODO [CRED_01] Jason Chayes && Test: Jason Chayes_CRED_01
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_02] Eric Dodds (*) - COST:6 [ATK:5/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/2 Pirate and destroy all Ninjas.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_02", new Power {
				// TODO [CRED_02] Eric Dodds && Test: Eric Dodds_CRED_02
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_03] Bob Fitch (*) - COST:3 [ATK:2/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Super Taunt</b> <i>(EVERY character must attack this minion.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_03", new Power {
				// TODO [CRED_03] Bob Fitch && Test: Bob Fitch_CRED_03
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_04] Steven Gabriel (*) - COST:1 [ATK:3/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a frothy beverage.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_04", new Power {
				// TODO [CRED_04] Steven Gabriel && Test: Steven Gabriel_CRED_04
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_05] Kyle Harrison (*) - COST:3 [ATK:5/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>3 for a 5/4? That's a good deal!</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_05", new Power {
				// TODO [CRED_05] Kyle Harrison && Test: Kyle Harrison_CRED_05
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_06] Derek Sakamoto (*) - COST:1 [ATK:3/HP:1] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>The notorious Footclapper.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_06", new Power {
				// TODO [CRED_06] Derek Sakamoto && Test: Derek Sakamoto_CRED_06
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_07] Zwick (*) - COST:2 [ATK:2/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Complain about bacon prices.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_07", new Power {
				// TODO [CRED_07] Zwick && Test: Zwick_CRED_07
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_08] Ben Brode (*) - COST:3 [ATK:4/HP:1] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your volume can't be reduced below maximum.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_08", new Power {
				// TODO [CRED_08] Ben Brode && Test: Ben Brode_CRED_08
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_09] Ben Thompson (*) - COST:6 [ATK:4/HP:7] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw some cards. With a pen.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_09", new Power {
				// TODO [CRED_09] Ben Thompson && Test: Ben Thompson_CRED_09
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_10] Michael Schweitzer (*) - COST:2 [ATK:2/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>C-C-C-COMBO:</b> Destroy a minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_10", new Power {
				// TODO [CRED_10] Michael Schweitzer && Test: Michael Schweitzer_CRED_10
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_11] Jay Baxter (*) - COST:4 [ATK:1/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon FIVE random Inventions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_11", new Power {
				// TODO [CRED_11] Jay Baxter && Test: Jay Baxter_CRED_11
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_12] Rachelle Davis (*) - COST:2 [ATK:1/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw TWO cards. <i>She's not a novice engineer.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_12", new Power {
				// TODO [CRED_12] Rachelle Davis && Test: Rachelle Davis_CRED_12
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_13] Brian Schwab (*) - COST:10 [ATK:10/HP:10] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, give a random minion +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_13", new Power {
				// TODO [CRED_13] Brian Schwab && Test: Brian Schwab_CRED_13
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_14] Yong Woo (*) - COST:5 [ATK:3/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your other minions have +3 Attack and <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_14", new Power {
				// TODO [CRED_14] Yong Woo && Test: Yong Woo_CRED_14
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_15] Andy Brock (*) - COST:1 [ATK:1/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't be <b>Silenced. Divine Shield, Stealth.</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_15", new Power {
				// TODO [CRED_15] Andy Brock && Test: Andy Brock_CRED_15
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_16] Hamilton Chu (*) - COST:7 [ATK:9/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>Was successfully NOT part of the problem! ...most of the time.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_16", new Power {
				// TODO [CRED_16] Hamilton Chu && Test: Hamilton Chu_CRED_16
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_17] Rob Pardo (*) - COST:9 [ATK:9/HP:9] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: You can't start a game without this minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_17", new Power {
				// TODO [CRED_17] Rob Pardo && Test: Rob Pardo_CRED_17
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_18] Becca Abel (*) - COST:2 [ATK:2/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you draw a card, make it Golden.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_18", new Power {
				// TODO [CRED_18] Becca Abel && Test: Becca Abel_CRED_18
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_19] Beomki Hong (*) - COST:4 [ATK:6/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt.</b> Friendly minions can’t be <b>Frozen.</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_19", new Power {
				// TODO [CRED_19] Beomki Hong && Test: Beomki Hong_CRED_19
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_20] Brian Birmingham (*) - COST:3 [ATK:4/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Choose One</b> - Restore a Mech to full Health; or Give a Designer <b>Windfury.</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_20", new Power {
				// TODO [CRED_20] Brian Birmingham && Test: Brian Birmingham_CRED_20
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_21] Bryan Chang (*) - COST:1 [ATK:1/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Foodie:</b> Make all minions edible.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_21", new Power {
				// TODO [CRED_21] Bryan Chang && Test: Bryan Chang_CRED_21
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_22] Cameron Chrisman (*) - COST:3 [ATK:3/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: While this is in your hand, Golden cards cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_22", new Power {
				// TODO [CRED_22] Cameron Chrisman && Test: Cameron Chrisman_CRED_22
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_23] Christopher Yim (*) - COST:4 [ATK:6/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your emotes are now spoken in "Radio Voice."
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_23", new Power {
				// TODO [CRED_23] Christopher Yim && Test: Christopher Yim_CRED_23
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_24] Dean Ayala (*) - COST:7 [ATK:7/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: You can't lose stars while this is in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_24", new Power {
				// TODO [CRED_24] Dean Ayala && Test: Dean Ayala_CRED_24
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_25] Elizabeth Cho (*) - COST:4 [ATK:2/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add Echo of Medivh and Echoing Ooze to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_25", new Power {
				// TODO [CRED_25] Elizabeth Cho && Test: Elizabeth Cho_CRED_25
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_26] Eric Del Priore (*) - COST:3 [ATK:1/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Has <b>Taunt</b> if it's 3 AM.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_26", new Power {
				// TODO [CRED_26] Eric Del Priore && Test: Eric Del Priore_CRED_26
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_27] Henry Ho (*) - COST:3 [ATK:3/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Spectate your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_27", new Power {
				// TODO [CRED_27] Henry Ho && Test: Henry Ho_CRED_27
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_28] He-Rim Woo (*) - COST:4 [ATK:4/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Choose One</b> - Punch an arm; Offer a treat; or Give a big hug.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_28", new Power {
				// TODO [CRED_28] He-Rim Woo && Test: He-Rim Woo_CRED_28
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_29] Jason MacAllister (*) - COST:5 [ATK:6/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>He's a real stand-up guy.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_29", new Power {
				// TODO [CRED_29] Jason MacAllister && Test: Jason MacAllister_CRED_29
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_30] JC Park (*) - COST:7 [ATK:2/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a new platform for Hearthstone.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_30", new Power {
				// TODO [CRED_30] JC Park && Test: JC Park_CRED_30
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_31] Jeremy Cranford (*) - COST:4 [ATK:5/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: When the game starts, this card climbs to the top of the deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_31", new Power {
				// TODO [CRED_31] Jeremy Cranford && Test: Jeremy Cranford_CRED_31
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_32] Jerry Mascho (*) - COST:2 [ATK:3/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 1 damage. If this card is golden, deal 1 damage at the end of your turn instead. THIS IS A HAN SOLO JOKE.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_32", new Power {
				// TODO [CRED_32] Jerry Mascho && Test: Jerry Mascho_CRED_32
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_33] Jomaro Kindred (*) - COST:6 [ATK:7/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> TAKE any cards from your opponent's hand that they don't want.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_33", new Power {
				// TODO [CRED_33] Jomaro Kindred && Test: Jomaro Kindred_CRED_33
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_34] Max Ma (*) - COST:3 [ATK:6/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can only be played on a mobile device.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_34", new Power {
				// TODO [CRED_34] Max Ma && Test: Max Ma_CRED_34
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_35] Max McCall (*) - COST:4 [ATK:9/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your emotes have no cooldown and can't be squelched.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_35", new Power {
				// TODO [CRED_35] Max McCall && Test: Max McCall_CRED_35
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_36] Mike Donais (*) - COST:6 [ATK:4/HP:8] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Replace all minions in the battlefield, in both hands, and in both decks with random minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_36", new Power {
				// TODO [CRED_36] Mike Donais && Test: Mike Donais_CRED_36
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_37] Ricardo Robaina (*) - COST:4 [ATK:3/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon three 1/1 Chinchillas.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_37", new Power {
				// TODO [CRED_37] Ricardo Robaina && Test: Ricardo Robaina_CRED_37
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_38] Robin Fredericksen (*) - COST:4 [ATK:4/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have no other Erics on the battlefield, rename this card to "Eric".
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_38", new Power {
				// TODO [CRED_38] Robin Fredericksen && Test: Robin Fredericksen_CRED_38
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_39] Ryan Chew (*) - COST:2 [ATK:2/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Chews One</b> - Sing karaoke; or Leave on time and tell everyone about it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_39", new Power {
				// TODO [CRED_39] Ryan Chew && Test: Ryan Chew_CRED_39
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_41] Seyil Yoon (*) - COST:5 [ATK:2/HP:9] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add 3 Sprints and a Marathon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_41", new Power {
				// TODO [CRED_41] Seyil Yoon && Test: Seyil Yoon_CRED_41
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_42] Tim Erskine (*) - COST:4 [ATK:3/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever this minion destroys another minion, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_42", new Power {
				// TODO [CRED_42] Tim Erskine && Test: Tim Erskine_CRED_42
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_43] Jon Bankard (*) - COST:5 [ATK:5/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: 50% chance to be 100% right.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_43", new Power {
				// TODO [CRED_43] Jon Bankard && Test: Jon Bankard_CRED_43
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_44] Walter Kong (*) - COST:4 [ATK:3/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage to each of 2 strategic targets.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_44", new Power {
				// TODO [CRED_44] Walter Kong && Test: Walter Kong_CRED_44
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_45] Jonas Laster (*) - COST:6 [ATK:6/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a <b>Silenced</b> minion dies, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_45", new Power {
				// TODO [CRED_45] Jonas Laster && Test: Jonas Laster_CRED_45
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_46] Keith Landes (*) - COST:2 [ATK:2/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, get -2 Health due to hunger.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_46", new Power {
				// TODO [CRED_46] Keith Landes && Test: Keith Landes_CRED_46
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_48] Christian Scharling (*) - COST:6 [ATK:6/HP:6] 
			// - Race: demon, Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Rearrange 
			//        your minions to be 
			//        more effective.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_48", new Power {
				// TODO [CRED_48] Christian Scharling && Test: Christian Scharling_CRED_48
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_49] Kris Zierhut (*) - COST:6 [ATK:7/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Stealth</b>.
			//       <b>Deathrattle</b>: Those 
			//       are… my… boots…
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_49", new Power {
				// TODO [CRED_49] Kris Zierhut && Test: Kris Zierhut_CRED_49
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_50] Brian Farr (*) - COST:11 [ATK:11/HP:11] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> For the rest of the game, your minions can't be <b><b>Silence</b>d</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_50", new Power {
				// TODO [CRED_50] Brian Farr && Test: Brian Farr_CRED_50
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_51] Jerry Cheng (*) - COST:1 [ATK:1/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Inspire</b>: Give a random Engineer +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_51", new Power {
				// TODO [CRED_51] Jerry Cheng && Test: Jerry Cheng_CRED_51
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_52] Alex Chapman (*) - COST:3 [ATK:4/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a sound plays, replace it with 
			//       Jaraxxus' greeting.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_52", new Power {
				// TODO [CRED_52] Alex Chapman && Test: Alex Chapman_CRED_52
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_53] Camille Sanford (*) - COST:7 [ATK:2/HP:14] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all 
			//       Devs in your hand and deck +1 Swag.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_53", new Power {
				// TODO [CRED_53] Camille Sanford && Test: Camille Sanford_CRED_53
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_54] Hadidjah Chamberlin (*) - COST:4 [ATK:1/HP:1] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Stealth</b>.  At the beginning of each turn, create a random effect.  It doesn't actually do anything.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_54", new Power {
				// TODO [CRED_54] Hadidjah Chamberlin && Test: Hadidjah Chamberlin_CRED_54
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_55] Dave Kosak (*) - COST:0 [ATK:12/HP:12] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Costs (1) more for each word of text on this card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_55", new Power {
				// TODO [CRED_55] Dave Kosak && Test: Dave Kosak_CRED_55
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_56] Dustin Escoffery (*) - COST:3 [ATK:2/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Stealth</b>. Your other minions are Mechs.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_56", new Power {
				// TODO [CRED_56] Dustin Escoffery && Test: Dustin Escoffery_CRED_56
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_57] Matt Wyble (*) - COST:7 [ATK:5/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 
			//        Fluffy White Beast.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_57", new Power {
				// TODO [CRED_57] Matt Wyble && Test: Matt Wyble_CRED_57
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_58] Jason Shattuck (*) - COST:2 [ATK:2/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> All cards are 
			//        played automatically.
			//        <i>Please don't 
			//        explode.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_58", new Power {
				// TODO [CRED_58] Jason Shattuck && Test: Jason Shattuck_CRED_58
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_59] Brad Crusco (*) - COST:6 [ATK:4/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> 
			//       a Bagel.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_59", new Power {
				// TODO [CRED_59] Brad Crusco && Test: Brad Crusco_CRED_59
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_60] Michael Altuna (*) - COST:3 [ATK:2/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform 
			//       all enemy minions 
			//       into 1/1 Fish.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_60", new Power {
				// TODO [CRED_60] Michael Altuna && Test: Michael Altuna_CRED_60
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_61] Charlène Le Scanff (*) - COST:3 [ATK:3/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>Breaktime?</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_61", new Power {
				// TODO [CRED_61] Charlène Le Scanff && Test: Charlène Le Scanff_CRED_61
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_62] Martin Brochu (*) - COST:5 [ATK:8/HP:8] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> The AI 
			//        controls your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_62", new Power {
				// TODO [CRED_62] Martin Brochu && Test: Martin Brochu_CRED_62
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_63] Evan Polekoff (*) - COST:6 [ATK:4/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Create a custom spell… in under 48 hours.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_63", new Power {
				// TODO [CRED_63] Evan Polekoff && Test: Evan Polekoff_CRED_63
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_64] Liv Breeden (*) - COST:2 [ATK:2/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b>  Make your 
			//        card back orange.  Actually… make everything orange.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_64", new Power {
				// TODO [CRED_64] Liv Breeden && Test: Liv Breeden_CRED_64
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_65] Matt Place (*) - COST:7 [ATK:7/HP:7] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>Wait, wait! I’m having one of those things… it’s like a headache with pictures… oh right, AN IDEA!</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_65", new Power {
				// TODO [CRED_65] Matt Place && Test: Matt Place_CRED_65
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_66] Jason DeFord (*) - COST:10 [ATK:10/HP:10] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>Ensure a better foundation by blowing up the old one!</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_66", new Power {
				// TODO [CRED_66] Jason DeFord && Test: Jason DeFord_CRED_66
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_67] Michael Skacal (*) - COST:5 [ATK:5/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy 
			//        your weekend. Restore 
			//       all services to Hearthstone.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_67", new Power {
				// TODO [CRED_67] Michael Skacal && Test: Michael Skacal_CRED_67
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_68] Peter Whalen (*) - COST:1 [ATK:1/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Remove a word from a card in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_68", new Power {
				// TODO [CRED_68] Peter Whalen && Test: Peter Whalen_CRED_68
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_69] Chris Belcher (*) - COST:1 [ATK:1/HP:1] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Immune</b> to everything.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_69", new Power {
				// TODO [CRED_69] Chris Belcher && Test: Chris Belcher_CRED_69
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_70] Monique Ory (*) - COST:2 [ATK:1/HP:2] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b>  Knit a cozy +1/+1 sweater for a friendly Beast.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_70", new Power {
				// TODO [CRED_70] Monique Ory && Test: Monique Ory_CRED_70
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_71] Michael Reynaga (*) - COST:3 [ATK:2/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your minions 
			//        attack randomly. 
			//        <b>Deathrattle:</b> Fix all but one.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_71", new Power {
				// TODO [CRED_71] Michael Reynaga && Test: Michael Reynaga_CRED_71
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_72] Steve Shimizu (*) - COST:5 [ATK:5/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Send an email to all friendly minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_72", new Power {
				// TODO [CRED_72] Steve Shimizu && Test: Steve Shimizu_CRED_72
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_73] David Pendergrast (*) - COST:6 [ATK:4/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Cookie, destroy all bugs.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_73", new Power {
				// TODO [CRED_73] David Pendergrast && Test: David Pendergrast_CRED_73
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_74] Drew Korfe (*) - COST:7 [ATK:5/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b>  Summon two 1/1 wolves.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_74", new Power {
				// TODO [CRED_74] Drew Korfe && Test: Drew Korfe_CRED_74
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_75] Steve Walker (*) - COST:7 [ATK:4/HP:4] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If everything 
			//        is on fire, <b>Adapt</b>. If it’s 3AM, <b>Adapt</b> again.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_75", new Power {
				// TODO [CRED_75] Steve Walker && Test: Steve Walker_CRED_75
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_76] Nicholas Kinney (*) - COST:3 [ATK:3/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>I can't believe it's 
			//       not golden!</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_76", new Power {
				// TODO [CRED_76] Nicholas Kinney && Test: Nicholas Kinney_CRED_76
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_77] Lorenzo Minaca (*) - COST:5 [ATK:3/HP:9] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Inspire</b>: Gain <b>Barbarism</b>, then swap this minion's Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_77", new Power {
				// TODO [CRED_77] Lorenzo Minaca && Test: Lorenzo Minaca_CRED_77
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_78] Matthew Grubb (*) - COST:6 [ATK:3/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Fill both 
			//        sides of the board with Carrion Grubs.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_78", new Power {
				// TODO [CRED_78] Matthew Grubb && Test: Matthew Grubb_CRED_78
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_79] Aaron Gutierrez (*) - COST:1 [ATK:2/HP:3] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a preeetty good card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_79", new Power {
				// TODO [CRED_79] Aaron Gutierrez && Test: Aaron Gutierrez_CRED_79
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_80] Derek Dupras (*) - COST:3 [ATK:3/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all friendly minions <b>Donuts</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_80", new Power {
				// TODO [CRED_80] Derek Dupras && Test: Derek Dupras_CRED_80
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_81] Sojin Hwang (*) - COST:3 [ATK:6/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>Ooooo, more pieces for 
			//        my collection!</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_81", new Power {
				// TODO [CRED_81] Sojin Hwang && Test: Sojin Hwang_CRED_81
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_82] Jacob Jarecki (*) - COST:0 [ATK:0/HP:1] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Never Give Up</b>: If your opponent has lethal, they disconnect.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_82", new Power {
				// TODO [CRED_82] Jacob Jarecki && Test: Jacob Jarecki_CRED_82
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_83] Josh Durica (*) - COST:3 [ATK:3/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Implement 
			//       a 'cool new card.' 
			//       Deal 5 damage to 
			//       this minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_83", new Power {
				// TODO [CRED_83] Josh Durica && Test: Josh Durica_CRED_83
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_84] Alex Tsang (*) - COST:6 [ATK:1/HP:14] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your Schedule is <b>Immune</b> to feature creep.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_84", new Power {
				// TODO [CRED_84] Alex Tsang && Test: Alex Tsang_CRED_84
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_85] Pat Nagle (*) - COST:3 [ATK:2/HP:5] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <i>For the last time, yes! 
			//       I love fishing!</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_85", new Power {
				// TODO [CRED_85] Pat Nagle && Test: Pat Nagle_CRED_85
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_86] Neal Kochhar (*) - COST:5 [ATK:5/HP:6] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Help others find your <b>Fireside Gathering</b> <i>(wherever it is).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_86", new Power {
				// TODO [CRED_86] Neal Kochhar && Test: Neal Kochhar_CRED_86
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CRED_87] Terri Wellman (*) - COST:5 [ATK:5/HP:7] 
			// - Set: credits, Rarity: legendary
			// --------------------------------------------------------
			// Text: Adjacent minions 
			//       are <b>Immune</b> to fire spells. <i>This is fine.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CRED_87", new Power {
				// TODO [CRED_87] Terri Wellman && Test: Terri Wellman_CRED_87
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			RogueNonCollect(cards);
			ShamanNonCollect(cards);
			NeutralNonCollect(cards);
		}
	}
}
