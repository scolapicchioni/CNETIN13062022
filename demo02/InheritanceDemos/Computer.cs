using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.InheritanceDemos {
    internal class Computer {
        public void Plug(IUsbDevice device) {
            device.HereIsPower();
        }
    }
}
