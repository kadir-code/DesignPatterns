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
    public class SuvHandler : CarHandler, ICar
    {
        public SuvHandler()
        {

        }
        ICar _car;
        public SuvHandler(ICar car)
        {
            this._car = car;
        }
        public string CarOperation()
        {
            return " ,Rounded back is added ..!";
        }

        public override void HandleCar(CarBase carBase)
        {
            if (carBase.Model.EndsWith("-suv"))
            {
                Console.WriteLine("Suv car is creating");
            }
            else
            {
                _carHandler.HandleCar(carBase);
            }
        }
    }
}
