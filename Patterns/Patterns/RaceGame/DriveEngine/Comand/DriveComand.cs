using Patterns.RaceGame.DriveEngine.Comand.Drive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.DriveEngine.Comand
{
    public class DriveComand : IDriveComand
    {
        private TurnSystem turnSystem;

        private Dictionary<Direction, Action> mapper;

        private Direction direction;

        public DriveComand(TurnSystem turnSystem, Direction direction)
        {
            this.turnSystem = turnSystem;
            this.direction = direction;
            this.mapper = new Dictionary<Direction, Action>
            {
                { Direction.Left, turnSystem.TurnOnLeft },
                { Direction.Right, turnSystem.TurnOnRight },
                { Direction.SpeedUp, turnSystem.SpeedUp },
                { Direction.SlowDown, turnSystem.SpeedDown }
            };
        }

        public void Execute()
        {
            this.mapper[direction]();
        }
    }
}
