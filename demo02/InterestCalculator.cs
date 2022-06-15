using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02 {
    public class InterestCalculator {
        //int actualYears = sut.CalculateYears(interestRate);

        public int CalculateYears(double interest) 
        {
            //increment becomes 1 + interest percent
            double increment = calculateIncrement(interest);
            //numberOfYears becomes 0
            int numberOfYears = 0;

            double result;
            do {
                //numberOfYears increments of 1
                numberOfYears++;
                //result becomes increment elevated to numberOfYears
                result = Math.Pow(increment, numberOfYears);
                //is the result > than 2?
                
                //if not repeat
            } while (result < 2);
            
            //if so return numberOfYears
            return numberOfYears;
        }

        private double calculateIncrement(double interest) { 
            return 1 + interest / 100;
        }
    }
}
