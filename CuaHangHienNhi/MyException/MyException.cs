using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptionNS
{
    public class MyException : System.Exception
    {
        public String className{get;set;}
        public String errMsg { get; set; }
    }
}
