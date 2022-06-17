using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.InheritanceDemos {
    internal class CoffeeCupWarmer : IUsbDevice {
        public void HereIsPower() {
            
        }
        public override string ToString() {
            return "Hi! I'm a coffee cup warmer!";
        }
    }
}
