using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Operations
    {
        public int add(int n1, int n2)
        {
            return n1 + n2;
        }

        public bool isEven(int num)
        {
            return num % 2 == 0; 
        }
         
        public double addDecimal(double num1, double num2)
        {
            return num1+ num2;
        }
        }
    }
