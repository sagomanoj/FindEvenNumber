using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FindOddAndEvenNumber
    {
        public bool IsEven(int number)
        {
            return (number & 1) == 0;
        }

    }
}
