using GameOfLife.Model;
using System;
using System.Collections.Generic;
using static System.Console;


namespace GameOfLife.Console
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ConsoleColor fg = ForegroundColor;


            // Init
            int width = 9;
            int height = 9;
            TheGameBoard gameBoard = new TheGameBoard(width, height);
            IEnumerable<Tuple<int, int>> initState = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(4,3),
                new Tuple<int, int>(4,4),
                new Tuple<int, int>(4,5)
            };
            gameBoard.Initialize(initState);

            //Game loop

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    WriteSymbol(gameBoard.At(x, y)); 
                }
                WriteLine();
            }


            // Exit

            ForegroundColor = fg;
        }

        static void WriteSymbol(bool x)
        {
            string output = x ? "X " : "O ";

            ForegroundColor = x ? ConsoleColor.Yellow : ConsoleColor.DarkGreen;
            Write(output);
        }
    }
}
