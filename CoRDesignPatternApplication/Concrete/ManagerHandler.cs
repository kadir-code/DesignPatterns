using CoRDesignPatternApplication.Abstract;
using CoRDesignPatternApplication.Enum;
using CoRDesignPatternApplication.Interface;
using CoRDesignPatternApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDesignPatternApplication.Concrete
{
    public class ManagerHandler : OrderHandler, IResponse
    {
        public override void NextProcess(OrderBill orderBill)
        {
            if (orderBill.Price < 1001 && orderBill.Price <= 5000)
            {
                Console.WriteLine($"Your request is approved by{this.GetType().Name} ");
            }
            else if (_orderHandler != null)
            {
                _orderHandler.NextProcess(orderBill);
            }

        }
        public Response Response(OrderBill orderBill)
        {
            return orderBill.Price > 5001 ? Enum.Response.Denied : Enum.Response.Approved;
        }

    }
}
