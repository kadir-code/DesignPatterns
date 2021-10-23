using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Director
{
    class CreateCar
    {
        public void Create(CarBuilder Araba)
        {
            Araba.SetKM();
            Araba.SetBrand();
            Araba.SetModel();
        }
    }
}
