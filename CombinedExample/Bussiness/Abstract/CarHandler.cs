using CombinedExample.Model.Abstract;
using CombinedExample.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedExample.Bussiness.Abstract
{
    public abstract class CarHandler
    {
        protected CarHandler _carHandler;
        public void SetSuccessor(CarHandler carHandler)
        {
            _carHandler = carHandler;
        }

        public abstract void HandleCar(CarBase carBase);

       
    }
}
