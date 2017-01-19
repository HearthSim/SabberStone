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
... play ...          
```sh
            for(var i = 0; i < turns; i++)
            {
                var options = game.Options(game.CurrentPlayer);
                var option = options[rnd.Next(options.Count)];
                game.Process(option);
            }
```

### Implement Cards

tbd

## Model

tbd

## Enchantments

## Tasks

## Visualizer
