using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private List<SpecialStringCase> specialStringResults = new List<SpecialStringCase> {
        new SpecialStringCase(3, "Fizz"),
        new SpecialStringCase(5, "Buzz", 1),
        new SpecialStringCase(7, "FizzBuzzBang", 1, true),
        new SpecialStringCase(10, "Bro", -1, true) };

        public string GetStringForNumber(int integer)
        {
            string result = string.Empty;

            // first check if there are cases where other cases are ignored and order these
            foreach (var specialStringCase in specialStringResults.Where(s => s.IgnoreOtherDenominators).OrderByDescending(s => s.Priority))
            {
                if (integer % specialStringCase.Denominator == 0)
                    return specialStringCase.SpecialStringResult;
            }

            // if other cases are not to be ignored construct the output from all cases
            foreach (var specialStringCase in specialStringResults.Where(s => !s.IgnoreOtherDenominators).OrderByDescending(s => s.Priority))
            {
                if (integer % specialStringCase.Denominator == 0)
                    result += specialStringCase.SpecialStringResult;
            }
            return (result == string.Empty) ? integer.ToString() : result;
        }
    }
}
