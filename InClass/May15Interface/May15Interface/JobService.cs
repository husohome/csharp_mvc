using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May15Interface
{
    class JobService
    {
        // this class uses log services 
        private ILog _logService;

        public JobService(ILog logService)
        {
                this._logService = logService;
        }

        public void run() {

            Console.WriteLine("doing sometihg.");
            // logging
            _logService.Write("doing simething!");
            Console.ReadLine();
        
        }



    }
}
