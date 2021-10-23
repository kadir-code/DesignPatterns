using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.ConcreteBuilder
{
    class VolvoBuilder : CarBuilder
    {
        public override void SetBrand()
        {
            _car.Brand = "Volvo";
        }

        public override void SetKM()
        {
            _car.KM = 120;
        }

        public override void SetModel()
        {
            _car.Model = "xc90";
        }
    }
}
