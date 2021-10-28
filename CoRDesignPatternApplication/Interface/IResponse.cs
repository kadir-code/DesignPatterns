using CoRDesignPatternApplication.Abstract;
using CoRDesignPatternApplication.Enum;
using CoRDesignPatternApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDesignPatternApplication.Interface
{
    public interface  IResponse
    {
        Response Response(OrderBill orderBill);
    }
}
