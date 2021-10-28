using CoRDesignPatternApplication.Abstract;
using CoRDesignPatternApplication.Concrete;
using CoRDesignPatternApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDesignPatternApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderHandler employee = new EmployeeHandler();
            OrderHandler manager = new ManagerHandler();
            OrderHandler executive = new ExecutiveHandler();

            employee.SetOrderHandler(manager);
            manager.SetOrderHandler(executive);

            List<OrderBill> orderBills = new List<OrderBill>()
            {
                new OrderBill{Name="Pudding" ,Price=50},
                new OrderBill{Name="Fish" ,Price=550},
                new OrderBill{Name="Beef" ,Price=5550},
                new OrderBill{Name="BeefXL" ,Price=555990},

            };

            foreach (OrderBill item in orderBills)
            {
                employee.NextProcess(item);
            }

            Console.Read();
        }
    }
}
