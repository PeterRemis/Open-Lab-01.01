using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int cislo = 0;
            int.TryParse(input, out cislo);
            if(cislo < 10)
                return true;
            else
                return false;
        }
    }
}
