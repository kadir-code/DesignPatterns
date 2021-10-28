using CoRDesignPatternApplication.Abstract;
using CoRDesignPatternApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDesignPatternApplication.Concrete
{
    public class EmployeeHandler : OrderHandler
    {
        public override void NextProcess(OrderBill orderBill)
        {
            if (orderBill.Price<100)
            {
                Console.WriteLine($"Your request is approved by{this.GetType().Name} ");
            }
            else if(_orderHandler!=null)
            {
                _orderHandler.NextProcess(orderBill);
            }
        }
    }
}
