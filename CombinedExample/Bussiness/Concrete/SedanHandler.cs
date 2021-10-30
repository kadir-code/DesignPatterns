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
    public class SedanHandler : CarHandler,ICar
    {
        List<IObserver> _observer;
        public SedanHandler()
        {
            _observer = new List<IObserver>();
        }
        ICar _car;
        public SedanHandler(ICar car)
        {
            this._car = car;
        }
        public string CarOperation()
        {
            return "Standard car is created..!";
        }

        public override void HandleCar(CarBase carBase)
        {
            if (carBase.Model.EndsWith("-sedan"))
            {
                Console.WriteLine("Sedan car is creating");
            }
            else
            {
                _carHandler.HandleCar(carBase);
            }
        }
    }
}
