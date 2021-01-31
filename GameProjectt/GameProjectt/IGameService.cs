using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void update(Game game);
    }
}
