using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Evaluate = string.Empty;

            while (Evaluate != "exit")
            {
                Evaluate = Console.ReadLine();
                Console.WriteLine(BalancedString(Evaluate));
            }
        }

        static bool BalancedString(string prC)
        {
            Stack<char> Pairs = new Stack<char>();
            char cPair;

            foreach(char cCurrent in prC)
            {
                if (cCurrent.Equals('(') || cCurrent.Equals('[') || cCurrent.Equals('{'))
                {
                    Pairs.Push(cCurrent);
                }

                if (cCurrent.Equals(')') || cCurrent.Equals(']') || cCurrent.Equals('}'))
                {
                    if (Pairs.Count < 1)
                    {
                        return false;
                    }else
                    {
                        cPair = Pairs.Pop();
                        if (cPair.Equals('(') && !cCurrent.Equals(')'))
                        {
                            return false;
                        }

                        if (cPair.Equals('[') && !cCurrent.Equals(']'))
                        {
                            return false;
                        }

                        if (cPair.Equals('{') && !cCurrent.Equals('}'))
                        {
                            return false;
                        }
                    }
                }
            }

            if (Pairs.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
