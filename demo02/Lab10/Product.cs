using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.Lab10 {
    internal class Product {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; } = 1234;
        public string FullName { 
            get {
                return $"{Brand} - {Name}";
            } 
        }
        
            
        
    }
}
