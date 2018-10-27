using Patterns.RaceGame.CarModels;
using Patterns.RaceGame.RoadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.GameSaver
{
    public class GameHistory
    {
        private Stack<GameMomento> gameHistory;
        private GameOrdinator gameOrdinator;

        public GameHistory(BaseCar myCar, Road currentRoad)
        {
            this.gameHistory = new Stack<GameMomento>();
            this.gameOrdinator = new GameOrdinator(new GameMomento(myCar, currentRoad));
        }

        public void SaveGameToHistory()
        {
            this.gameHistory.Push(gameOrdinator.SaveGame());
        }

        public void LoadLastGame()
        {
            this.gameOrdinator.LoadGame(this.gameHistory.Peek());
        }
    }
}
