using Patterns.RaceGame.CarModels;
using System.Collections.Generic;

namespace Patterns.RaceGame.RoadModels
{
    public class Road
    {
        public RoadType Type { get; set; }

        public int TrafficSize { get; set; }

        public List<BaseCar> Cars { get; set; }

        public int Distance { get; set; }
    }
}
