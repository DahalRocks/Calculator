using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Dictionary<string, Func<int, int, int>> dic = GetReuslt();
                Console.WriteLine("Please enter among \"+,-,*,/\"");
                var selectedOperator = Console.ReadLine();
                if (dic.ContainsKey(selectedOperator))
                {
                    var refFunc = dic[selectedOperator];
                    int result = refFunc(GetInt(), GetInt());
                    Console.WriteLine("Value after calculation:" + result);
                }
                else
                    Console.WriteLine("Not valid operator entered!!");
                Console.ReadLine();
            }
        }
        static int GetInt()
        {
            Console.WriteLine("Please enter an integer");
            return int.Parse(Console.ReadLine());
        }
        
        static Dictionary<string, Func<int, int, int>> GetReuslt()
        {
            return new Dictionary<string, Func<int, int, int>>{
                {"+",(xa,yb)=>xa+yb },
                {"-",(xa,xb)=>xa-xb},
                {"/",(xa,xb)=>xa/xb},
                {"*",(xa,xb)=>xa*xb}
            };
        }
    }
}
