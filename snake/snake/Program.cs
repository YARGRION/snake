using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
        int x1=1;
        int y1=1;
        char s1='*';
        Draw(x1, y1, s1);

        Console.ReadLine();
    }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
  
    }
}
