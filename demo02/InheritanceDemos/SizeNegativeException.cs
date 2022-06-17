using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.InheritanceDemos {
    public class SizeNegativeException : Exception {
        public SizeNegativeException(string message) : base(message) {

        }
    }
}
