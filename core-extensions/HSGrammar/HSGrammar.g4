grammar HSGrammar;

/*
 * Parser Rules
 */

compileUnit
	:	(hsPowerLine)* EOF
	;

hsPowerLine
	:	hsCreateGame
	|	hsFullEntity
	|	hsTagChange
	|	hsBlockStart
	|	hsShowEntity
	|	hsHideEntity
	|	hsBlockEnd
	|	hsMetaData
	|	hsEntityChoices
	|	hsSendChoices
	|	hsSendOptions
	|	hsOptions
	;

// *** CREATE_GAME ***
hsCreateGame
	:	CREATE_GAME hsCreateGameGameEntity 
					hsCreateGamePlayer
					hsCreateGamePlayer
	;
hsCreateGameGameEntity
	:	GameEntTag hsEntityIdAssign hsTagValueExpr+
	;
hsCreateGamePlayer
	:	PlayerIdTag hsEntityIdAssign hsPlayerIdAssign hsGameAccIdAssign hsTagValueExpr+
	;
hsEntityIdAssign // EntityID=1
	:	EntityIdTag EQ (INT|VALUE|GameEntTag|hsEntityObject)
	;
hsEntityObject // [name=UNKNOWN ENTITY [cardType=INVALID] id=28 zone=DECK zonePos=0 cardId= player=1]
	:	LB 'name=' (VALUE+|'UNKNOWN ENTITY' LB 'cardType=INVALID' RB) hsIdAssign 'zone=' VALUE 'zonePos=' INT hsCardIdAssign 'player=' INT RB
	;
hsPlayerIdAssign // PlayerID=1 
	:	PlayerIdTag EQ INT
	;
hsGameAccIdAssign // GameAccountId=[hi=144115198130930503 lo=95364660]
	:	GameAccTag EQ LB 'hi' EQ INT 'lo' EQ INT RB
	;

// *** FULL_ENTITY ***
hsFullEntity
	:	FULL_ENTITY DS 'Creating' hsIdAssign hsCardIdAssign hsTagValueExpr+
	;
hsIdAssign // ID=4
	:	IdTag EQ INT
	;
hsCardIdAssign // CardID=
	:	CardIdTag EQ VALUE?
	;

// *** TAG_CHANGE ***
hsTagChange
	:	TAG_CHANGE hsEntityIdAssign hsTagValueExpr
	;

// *** BLOCK_START ***
hsBlockStart
	:	BLOCK_START hsBlockTypeAssign hsEntityIdAssign hsEffectCardIdAssign hsEffectIndexAssign hsTargetAssign
	;
hsBlockTypeAssign // BlockType=TRIGGER
	:	BlkTypeTag EQ VALUE
	;
hsEffectCardIdAssign // EffectCardId=
	:	FxCardIdTag EQ
	;
hsEffectIndexAssign // EffectIndex=-1
	:	FxIndexTag EQ INT
	;
hsTargetAssign // Target=0
	:	TargetTag EQ (INT|hsEntityObject)
	;

hsBlockEnd
	:	BLOCK_END
	;

// *** SHOW_ENTITY ***
hsShowEntity
	:	SHOW_ENTITY DS 'Updating' hsEntityIdAssign hsCardIdAssign hsTagValueExpr+
	;

// *** HIDE_ENTITY ***
hsHideEntity
	:	HIDE_ENTITY DS hsEntityIdAssign hsTagValueExpr+
	;

// *** META_DATA ***
hsMetaData
	:	META_DATA DS 'Meta=' VALUE 'Data=' INT InfoTag EQ INT hsMetaDataInfo+
	;
hsMetaDataInfo
	:	InfoTag LB INT RB EQ (INT|hsEntityObject)
	;

// *** ENTITY_CHOICES ***
hsEntityChoices // id=1 Player=cro TaskList=4 ChoiceType=MULLIGAN CountMin=0 CountMax=5
	:	hsIdAssign 'Player=' VALUE 'TaskList=' INT 'ChoiceType=' VALUE 'CountMin=' INT 'CountMax=' INT 'Source=' GameEntTag hsEntityChoicesEntities*
	;

hsEntityChoicesEntities // Entities[0]=[name=UNKNOWN ENTITY [cardType=INVALID] id=5 zone=DECK zonePos=0 cardId= player=1]
	:	'Entities[' INT ']=' hsEntityObject
	;

// *** SendChoices ***
hsSendChoices // id=2 ChoiceType=MULLIGAN
	: hsIdAssign 'ChoiceType=' VALUE hsSendChoicesEntities*
	;
hsSendChoicesEntities // m_chosenEntities[0]=[name=Lightning Storm id=47 zone=HAND zonePos=2 cardId=EX1_259 player=2]
	:	'm_chosenEntities[' INT ']=' hsEntityObject
	;

// *** SendOption ***
hsSendOptions // selectedOption=1 selectedSubOption=-1 selectedTarget=0 selectedPosition=0
	:	'selectedOption=' INT 'selectedSubOption=' INT 'selectedTarget=' INT 'selectedPosition=' INT
	;

// *** Options ***
hsOptions // id=1
	:	hsIdAssign hsOption+
	;

hsOption // option 1 type=POWER mainEntity=[name=UNKNOWN ENTITY [cardType=INVALID] id=51 zone=DECK zonePos=0 cardId= player=2]
	:	'option' INT 'type=' VALUE 'mainEntity=' hsEntityObject? ( hsTarget* | hsSubOption* )
	;

hsSubOption // subOption 0 entity=[name=Cat Form id=13 zone=SETASIDE zonePos=0 cardId=EX1_165a player=1]
	:	'subOption' INT 'entity=' hsEntityObject hsTarget*
	;

hsTarget // target 0 entity=[name=Infested Tauren id=24 zone=PLAY zonePos=1 cardId=OG_249 player=1]
	:	'target' INT 'entity=' hsEntityObject
	;

// *** tag & value ***
hsTagValueExpr	:	TagTag EQ hsTagExpr ValueTag EQ hsValueExpr ;
hsTagExpr		:	(INT|VALUE) ;
hsValueExpr		:	(INT|VALUE) ;
/*
 * Lexer Rules
 */

CREATE_GAME	:	'CREATE_GAME' ;
FULL_ENTITY	:	'FULL_ENTITY' ;
BLOCK_START	:	'BLOCK_START' ;
SHOW_ENTITY	:	'SHOW_ENTITY' ;
TAG_CHANGE	:	'TAG_CHANGE' ;
BLOCK_END	:	'BLOCK_END' ;
HIDE_ENTITY	:	'HIDE_ENTITY' ;
META_DATA	:	'META_DATA' ;

// PROTECTED WORDS
GameEntTag	:	'GameEntity' ;
PlayerIdTag	:	'Player' 'ID'? ;
EntityIdTag	:	'Entity' 'ID'? ;
CardIdTag	:	'cardId' | 'CardID' ;
IdTag		:	'ID' | 'id' ;
GameAccTag	:	'GameAccountId' ;
BlkTypeTag	:	'BlockType' ;
FxCardIdTag	:	'EffectCardId' ;
FxIndexTag	:	'EffectIndex' ;
TargetTag	:	'Target' ;
InfoTag		:	'Info' ;
TagTag		:	'tag' ;
ValueTag	:	'value' ;

DS			:	'-'	;
LB	 		:	'[' ;
RB			:	']' ;
EQ			:	'='	;

VALUE		:	[A-Za-z][A-Za-z0-9_'-]+[:!]?
			;

INT			:	DS? [0-9]+
			;

WS			:	[ \r\t\n]+ -> skip
			;