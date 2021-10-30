using CombinedExample.Bussiness.Interface;
using CombinedExample.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedExample.Model.Interface
{
    public class CreateCar
    {
      public static void CreateCars(ICar car)
        {
            Console.WriteLine(car.CarOperation());
        }
    }
}
