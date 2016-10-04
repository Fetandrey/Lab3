using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");
            string source = Console.ReadLine();
            Stack parenthesis = new Stack();
            foreach(char symbol in source)
            {
                if(symbol=='(')
                {
                    parenthesis.Push(')');
                }
                else if(symbol=='[')
                {
                    parenthesis.Push(']');
                }
                else if(symbol=='{')
                {
                    parenthesis.Push('}');
                }
                else if(parenthesis.Peek().Equals(symbol))
                {
                    parenthesis.Pop();
                }
            }
            if(parenthesis.Count==0)
            {
                Console.WriteLine("All is fine!");
            }
            else
            {
                Console.WriteLine("Something is wrong!");
            }
            Console.ReadLine();
        }
    }
}
//{[]([{}])}
//{[([{
//]}])}
//{     -
//{[    -
//{     []
//{(    []
//{([   []
//{([{  []
//{([   []{}
//{(    []{}[]
//{     []{}[]()
//-     []{}[](){}
