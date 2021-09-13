using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico02
{
    public class CustomException : Exception
    {
        public CustomException() : base("Este error corresponde a mi Custom Exception")
        { 
            
        }
    }
}
