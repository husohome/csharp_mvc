using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpOrder
{
    class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Emp() { }
        public Emp(int id, string name) {
            this.ID = id;
            this.Name = name;
        }

    }
}
