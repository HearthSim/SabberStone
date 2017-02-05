<img align="left" src="/Readme/sabberstone.png">
# SabberStone

SabberStone is just another Hearthstone simulator and implementation, written in C#. The project was started in Nov'16 while trying to implement aura, buffs & triggers into Brimstone. Focused to prototype my so called onion system I created SabberStone, which is using a layer approach to handle entity changing enchantments. Since then I haven't stopped implementing day by day new cards, new tests and new stuff. I created for fun a visualisation and a scoring based tree search a.i. which can be used to play games ([SabberStoneGui](/SabberStoneGui)). If also implemented a few current decks of the "JANUARY 2017, SEASON 34", like the PirateAggroWarrior and the MidrangeJadeShaman.

By now this is a one man show, but there is still a lot of work to do, so any help is appreciated. The base code of ([Brimstone](https://github.com/HearthSim/Brimstone/tree/master/Brimstone)) was a great inspiration for this project. Big thanks to **@Pattux**, **@Patashu** & **@Katy** for helping on hearthstone super science problems ^^ You're welcome!


**State of Implementation: 77% of current Standard Cards!**

### Project Structure ###

* **SabberStoneCore** *(.NET Core)*

  Core simulator engine, all the functions needed for the simulator are in here. Check out the Wiki [Link](https://github.com/HearthSim/SabberStoneCore/wiki) for informations about the core and how to use it.

* **SabberStoneCoreTest** *(.NET Core)*

  UnitTest for the simulator, there is a generated test for each card in the current game.

* **SabberStoneCoreConsole** *(.NET Core)*

  A test project to run simple codeline based games to test outcome.

* **SabberStoneCoreAi** *(.NET Core)*

  A test project to run A.I. simulations with predefinied decks and strategys.

* **SabberStoneGui** *(.NET Framework)*

  A test project that shows off a visual implementation of the SimpleAi project. This is probably where beginners should start looking at. There is a simple GUI which allows different decks to play against each other with different strategys. Check out the Wiki [Link] (https://github.com/HearthSim/SabberStone/wiki/SabberStoneGui) for informations about the use of SimpleUi.
  ![alt tag](/Readme/simpleui.PNG)
  ![alt tag](/Readme/deckcreator.PNG)
  
### Cards Implementation

- [x] Aura, Enchantment & Trigger
- [x] Hero, Hero Power & Weapon
- [x] Battlecry & Deathrattle
- [x] Choose One & Combo
- [x] Spell Power
- [x] Inspire, Joust & Discover
- [x] Jade Golems (Jade Lotus)
- [x] Buffing Hand (Grimy Goons)
- [x] Excess Mana
- [x] Freeze, Stealth & Poisonous
- [x] Potions (Kabal) ex. Kazakus
- [ ] Spell Bender Phase
- [ ] Spell Text Phase (check if not already done)

**Basic & Classic**
* **100% Basic (142 Cards)**
* 69% Classic (245 Cards)

**Adventures**
* 61% Blackrock Mountain (31 Cards)
* 55% One Night in Karazhan (45 Cards)
* 95% The League of Explorers (45 Cards)

**Expensions**
* 63% The Grand Tournament (132 Cards)
* 45% Whispers of the Old Gods (134 Cards)
* 67% Mean Streets of Gadgetzan (132 Cards)

*(Curse of Naxxrams not on focus, because not in Standard.)*

### ToDo List ###

- [x] Move SabberStone to Github
- [x] Start Wiki for SabberStone
- [x] Moved from .NET Framework to .NET Core
- [ ] Fill Wiki for SabberStone

### Requirements

* Windows, OS X or Linux
  tbd

### Installation

**Most important part to have it run right now is that you change the path to your current folder**

ex. C:\Users\admin\Source\Repos\SabberStone\ --> C:\Users\admin\Source\Repos\

```csharp
namespace SabberStoneCore.Loader
{
    internal class CardLoader : ICardLoader
    {
        private static string _path { get; set; }

        public static string Path {
            get
            {
                if (_path == null)
                {
                    _path = @"C:\Users\admin\Source\Repos\"; // <--- CHANGE TO YOUR FOLDER ... WHERE SABBERSTONE IS
                }

                return _path;
            }
        } 
```


### Documentation

* Wiki [Link](https://github.com/HearthSim/SabberStone/wiki)
* SabberStoneCoreAi [Link](https://github.com/HearthSim/SabberStone/tree/master/SabberStoneCoreAi)
* SabberStoneCoreGui [Link](https://github.com/HearthSim/SabberStone/wiki/SabberStoneGui)

### License

[![AGPLv3](https://www.gnu.org/graphics/agplv3-88x31.png)](http://choosealicense.com/licenses/agpl-3.0/)

SabberStone is licensed under the terms of the
[Affero GPLv3](https://www.gnu.org/licenses/agpl-3.0.en.html) or any later version.

### Community
SabberStone is beeing developed by darkfriend77 (darkfriend@swissonline.ch)
* SabberStone on [Reddit](https://redd.it/5p0ar8)
* SabberStone is a [HearthSim](http://hearthsim.info) project.
