using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpOrder
{
    class Order
    {
        public int ID { get; set; }
        public int Amount { get; set; }

        public Order() { }
        public Order(int id, int amount)
        {
            this.ID = id;
            this.Amount = amount;
        }
    }
}
