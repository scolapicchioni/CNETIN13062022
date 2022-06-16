using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.Lab10 {
    internal class MySDictionary {
        public List<Product> Products { get; set; }

        public Product this[int id] { 
            get {
                return Products.FirstOrDefault(p => p.Id == id);
            } 
        }
    }
}
