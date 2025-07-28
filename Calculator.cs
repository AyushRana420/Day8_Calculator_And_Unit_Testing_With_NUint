using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__MathLibrary_Testing_using_NUnit
{
    public class Calculator
    {
        public int Add(int a, int b)//Traditional method
        {
            return a + b;
        }
        public int Subtract(int a, int b) => a - b; // lambda expression
    }
}
