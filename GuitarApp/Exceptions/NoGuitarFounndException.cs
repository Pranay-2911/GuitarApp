using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Exceptions
{
    internal class NoGuitarFounndException : Exception
    {
        public NoGuitarFounndException(string message) : base(message)
        {
            
        }
    }
}
