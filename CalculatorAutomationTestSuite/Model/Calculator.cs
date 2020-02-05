using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationTestSuite.Model
{
    public class Calculator
    {
        private char operation = '+';

        public int Number { get; set; }

        public int Result { get; set; }

        public void Add()
        {
            operation = '+';
            Result = Number;
        }

        public void Subtract()
        {
            operation = '-';
            Result = Number;
        }


        public void Multipy()
        {
            operation = '*';
            Result = Number;
        }

        public void Divide()
        {
            operation = '/';
            Result = Number;
        }

        public void IsEqualTo() => DoMathOperation();

        private void DoMathOperation() {
            switch (operation) 
            {
                case '+':
                    Result += Number;
                    break;
                case '-':
                    Result -= Number;
                    break;
                case '*':
                    Result *= Number;
                    break;
                case '/':
                    Result /= Number;
                    break;
            }
        }
    } // end of class
} //end of namespace
