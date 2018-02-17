
//			// --------------------------------------- MINION - NEUTRAL
//			// [BRM_028] Emperor Thaurissan - COST:6 [ATK:5/HP:5] 
//			// - Set: fp2, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the end of your turn, reduce the Cost of cards in your hand by (1).
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRM_028", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.CONTROLLER,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsInZone(Zone.PLAY), SelfCondition.IsNotSilenced)
//						.TriggerEffect(GameTag.TURN_START, -1)
//						.SingleTask(new BuffTask(Buffs.Cost(-1), EntityType.HAND))
//						.Build()
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRM_031] Chromaggus - COST:8 [ATK:6/HP:8] 
//			// - Race: dragon, Set: fp2, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Whenever you draw a card, put another copy into your hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRM_031", new List<Power> {
//				new Power
//				{
//					Area = PowerArea.CONTROLLER,
//					Activation = PowerActivation.BOARD_ZONE,
//					OldTrigger = new TriggerBuilder().Create()
//						.EnableConditions(SelfCondition.IsNotDead, SelfCondition.IsNotSilenced)
//						.TriggerEffect(GameTag.LAST_CARD_DRAWN, 0)
//						.SingleTask(ComplexTask.Create(
//							new IncludeTask(EntityType.SOURCE),
//							new FuncPlayablesTask(p =>
//							{
//								Controller controller = p[0].Controller;
//								return new List<IPlayable> { controller.Game.IdEntityDic[controller.LastCardDrawn] };
//							}),
//							new CopyTask(EntityType.STACK, 1),
//							new AddStackTo(EntityType.HAND)))
//						.Build()
//				}
//			});


