namespace FizzBuzz
{
    public class SpecialStringCase
    {
        /// <summary>
        /// The number for which the remainder is calculated
        /// </summary>
        public int Denominator { get; set; }

        /// <summary>
        /// The desired output-string for the denominator
        /// </summary>
        public string SpecialStringResult { get; set; }

        /// <summary>
        /// Defines the order in which the special cases are applied. If IgnoreOtherDenominators is
        /// true, other cases are ignored. If IgnoreOtherDenominators is false, the strings are
        /// returned starting with the string belonging to the case with the highest priority
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// If this is true, and this case has the highest priority, other cases are ignored
        /// </summary>
        public bool IgnoreOtherDenominators { get; set; }

        public SpecialStringCase(int denominator, string specialStringResult, int priority = 0, bool ignoreOtherDenominators = false)
        {
            Denominator = denominator;
            SpecialStringResult = specialStringResult;
            Priority = priority;
            IgnoreOtherDenominators = ignoreOtherDenominators;
        }
    }
}
