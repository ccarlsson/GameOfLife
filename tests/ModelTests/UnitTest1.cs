using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife.Model;
using System;
using System.Collections.Generic;

namespace GameOfLife.Tests.ModelTests
{
    [TestClass]
    public class TheGameBoardTests
    {
        TheGameBoard board;

        [TestInitialize]
        public void Setup()
        {
            board = new TheGameBoard(5, 5);
        }

        [TestMethod]
        public void TheGameboardCanBeCreated()
        {
            var board = new TheGameBoard();

            Assert.IsNotNull(board);

        }


        [TestMethod]
        public void Pos2x2Has2Neigbours()
        {
            IEnumerable<Tuple<int, int>> initState = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(2,1),
                new Tuple<int, int>(2,2),
                new Tuple<int, int>(2,3)
            };


            board.Initialize(initState);

            var neighbours = board.NumberOfNeighbours(2, 2);

            Assert.AreEqual(2, neighbours);
    
        }

        [TestMethod]
        public void Pos4x4Has1Neigbours()
        {
            IEnumerable<Tuple<int, int>> initState = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(4,2),
                new Tuple<int, int>(4,3),
                new Tuple<int, int>(4,4)
            };


            board.Initialize(initState);

            var neighbours = board.NumberOfNeighbours(4, 4);

            Assert.AreEqual(1, neighbours);

        }

        [TestMethod]
        public void Pos0x0Has1Neigbours()
        {
            IEnumerable<Tuple<int, int>> initState = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(0,0),
                new Tuple<int, int>(0,1),
                new Tuple<int, int>(0,2)
            };


            board.Initialize(initState);

            var neighbours = board.NumberOfNeighbours(0, 0);

            Assert.AreEqual(1, neighbours);

        }
    }
}
