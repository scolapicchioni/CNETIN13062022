using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.Lab10 {
    internal class Rectangle {
        private int length;

        public int Lenght {
            get { 
                return length; 
            }
            set { 
                if(value>0)
                    length = value; 
            }
        }

        private string name;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Width { get; set; }
        public int Area { 
            get {
                return length * Width;
            } 
        }
    }
}
