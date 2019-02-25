using System;
using System.Collections.Generic;

namespace GameOfLife.Model
{
    public class TheGameBoard
    {
        private bool[] _board;
        int _width;
        int _height;

        public TheGameBoard() : this(10, 10)
        {}

        public TheGameBoard(int x, int y)
        {
            _width = x;
            _height = y;
            _board = new bool[_width * _height];
        }

        public bool At(int x, int y) => _board[ y * _width + x ];

        

        public int NumberOfNeighbours(int x, int y) 
        {
            var count = 0;
            if (x > 0 && y > 0 && At(x - 1, y - 1)) count++;

            if (y > 0 && At(x, y - 1)) count++;

            if (x < _width && y > 0 && At(x + 1, y - 1)) count++;

            if (x > 0 && At(x - 1, y)) count++;

            if (x < _width && At(x + 1, y)) count++;

            if (x > 0 && y < _height && At(x - 1, y + 1)) count++;

            if (y < _height && At(x, y + 1)) count++;
            if (x < _width && y < _height && At(x + 1, y + 1)) count++;

            return count;
        }

        public void Initialize(IEnumerable<Tuple<int, int>> initState)
        {
            foreach (var pos in initState)
            {
                _board[pos.Item2 * _width + pos.Item1] = true;
            }
        }
    }
}
