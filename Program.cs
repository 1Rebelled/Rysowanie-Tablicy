using System;

class Program
{
    static void Main(string[] args)
    {
        // Deklaracja tablicy string ponieważ są znaki   6x6  dwuwymiarowa
        string[,] TablicaZnakow = new string[6, 6] {
            { "%", "%","%", "#","#", "#" },
            { "%", "%","%", "#","#", "#"  },
            { "%", "%","%", "#","#", "#"  },
            { "*", "*","*", "+","+", "+"  },
            { "*", "*","*", "+","+", "+"  },
            { "*", "*","*", "+", "+", "+"  }
        };
        // Pętla w pętli
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write("{0}\t", TablicaZnakow[i, j]);
            }
            // przeniesienie do nastepnego wierszu
            Console.WriteLine();
        }

    }

}
