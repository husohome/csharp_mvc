using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class StoreB : IPay
    {
        public int Cal(int expenditure)
        {
            if (expenditure >= 3000)
                return expenditure;
            return expenditure + 99;
        }
    }
}
