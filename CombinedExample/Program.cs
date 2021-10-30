using CombinedExample.Bussiness.Abstract;
using CombinedExample.Bussiness.Concrete;
using CombinedExample.Bussiness.Interface;
using CombinedExample.Model.Abstract;
using CombinedExample.Model.Concrete;
using CombinedExample.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CarHandler sedanHandler = new SedanHandler();
            CarHandler suvHandler = new SuvHandler();
            CarHandler hbackHandler = new HbackHandler();

            sedanHandler.SetSuccessor(suvHandler);
            suvHandler.SetSuccessor(hbackHandler);


            List<CarBase> carBases = new List<CarBase>()
            {
                new CarBase
            {
                Brand = "Togg",
                Model = "Xpr-sedan",
                Price = 500,
                Produce=true,
            }};


            foreach (CarBase item in carBases)
            {
                sedanHandler.HandleCar(item);
            }
            

            ICar car = new SedanHandler();
            CreateCar.CreateCars(car);

            CarBase carBase = new CarBase();
            carBase.AddObserver(new SedanObserver());

            Console.ReadKey();
        }
    }
}
