using MainLibrary;
using NUnit.Framework;
using System;

namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGameBoard()
        {
            Game game = new Game(new BoardNotation());

            Assert.IsTrue(game.GetBoard().GetType() == typeof(BoardNotation));
        }

        [Test]
        public void TestMakeBoard()
        {
            BoardNotation board = new BoardNotation();

            Assert.IsTrue(board.GetCoordinates().GetType() == typeof(String[,]));

            Assert.AreEqual("h1", board.GetCoordinates()[7, 0]);
            Assert.AreEqual("h8", board.GetCoordinates()[7, 7]);
        }

    }
}