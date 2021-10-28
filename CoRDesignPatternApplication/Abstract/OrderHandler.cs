using CoRDesignPatternApplication.Enum;
using CoRDesignPatternApplication.Interface;
using CoRDesignPatternApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDesignPatternApplication.Abstract
{
   public abstract  class OrderHandler
    {
        protected OrderHandler _orderHandler;
        public void SetOrderHandler(OrderHandler orderHandler)
        {
            _orderHandler = orderHandler;
        }
        public abstract void NextProcess(OrderBill orderBill);

    }
}
