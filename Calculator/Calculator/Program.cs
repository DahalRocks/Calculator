using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program:IMath
    {
        delegate int Calculation(decimal a, decimal b, string c);
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Please enter the first operand:");
            var firstNumber=Console.ReadLine();
            Console.WriteLine("Please enter the operator:");
            var operators= Console.ReadLine();
            var secondNumber = Console.ReadLine();
            var makeResult = new FindReuslt(firstNumber, secondNumber, operators);


        }

        public int FindReuslt(double a, double b, string c)
        {

        }

        public void Addition(decimal a, decimal b)
        {

            Console.WriteLine("The result is:" + (a + b));
            throw new NotImplementedException();
        }

        public void Division()
        {
            throw new NotImplementedException();
        }

        public void Multiplication()
        {
            throw new NotImplementedException();
        }

        public void Substraction()
        {
            throw new NotImplementedException();
        }
    }
    
    interface IMath
    {
        void Addition(decimal a, decimal b);
        void Substraction();
        void Multiplication();
        void Division();
    }
}
