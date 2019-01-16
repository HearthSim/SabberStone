#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
public partial class HSReplay
{
	private Game[] gameField;
	private string buildField;
	private string versionField;
	public Game[] Game
	{
		get
		{
			return gameField;
		}
		set
		{
			gameField = value;
		}
	}
	public string build
	{
		get
		{
			return buildField;
		}
		set
		{
			buildField = value;
		}
	}
	public string version
	{
		get
		{
			return versionField;
		}
		set
		{
			versionField = value;
		}
	}
}
public partial class Game
{
	private object[] itemsField;
	private string idField;
	private string typeField;
	private string tsField;
	public object[] Items
	{
		get
		{
			return itemsField;
		}
		set
		{
			itemsField = value;
		}
	}
	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}
	public string type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}
	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}
public partial class Block
{
	private object[] itemsField;
	private string entityField;
	private string indexField;
	private string targetField;
	private string typeField;
	private string tsField;
	public Block()
	{
		indexField = "-1";
		targetField = "0";
	}
	public object[] Items
	{
		get
		{
			return itemsField;
		}
		set
		{
			itemsField = value;
		}
	}
	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}
	public string index
	{
		get
		{
			return indexField;
		}
		set
		{
			indexField = value;
		}
	}
	public string target
	{
		get
		{
			return targetField;
		}
		set
		{
			targetField = value;
		}
	}
	public string type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}
	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}
public partial class ChangeEntity
{
	private Tag[] tagField;
	private string cardIDField;
	private string entityField;
	private string tsField;
	public Tag[] Tag
	{
		get
		{
			return tagField;
		}
		set
		{
			tagField = value;
		}
	}
	public string cardID
	{
		get
		{
			return cardIDField;
		}
		set
		{
			cardIDField = value;
		}
	}
	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}
	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}
public partial class Tag
{
	private string tagField;
	private string valueField;
	private string tsField;
	public string tag
	{
		get
		{
			return tagField;
		}
		set
		{
			tagField = value;
		}
	}
	public string value
	{
		get
		{
			return valueField;
		}
		set
		{
			valueField = value;
		}
	}
	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}
public partial class Choices
{
	private Choice[] choiceField;

	private string idField;

	private string entityField;

	private string taskListField;

	private string typeField;

	private string minField;

	private string maxField;

	private string sourceField;

	private string tsField;

	public Choice[] Choice
	{
		get
		{
			return choiceField;
		}
		set
		{
			choiceField = value;
		}
	}

	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}

	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}
	public string taskList
	{
		get
		{
			return taskListField;
		}
		set
		{
			taskListField = value;
		}
	}
	public string type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}
	public string min
	{
		get
		{
			return minField;
		}
		set
		{
			minField = value;
		}
	}
	public string max
	{
		get
		{
			return maxField;
		}
		set
		{
			maxField = value;
		}
	}
	public string source
	{
		get
		{
			return sourceField;
		}
		set
		{
			sourceField = value;
		}
	}
	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class Choice
{

	private string entityField;

	private string indexField;

	private string tsField;



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string index
	{
		get
		{
			return indexField;
		}
		set
		{
			indexField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class ChosenEntities
{

	private Choice[] choiceField;

	private string idField;

	private string entityField;

	private string tsField;

	public Choice[] Choice
	{
		get
		{
			return choiceField;
		}
		set
		{
			choiceField = value;
		}
	}



	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class FullEntity
{

	private Tag[] tagField;

	private string cardIDField;

	private string idField;

	private string tsField;

	public Tag[] Tag
	{
		get
		{
			return tagField;
		}
		set
		{
			tagField = value;
		}
	}



	public string cardID
	{
		get
		{
			return cardIDField;
		}
		set
		{
			cardIDField = value;
		}
	}



	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class HideEntity
{

	private string entityField;

	private string zoneField;

	private string tsField;



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string zone
	{
		get
		{
			return zoneField;
		}
		set
		{
			zoneField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class MetaData
{

	private Info[] infoField;

	private string metaField;

	private string dataField;

	private string infoField1;

	private string tsField;

	public MetaData()
	{
		dataField = "0";
	}


	public Info[] Info
	{
		get
		{
			return infoField;
		}
		set
		{
			infoField = value;
		}
	}



	public string meta
	{
		get
		{
			return metaField;
		}
		set
		{
			metaField = value;
		}
	}

	public string data
	{
		get
		{
			return dataField;
		}
		set
		{
			dataField = value;
		}
	}



	public string info
	{
		get
		{
			return infoField1;
		}
		set
		{
			infoField1 = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class Info
{

	private string indexField;

	private string entityField;

	private string tsField;



	public string index
	{
		get
		{
			return indexField;
		}
		set
		{
			indexField = value;
		}
	}



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class SendChoices
{

	private Choice[] choiceField;

	private string idField;

	private string typeField;

	private string tsField;

	public Choice[] Choice
	{
		get
		{
			return choiceField;
		}
		set
		{
			choiceField = value;
		}
	}



	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}



	public string type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class ShowEntity
{

	private Tag[] tagField;

	private string cardIDField;

	private string entityField;

	private string tsField;

	public Tag[] Tag
	{
		get
		{
			return tagField;
		}
		set
		{
			tagField = value;
		}
	}



	public string cardID
	{
		get
		{
			return cardIDField;
		}
		set
		{
			cardIDField = value;
		}
	}



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class TagChange
{

	private string entityField;

	private string tagField;

	private string valueField;

	private string tsField;



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string tag
	{
		get
		{
			return tagField;
		}
		set
		{
			tagField = value;
		}
	}



	public string value
	{
		get
		{
			return valueField;
		}
		set
		{
			valueField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class GameEntity
{

	private Tag[] tagField;

	private string idField;

	private string tsField;

	public Tag[] Tag
	{
		get
		{
			return tagField;
		}
		set
		{
			tagField = value;
		}
	}



	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class Options
{

	private Option[] optionField;

	private string idField;

	private string tsField;


	public Option[] Option
	{
		get
		{
			return optionField;
		}
		set
		{
			optionField = value;
		}
	}



	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class Option
{

	private object[] itemsField;

	private string entityField;

	private string indexField;

	private string typeField;

	private string errorField;

	private string errorParamField;

	private string tsField;

	public object[] Items
	{
		get
		{
			return itemsField;
		}
		set
		{
			itemsField = value;
		}
	}



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string index
	{
		get
		{
			return indexField;
		}
		set
		{
			indexField = value;
		}
	}



	public string type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}



	public string error
	{
		get
		{
			return errorField;
		}
		set
		{
			errorField = value;
		}
	}



	public string errorParam
	{
		get
		{
			return errorParamField;
		}
		set
		{
			errorParamField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class SubOption
{

	private Target[] targetField;

	private string entityField;

	private string indexField;

	private string errorField;

	private string errorParamField;

	private string tsField;


	public Target[] Target
	{
		get
		{
			return targetField;
		}
		set
		{
			targetField = value;
		}
	}



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string index
	{
		get
		{
			return indexField;
		}
		set
		{
			indexField = value;
		}
	}



	public string error
	{
		get
		{
			return errorField;
		}
		set
		{
			errorField = value;
		}
	}



	public string errorParam
	{
		get
		{
			return errorParamField;
		}
		set
		{
			errorParamField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class Target
{

	private string entityField;

	private string indexField;

	private string errorField;

	private string errorParamField;

	private string tsField;



	public string entity
	{
		get
		{
			return entityField;
		}
		set
		{
			entityField = value;
		}
	}



	public string index
	{
		get
		{
			return indexField;
		}
		set
		{
			indexField = value;
		}
	}



	public string error
	{
		get
		{
			return errorField;
		}
		set
		{
			errorField = value;
		}
	}



	public string errorParam
	{
		get
		{
			return errorParamField;
		}
		set
		{
			errorParamField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class Player
{

	private object[] itemsField;

	private string idField;

	private string playerIDField;

	private string nameField;

	private string accountHiField;

	private string accountLoField;

	private string rankField;

	private string legendRankField;

	private string cardbackField;

	private string tsField;

	public Player()
	{
		rankField = "-1";
		legendRankField = "0";
		cardbackField = "0";
	}

	public object[] Items
	{
		get
		{
			return itemsField;
		}
		set
		{
			itemsField = value;
		}
	}



	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}



	public string playerID
	{
		get
		{
			return playerIDField;
		}
		set
		{
			playerIDField = value;
		}
	}

	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
		}
	}



	public string accountHi
	{
		get
		{
			return accountHiField;
		}
		set
		{
			accountHiField = value;
		}
	}



	public string accountLo
	{
		get
		{
			return accountLoField;
		}
		set
		{
			accountLoField = value;
		}
	}


	public string rank
	{
		get
		{
			return rankField;
		}
		set
		{
			rankField = value;
		}
	}


	public string legendRank
	{
		get
		{
			return legendRankField;
		}
		set
		{
			legendRankField = value;
		}
	}



	public string cardback
	{
		get
		{
			return cardbackField;
		}
		set
		{
			cardbackField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}

public partial class Deck
{

	private Card[] cardField;

	private string typeField;

	public Card[] Card
	{
		get
		{
			return cardField;
		}
		set
		{
			cardField = value;
		}
	}



	public string type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}
}


public partial class Card
{

	private string idField;

	private string countField;

	private string premiumField;

	public Card()
	{
		countField = "1";
		premiumField = "0";
	}



	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}



	public string count
	{
		get
		{
			return countField;
		}
		set
		{
			countField = value;
		}
	}


	public string premium
	{
		get
		{
			return premiumField;
		}
		set
		{
			premiumField = value;
		}
	}
}

public partial class SendOption
{

	private string optionField;

	private string subOptionField;

	private string positionField;

	private string targetField;

	private string tsField;

	public SendOption()
	{
		subOptionField = "-1";
		positionField = "0";
	}



	public string option
	{
		get
		{
			return optionField;
		}
		set
		{
			optionField = value;
		}
	}



	public string subOption
	{
		get
		{
			return subOptionField;
		}
		set
		{
			subOptionField = value;
		}
	}



	public string position
	{
		get
		{
			return positionField;
		}
		set
		{
			positionField = value;
		}
	}



	public string target
	{
		get
		{
			return targetField;
		}
		set
		{
			targetField = value;
		}
	}



	public string ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}
