using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerLogInterpreter
{
    enum PowerState
    {
        Start,
        CreateGame,
        CreateGameGameEntity,
        CreateGamePlayer,
        FullEntity,
        TagChange,
        BlockStart,
        BlockEnd,
        HideEntity,
        ShowEntity,
        MetaData,
    }
}
