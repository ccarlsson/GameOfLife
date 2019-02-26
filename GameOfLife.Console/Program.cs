using GameOfLife.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;


namespace GameOfLife.Console
{
    class Program
    {


        static void Main(string[] args)
        {
            ConsoleColor fg = ForegroundColor;


            // Init
            int width = 15;
            int height = 15;
            TheGameBoard gameBoard = new TheGameBoard(width, height);
            IEnumerable<Tuple<int, int>> initState = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(1,0),
                new Tuple<int, int>(2,1),
                new Tuple<int, int>(2,2),
                new Tuple<int, int>(1,2),
                new Tuple<int, int>(0,2)
            };
            gameBoard.Initialize(initState);

            //Game loop

            while (true)
            {
                gameBoard.Tick();
                PrintBoard(width, height, gameBoard);
                Thread.Sleep(800);
                Clear();
            }


            // Exit

            ForegroundColor = fg;
        }

        private static void PrintBoard(int width, int height, TheGameBoard gameBoard)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    WriteSymbol(gameBoard.At(x, y));
                }
                WriteLine();
            }
        }

        static void WriteSymbol(bool x)
        {
            string output = x ? "X " : "O ";

            ForegroundColor = x ? ConsoleColor.Yellow : ConsoleColor.DarkGreen;
            Write(output);
        }
    }
}
