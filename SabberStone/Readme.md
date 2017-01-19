# SabberStone Core

Core of the simulator.

## Basic

tbd

### Game Configuration

```sh
new GameConfig
{
		// if not set it will choose randomly
		StartPlayer = 1, 				
							  
		// ... self-explaining
		Player1Name = "FitzVonGerald",
		  
		// ... self-explaining    
		Player1HeroClass = CardClass.MAGE, 
		
		// add a specific Deck to the player 
		DeckPlayer1 = new List<Card>()      
		{
				// add the Card "Mirror Image" to the deck
				Cards.FromName("Mirror Image"), 
		},
		
		// ... self-explaining
		Player2Name = "RehHausZuckFuchs",
		
		// ... self-explaining   
		Player2HeroClass = CardClass.MAGE,	
		
		DeckPlayer2 = new List<Card>()
		{
				// add the Card "Frostbolt" to the deck
				Cards.FromName("Frostbolt"),    
		},
		
		// game rule for decks standard and wild
		GameRule = FormatType.FT_STANDARD,  
		
		// if yes will fill the decks to have at least
		// 30 cards matching the game rule set
		FillDecks = false,	
										
		// if yes will shuffle decks before play					
    Shuffle = false,			
    
    // not implemented right now ...				   		
    DrawPool = false,				
    
    // work in progress, if a game can split during			
    // a player move ex. mad bomber or loot hoarder			
    Splitting = false										
    																		
    
}
```

### Play Game

... create a Game ... 
```sh
var game = new Game(new GameConfig
{
	StartPlayer = 1,
	Player1HeroClass = CardClass.SHAMAN,
	Player2HeroClass = CardClass.SHAMAN,
	FillDecks = true
});
```
... start ...
```sh
	game.StartGame();
```
... play ... random moves ...          
```sh
for(var i = 0; i < turns; i++)
{
	var options = game.Options(game.CurrentPlayer);
        var option = options[rnd.Next(options.Count)];
        game.Process(option);
}
```
... play ... specific moves ...  
```sh
	game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
        game.Process(EndTurnTask.Any(game.CurrentPlayer));
```
### Implement Cards

Choose the approprate set of cards, where the card you want to implement is listed. All current sets are pregenerated under [CardSets](tree/master/SabberStone/CardSets). Let's start with an example, "Greater Arcane Missiles".

This is the pregenerated code:
```sh
// ------------------------------------------- SPELL - MAGE
// [CFM_623] Greater Arcane Missiles - COST:7 
// - Set: gangs, Rarity: epic
// --------------------------------------------------------
// Text: Shoot three missiles at random enemies that deal $3 damage each. *spelldmg
// --------------------------------------------------------
cards.Add("CFM_623", new List<Enchantment> {
	// TODO [CFM_623] Greater Arcane Missiles && Test: Greater Arcane Missiles_CFM_623
	new Enchantment
	{
		Activation = EnchantmentActivation.SPELL,
		SingleTask = null,
	},
});
```
For this spell we will only add a single task, which will enqueue 3 random missiles.
```sh
SingleTask = new EnqueueTask(3, ComplexTask.DamageRandomTargets(3, EntityType.ENEMIES, 1), true)
```
And for the last part we create a test for it, which also is pregenerated.
```sh
// ------------------------------------------- SPELL - MAGE
// [CFM_623] Greater Arcane Missiles - COST:7 
// - Set: gangs, Rarity: epic
// --------------------------------------------------------
// Text: Shoot three missiles at random enemies that deal $3 damage each. *spelldmg
// --------------------------------------------------------
[TestMethod]
public void GreaterArcaneMissiles_CFM_623()
{
	var game = new Game(new GameConfig
	{
		StartPlayer = 1,
		Player1HeroClass = CardClass.MAGE,
		Player2HeroClass = CardClass.MAGE,
		FillDecks = true
	});
	game.StartGame();
	game.Player1.BaseMana = 10;
	game.Player2.BaseMana = 10;
        var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
        game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion1));
        var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
        game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion2));
        game.Process(EndTurnTask.Any(game.CurrentPlayer));
        var totHealth = game.CurrentOpponent.Hero.Health;
        totHealth += ((ICharacter)minion1).Health;
        totHealth += ((ICharacter)minion2).Health;
        Assert.AreEqual(36, totHealth);
        var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greater Arcane Missiles"));
        game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
        totHealth = game.CurrentOpponent.Hero.Health;
        totHealth += ((ICharacter)minion1).IsDead ? 0 : ((ICharacter)minion1).Health;
        totHealth += ((ICharacter)minion2).IsDead ? 0 : ((ICharacter)minion2).Health;
        Assert.AreEqual(27, totHealth);
        var minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
        game.Process(PlayCardTask.Minion(game.CurrentPlayer, (ICharacter)minion3));
        game.Process(EndTurnTask.Any(game.CurrentPlayer));
        game.Process(EndTurnTask.Any(game.CurrentPlayer));
        var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greater Arcane Missiles"));
        game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
        totHealth = game.CurrentOpponent.Hero.Health;
        totHealth += ((ICharacter)minion1).IsDead ? 0 : ((ICharacter)minion1).Health;
        totHealth += ((ICharacter)minion2).IsDead ? 0 : ((ICharacter)minion2).Health;
        // Spellpower check
        Assert.AreEqual(1, game.CurrentPlayer.Hero.SpellPower);
        Assert.AreEqual(15, totHealth);
}
```
## Model

tbd

## Enchantments

## Tasks

## Visualizer
