using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May15Interface
{
    class LogServiceWeb: ILog
    {
        public void Write(string s) {

            Console.Write(s + "written to web db.");

        }
    }
}
