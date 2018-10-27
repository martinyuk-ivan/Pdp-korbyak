using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.GameSaver
{
    public class GameOrdinator
    {
        GameMomento gameMomento;

        public GameOrdinator(GameMomento gameMomento)
        {
            this.gameMomento = gameMomento;
        }

        public GameMomento SaveGame()
        {
            return gameMomento;
        }

        public void LoadGame(GameMomento gameMomento)
        {
            this.gameMomento = gameMomento;
        }
    }
}
