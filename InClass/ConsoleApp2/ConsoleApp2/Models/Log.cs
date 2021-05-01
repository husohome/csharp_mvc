using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    public enum LogTypeDef { 
        // enums are used for standardization!
        SystemError, RuntimeError, Error
    }
    public class Log
    {
        public LogTypeDef LogType { get; set; }
        public DateTime LogTime { get; set; }
        public string LogContent { get; set; }

        public void MaskedWriteLog() {
            if(LogContent.Length > 0)
                Console.WriteLine(this.LogContent);
            if (this.LogType == LogTypeDef.SystemError)
            {
                Console.WriteLine("Send an e-mail.");
            }
        }
        public virtual void OverriddenWriteLog() {
            if (LogContent.Length > 0)
                Console.WriteLine(this.LogContent);
            if (this.LogType == LogTypeDef.SystemError) {
                Console.WriteLine("Send an e-mail.");
            }
        }
    }

    class DBLog : Log {
        public new void MaskedWriteLog()
        {

            Console.WriteLine("Record stored in Database.");
        }
        public override void OverriddenWriteLog() {
            Console.WriteLine("Record stored in Database.");
        }
    }

    class TxtLog : Log { }
}
