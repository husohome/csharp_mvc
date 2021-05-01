using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class StoreA : IPay
    {
        public int Cal(int expenditure)
        {
            if (expenditure >= 5000)
                return expenditure;
            return expenditure + 100;
        }
    }
}
