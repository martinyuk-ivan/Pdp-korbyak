using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.CarModels
{
    public class BMWX5 : BaseCar
    {
        protected override void InitCar()
        {
            this.MaxSpeed = 250;
            this.DateOfIssue = new DateTime(2015, 5, 6);
            this.CarName = "BMWX5";
            this.CarColor = "black";
        }

        public override CarType CarType
        {
            get
            {
                return CarType.Suv;
            }
        }
    }
}
