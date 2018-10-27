using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.CarModels
{
    public class Lamborgini : BaseCar
    {
        protected override void InitCar()
        {
            this.MaxSpeed = 350;
            this.DateOfIssue = new DateTime(2017, 1, 5);
            this.CarName = "Lamborgini";
            this.CarColor = "yellow";
        }

        public override CarType CarType
        {
            get
            {
                return CarType.Sport;
            }
        }
    }
}
