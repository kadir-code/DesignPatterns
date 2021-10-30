using CombinedExample.Bussiness.Abstract;
using CombinedExample.Bussiness.Interface;
using CombinedExample.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedExample.Bussiness.Concrete
{
    public class HbackHandler : CarHandler, ICar
    {
        public HbackHandler()
        {

        }
        ICar _car;
        public HbackHandler(ICar car)
        {
            this._car = car;
        }
        public string CarOperation()
        {
            return " Rounded back tured Hback..!";
        }

        public override void HandleCar(CarBase carBase)
        {
            if (carBase.Model.EndsWith("-Hback"))
            {
                Console.WriteLine("Hback car is creating");
            }
            else
            {
                Console.WriteLine("Something wrong happened");
            }
        }
    }
}