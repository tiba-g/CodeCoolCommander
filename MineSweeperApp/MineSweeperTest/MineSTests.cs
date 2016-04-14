using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MineSweeper;

namespace MineSweeperTest
{
    [TestClass]
    public class MineSTests
    {
        [TestMethod]
        public void SearchMines_EmptyStringArray_ReturnsEmptyStringArray()
        {
            //Arrange
            string[] result;
            //Act
            string[] expect = Miner.SearchMines(new string[1] { "" });
            result = new string[1] { "" };
            //Assert
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void SearchMines_StringArrayWithMine_ReturnsStringArrayWithMine()
        {
            //Arrange
            string[] result;
            //Act
            string[] expect = Miner.SearchMines(new string[1] { "*" });
            result = new string[1] { "*" };
            //Assert
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void SearchMines_3SizeStringArrayWithMineAndPoints__ReturnsStringArrayWithMineAndNumbers()
        {
            //Arrange
            string[] result;
            //Act
            string[] expect = Miner.SearchMines(new string[1] { ".*." });
            result = new string[1] { "1*1" };
            //Assert
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void SearchMines_3_3_SizeStringArrayWithMineAndPoints__ReturnsStringArrayWithMineAndNumbers()
        {
            //Arrange
            string[] result;
            //Act
            string[] expect = Miner.SearchMines(new string[3] { "...", ".*.", "..." });
            result = new string[3] { "111", "1*1", "111" };
            //Assert
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void SearchMines_3_3_SizeStringArrayWithTwoMineAndPoints__ReturnsStringArrayWithTwoMineAndNumbers()
        {
            //Arrange
            string[] result;
            //Act
            string[] expect = Miner.SearchMines(new string[3] { "*..", ".*.", "..." });
            result = new string[3] { "*21", "2*1", "111" };
            //Assert
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void SearchMines_DifferentLongRows_SizeStringArrayWithManyMineAndPoints__ReturnsStringArrayWithManyMineAndNumbers()
        {
            //Arrange
            string[] result;
            //Act
            string[] expect = Miner.SearchMines(new string[5] { "*..", ".*.", "..**.", "..*", ".*" });
            result = new string[5] { "*21", "2*3", "13**1", "13*", "1*" };
            //Assert
            CollectionAssert.AreEqual(expect, result);
        }
    }
}
