using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi");
        }

        public void update(Game game)
        {
            Console.WriteLine("Oyun güncellendi");
        }
    }
}
