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
            Stack brackets = new Stack();
            bool unacceptable = false;
            foreach(char symbol in source)
            {
                if(symbol=='(')
                {
                    brackets.Push(')');
                }
                else if(symbol=='[')
                {
                    brackets.Push(']');
                }
                else if(symbol=='{')
                {
                    brackets.Push('}');
                }
                else if(symbol=='<')
                {
                    brackets.Push('>');
                }
                else if(brackets.Peek().Equals(symbol))
                {
                    brackets.Pop();
                }
                else if((symbol=='}')||(symbol==']')||(symbol==')')||(symbol=='>'))
                {
                    unacceptable = true;
                }
            }
            if(!unacceptable&&brackets.Count==0)
            {
                Console.WriteLine("All is fine! Each bracket has found its match!");
            }
            else
            {
                Console.WriteLine("Something is wrong! 1 or more brackets are missing their match.");
            }
            Console.ReadLine();
        }
    }
}
//{[]([{}])}<>
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
//<    []{}[](){}
//-     []{}[](){}<>
