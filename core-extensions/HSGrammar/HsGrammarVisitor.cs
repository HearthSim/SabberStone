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
using HSGrammar.Model;
using System;
using System.Collections.Generic;

namespace HSGrammar
{
    public class HsGrammarVisitor : HSGrammarBaseVisitor<object>
    {
        public List<string> entityNames = new List<string>();

        public override object VisitCompileUnit(HSGrammarParser.CompileUnitContext context)
        {
            PowerGame PowerGame = new PowerGame();

            foreach (HSGrammarParser.HsPowerLineContext hsPowerLine in context.hsPowerLine())
            {
                PowerGame.Entries.Enqueue(VisitHsPowerLine(hsPowerLine) as PowerLogEntry);
            }

            return PowerGame;
        }

        public override object VisitHsPowerLine(HSGrammarParser.HsPowerLineContext context)
        {
            if (context.hsCreateGame() != null)
            {
                return VisitHsCreateGame(context.hsCreateGame());
            }
            else if (context.hsFullEntity() != null)
            {
                return VisitHsFullEntity(context.hsFullEntity());
            }
            else if (context.hsTagChange() != null)
            {
                return VisitHsTagChange(context.hsTagChange());
            }
            else if (context.hsShowEntity() != null)
            {
                return VisitHsShowEntity(context.hsShowEntity());
            }
            else if (context.hsHideEntity() != null)
            {
                return VisitHsHideEntity(context.hsHideEntity());
            }
            else if (context.hsBlockStart() != null)
            {
                return VisitHsBlockStart(context.hsBlockStart());
            }
            else if (context.hsBlockEnd() != null)
            {
                return VisitHsBlockEnd(context.hsBlockEnd());
            }
            else if (context.hsMetaData() != null)
            {
                return VisitHsMetaData(context.hsMetaData());
            }
            else if (context.hsEntityChoices() != null)
            {
                return VisitHsEntityChoices(context.hsEntityChoices());
            }
            else if (context.hsSendChoices() != null)
            {
                return VisitHsSendChoices(context.hsSendChoices());
            }
            else if (context.hsOptions() != null)
            {
                return VisitHsOptions(context.hsOptions());
            }
            else if (context.hsSendOptions() != null)
            {
                return VisitHsSendOptions(context.hsSendOptions());
            }
            else
            {
                throw new NotImplementedException($"Implement: {context.GetText()}");
            }
        }

        public override object VisitHsCreateGame(HSGrammarParser.HsCreateGameContext context)
        {
            return new PowerCreateGame() {
                GameEntity = (PowerEntity) VisitHsCreateGameGameEntity(context.hsCreateGameGameEntity()),
                Player1 = (PowerEntity) VisitHsCreateGamePlayer(context.hsCreateGamePlayer()[0]),
                Player2 = (PowerEntity) VisitHsCreateGamePlayer(context.hsCreateGamePlayer()[1])
            };
        }

        public override object VisitHsCreateGameGameEntity(HSGrammarParser.HsCreateGameGameEntityContext context)
        {
            PowerEntity entity = new PowerEntity();
            entity.EntityId = Int32.Parse(VisitHsEntityIdAssign(context.hsEntityIdAssign()).ToString());
            foreach(HSGrammarParser.HsTagValueExprContext hsTagValueExpr in context.hsTagValueExpr())
            {
				string[] tagValueExpr = (string[]) VisitHsTagValueExpr(hsTagValueExpr);
                entity[tagValueExpr[0]] = tagValueExpr[1];
            }
            return entity;
        }

        public override object VisitHsCreateGamePlayer(HSGrammarParser.HsCreateGamePlayerContext context)
        {
            PowerEntity entity = new PowerEntity();
            entity.EntityId = Int32.Parse(VisitHsEntityIdAssign(context.hsEntityIdAssign()).ToString());
            //entity.PlayerId = int.Parse(VisitHsPlayerIdAssign(context.hsPlayerIdAssign()).ToString());
            //entity.GameAccount = VisitHsGameAccIdAssign(context.hsGameAccIdAssign()).ToString();
            foreach (HSGrammarParser.HsTagValueExprContext hsTagValueExpr in context.hsTagValueExpr())
            {
				string[] tagValueExpr = (string[])VisitHsTagValueExpr(hsTagValueExpr);
                entity[tagValueExpr[0]] = tagValueExpr[1];
            }
            return entity;
        }

        public override object VisitHsEntityIdAssign(HSGrammarParser.HsEntityIdAssignContext context)
        {
            if (context.INT() != null)
            {
                return Int32.Parse(context.INT().GetText());
            }
            else if (context.VALUE() != null || context.GameEntTag() != null)
            {
                string name = context.GameEntTag() != null ? context.GameEntTag().GetText() : context.VALUE().GetText();
                if (!entityNames.Contains(name))
                {
                    entityNames.Add(name);
                }
                return entityNames.IndexOf(name);
            }
            else if (context.hsEntityObject() != null)
            {
                return (int) VisitHsEntityObject(context.hsEntityObject());
            }
            else
            {
                throw new NotImplementedException($"Implement: {context.GetText()}");
            }
        }

        public override object VisitHsEntityObject(HSGrammarParser.HsEntityObjectContext context)
        {
            int Id = (int) VisitHsIdAssign(context.hsIdAssign());
            return Id;
        }

        public override object VisitHsPlayerIdAssign(HSGrammarParser.HsPlayerIdAssignContext context)
        {
            return Int32.Parse(context.INT().GetText());
        }

        public override object VisitHsGameAccIdAssign(HSGrammarParser.HsGameAccIdAssignContext context) { return VisitChildren(context); }

        public override object VisitHsFullEntity(HSGrammarParser.HsFullEntityContext context)
        {
            PowerFullEntity powerFullEntity = new PowerFullEntity();
            powerFullEntity.Entity = new PowerEntity();
            powerFullEntity.Entity.EntityId = (int)VisitHsIdAssign(context.hsIdAssign());
            powerFullEntity.Entity["CARDID"] = (string) VisitHsCardIdAssign(context.hsCardIdAssign());
            foreach (HSGrammarParser.HsTagValueExprContext hsTagValueExpr in context.hsTagValueExpr())
            {
				string[] tagValueExpr = (string[])VisitHsTagValueExpr(hsTagValueExpr);
                powerFullEntity.Entity[tagValueExpr[0]] = tagValueExpr[1];
            }
            return powerFullEntity;
        }

        public override object VisitHsIdAssign(HSGrammarParser.HsIdAssignContext context)
        {
            return Int32.Parse(context.INT().GetText());
        }

        public override object VisitHsCardIdAssign(HSGrammarParser.HsCardIdAssignContext context)
        {
            return context.VALUE() != null ? context.VALUE().GetText() : "";
        }

        public override object VisitHsTagChange(HSGrammarParser.HsTagChangeContext context)
        {
            PowerTagChange powerTagChange = new PowerTagChange();
            powerTagChange.Id = (int) VisitHsEntityIdAssign(context.hsEntityIdAssign());
			string[] tagValue = (string[]) VisitHsTagValueExpr(context.hsTagValueExpr());
            powerTagChange.Tag = tagValue[0];
            powerTagChange.Value = tagValue[1];
            return powerTagChange;
        }

        public override object VisitHsBlockStart(HSGrammarParser.HsBlockStartContext context)
        {
            PowerBlockStart powerBlockStart = new PowerBlockStart();
            powerBlockStart.BlockType = (string) VisitHsBlockTypeAssign(context.hsBlockTypeAssign());
            powerBlockStart.Entity = new PowerEntity();
            powerBlockStart.Entity.EntityId = (int)VisitHsEntityIdAssign(context.hsEntityIdAssign());
            powerBlockStart.EffectIndex = (int)VisitHsEffectIndexAssign(context.hsEffectIndexAssign());
            powerBlockStart.Target = new PowerEntity();
            powerBlockStart.Target.EntityId = (int)VisitHsTargetAssign(context.hsTargetAssign());
            return powerBlockStart;
        }

        public override object VisitHsBlockTypeAssign(HSGrammarParser.HsBlockTypeAssignContext context)
        {
            return context.VALUE().GetText();
        }

        public override object VisitHsEffectCardIdAssign(HSGrammarParser.HsEffectCardIdAssignContext context)
        {
            return VisitChildren(context);
        }

        public override object VisitHsEffectIndexAssign(HSGrammarParser.HsEffectIndexAssignContext context)
        {
            return Int32.Parse(context.INT().GetText());
        }

        public override object VisitHsTargetAssign(HSGrammarParser.HsTargetAssignContext context)
        {
            if (context.INT() != null)
            {
                return Int32.Parse(context.INT().GetText());
            }
            else if (context.hsEntityObject() != null)
            {
                return (int)VisitHsEntityObject(context.hsEntityObject());
            }
            else
            {
                throw new NotImplementedException($"Implement: {context.GetText()}");
            }
        }

        public override object VisitHsBlockEnd(HSGrammarParser.HsBlockEndContext context)
        {
            return new PowerBlockEnd();
        }

        public override object VisitHsShowEntity(HSGrammarParser.HsShowEntityContext context)
        {
            PowerShowEntity powerShowEntity = new PowerShowEntity();
            powerShowEntity.Entity = new PowerEntity();
            powerShowEntity.Entity.EntityId = (int)VisitHsEntityIdAssign(context.hsEntityIdAssign());
            powerShowEntity.Entity["CARDID"] = (string)VisitHsCardIdAssign(context.hsCardIdAssign());
            foreach (HSGrammarParser.HsTagValueExprContext hsTagValueExpr in context.hsTagValueExpr())
            {
				string[] tagValueExpr = (string[])VisitHsTagValueExpr(hsTagValueExpr);
                powerShowEntity.Entity[tagValueExpr[0]] = tagValueExpr[1];
            }
            return powerShowEntity;
        }

        public override object VisitHsHideEntity(HSGrammarParser.HsHideEntityContext context)
        {
            PowerHideEntity powerHideEntity = new PowerHideEntity();
            powerHideEntity.Entity = new PowerEntity();
            powerHideEntity.Entity.EntityId = (int)VisitHsEntityIdAssign(context.hsEntityIdAssign());
            foreach (HSGrammarParser.HsTagValueExprContext hsTagValueExpr in context.hsTagValueExpr())
            {
				string[] tagValueExpr = (string[])VisitHsTagValueExpr(hsTagValueExpr);
                powerHideEntity.Entity[tagValueExpr[0]] = tagValueExpr[1];
            }
            return powerHideEntity;
        }

        public override object VisitHsMetaData(HSGrammarParser.HsMetaDataContext context)
        {
            PowerMetaData powerMetaData = new PowerMetaData();
            powerMetaData.Meta = context.VALUE().GetText();
            powerMetaData.Data = Int32.Parse(context.INT()[0].GetText());
            powerMetaData.Info = Int32.Parse(context.INT()[1].GetText());
            return powerMetaData;
        }

        public override object VisitHsMetaDataInfo(HSGrammarParser.HsMetaDataInfoContext context) { return VisitChildren(context); }

        public override object VisitHsEntityChoices(HSGrammarParser.HsEntityChoicesContext context)
        {
            PowerEntityChoices powerEntityChoices = new PowerEntityChoices();
            powerEntityChoices.Id = (int) VisitHsIdAssign(context.hsIdAssign());
            powerEntityChoices.Player = context.VALUE()[0].GetText();
            powerEntityChoices.ChoiceType = context.VALUE()[1].GetText();
            foreach (HSGrammarParser.HsEntityChoicesEntitiesContext hsEntityChoicesEntities in context.hsEntityChoicesEntities())
            {
                PowerEntity entity = new PowerEntity();
                entity.EntityId = (int)VisitHsEntityChoicesEntities(hsEntityChoicesEntities);
                powerEntityChoices.Entities.Add(entity);
            }
            return powerEntityChoices;
        }

        public override object VisitHsEntityChoicesEntities(HSGrammarParser.HsEntityChoicesEntitiesContext context)
        {
            return VisitHsEntityObject(context.hsEntityObject());
        }

        public override object VisitHsSendChoices(HSGrammarParser.HsSendChoicesContext context)
        {
            PowerSendChoices powerSendChoices = new PowerSendChoices();
            powerSendChoices.Id = (int)VisitHsIdAssign(context.hsIdAssign());
            powerSendChoices.ChoiceType = context.VALUE().GetText();
            foreach (HSGrammarParser.HsSendChoicesEntitiesContext hsSendChoicesEntities in context.hsSendChoicesEntities())
            {
                PowerEntity entity = new PowerEntity();
                entity.EntityId = (int)VisitHsSendChoicesEntities(hsSendChoicesEntities);
                powerSendChoices.Entities.Add(entity);
            }
            return powerSendChoices;
        }

        public override object VisitHsSendChoicesEntities(HSGrammarParser.HsSendChoicesEntitiesContext context)
        {
            return VisitHsEntityObject(context.hsEntityObject());
        }

        public override object VisitHsOptions(HSGrammarParser.HsOptionsContext context)
        {
            PowerOptions powerOptions = new PowerOptions();
            powerOptions.Id = (int)VisitHsIdAssign(context.hsIdAssign());
            foreach (HSGrammarParser.HsOptionContext option in context.hsOption())
            {
                powerOptions.Options.Add((PowerOption) VisitHsOption(option));
            }

            return powerOptions;
        }

        public override object VisitHsOption(HSGrammarParser.HsOptionContext context)
        {
            PowerOption powerOption = new PowerOption();
            powerOption.Id = Int32.Parse(context.INT().GetText());
            powerOption.Type = context.VALUE().GetText();
            if (context.hsEntityObject() != null) {
                powerOption.Entitiy = new PowerEntity();
                powerOption.Entitiy.EntityId = (int)VisitHsEntityObject(context.hsEntityObject());
            }
            foreach (HSGrammarParser.HsSubOptionContext subOption in context.hsSubOption())
            {
                powerOption.SubOptions.Add((PowerSubOption)VisitHsSubOption(subOption));
            }
            foreach (HSGrammarParser.HsTargetContext target in context.hsTarget())
            {
                powerOption.Targets.Add((PowerTarget)VisitHsTarget(target));
            }

            return powerOption;
        }

        public override object VisitHsSubOption(HSGrammarParser.HsSubOptionContext context)
        {
            PowerSubOption powerSubOption = new PowerSubOption();
            powerSubOption.Id = Int32.Parse(context.INT().GetText());
            powerSubOption.Entitiy = new PowerEntity();
            powerSubOption.Entitiy.EntityId = (int)VisitHsEntityObject(context.hsEntityObject());
            foreach (HSGrammarParser.HsTargetContext target in context.hsTarget())
            {
                powerSubOption.Targets.Add((PowerTarget)VisitHsTarget(target));
            }
            return powerSubOption;
        }

        public override object VisitHsTarget(HSGrammarParser.HsTargetContext context)
        {
            PowerTarget poweTarget = new PowerTarget();
            poweTarget.Id = Int32.Parse(context.INT().GetText());
            poweTarget.Entitiy = new PowerEntity();
            poweTarget.Entitiy.EntityId = (int)VisitHsEntityObject(context.hsEntityObject());
            return poweTarget;
        }

        public override object VisitHsSendOptions(HSGrammarParser.HsSendOptionsContext context)
        {
            PowerSendOptions powerSendOptions = new PowerSendOptions();
            powerSendOptions.SelectedOption = Int32.Parse(context.INT()[0].GetText());
            powerSendOptions.SelectedSubOption = Int32.Parse(context.INT()[1].GetText());
            powerSendOptions.SelectedTarget = Int32.Parse(context.INT()[2].GetText());
            powerSendOptions.SelectedPosition = Int32.Parse(context.INT()[3].GetText());
            return powerSendOptions;
        }

        public override object VisitHsTagValueExpr(HSGrammarParser.HsTagValueExprContext context)
        {
            return new string[] { (string)VisitHsTagExpr(context.hsTagExpr()) , (string)VisitHsValueExpr(context.hsValueExpr()) };
        }

        public override object VisitHsTagExpr(HSGrammarParser.HsTagExprContext context)
        {
            return context.INT() != null ? context.INT().GetText() : context.VALUE().GetText();
        }

        public override object VisitHsValueExpr(HSGrammarParser.HsValueExprContext context)
        {
            return context.INT() != null ? context.INT().GetText() : context.VALUE().GetText();
        }

    }
}
