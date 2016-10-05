using System;
using System.Collections;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");
            string source = Console.ReadLine();
            int remainder = Analyze(source);
            if(remainder==0)
            {
                Console.WriteLine("All is fine! Each bracket has found its match!");
            }
            else
            {
                Console.WriteLine("Something is wrong! 1 or more brackets are missing their match.");
            }
            Console.ReadLine();
        }
        static int Analyze(string source)
        {
            Stack brackets = new Stack();
            foreach (char symbol in source)
            {
                if (symbol == '(')
                {
                    brackets.Push(')');
                }
                else if (symbol == '[')
                {
                    brackets.Push(']');
                }
                else if (symbol == '{')
                {
                    brackets.Push('}');
                }
                else if (symbol == '<')
                {
                    brackets.Push('>');
                }
                else if (brackets.Count != 0)
                {
                    if (brackets.Peek().Equals(symbol))
                    {
                        brackets.Pop();
                    }
                    else if ((symbol == '}') || (symbol == ']') || (symbol == ')') || (symbol == '>'))
                    {
                        return -1;
                    }
                }
                else if ((symbol == '}') || (symbol == ']') || (symbol == ')') || (symbol == '>'))
                {
                    return -1;
                }
            }
            return brackets.Count;
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
//[{}())]