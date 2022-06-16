using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02 {
    internal class SimoDate {
        private int day;
        public int Day { 
            get { return day; }
            set {
                if (value >= 1 && value <= 31) {
                    day = value;
                }
            } 
        }

        public int Month { get; set; }
        public int Year { get; set; }

        public SimoDate() : this(1, 1, 0) {
            Console.WriteLine("Default constructor for a SimoDate");
        }
        //public SimoDate(int day, int month, int year) {
        //    Console.WriteLine("Constructor for a SimoDate with 3 parameters");
        //    this.day = day;
        //    Month = month;
        //    Year = year;
        //}

        public SimoDate(int day, int month, int year) => (this.day, Month, Year) = (day, month, year);

        public void Deconstruct(out int day, out int month, out int year) {
            //day = this.day;
            //month = Month;
            //year = Year;
            (day, month, year) = (this.day, Month, Year);
        }

        public void Dispose() { 
            GC.SuppressFinalize(this);
            //close whatever
        }
        ~SimoDate() {
            Console.WriteLine("DESTRUCTORRRRRRRRRR************************************");
        }
    }
}
