using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class GameTest
    {

        [TestMethod]
        public void Game_Given_More_Than_4_Should_Return_False()
        {
            Assert.IsFalse( Lesson1.Program.game("123", null));
        }

        [TestMethod]
        public void Game_Given_NonNumerric_Should_Return_False()
        {
            Assert.IsFalse(Lesson1.Program.game("123a", new int[]{1,2,3,4}));
        }

        [TestMethod]
        public void Game_Given_0_Should_Return_False()
        {
            Assert.IsFalse(Lesson1.Program.game("1230", new int[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void Game_Given_Exact_Expected_Should_Return_True()
        {
            Assert.IsTrue(Lesson1.Program.game("1234", new int[] { 1, 2, 3, 4 }));
        }
        [TestMethod]
        public void Game_Given_Partial_Expected_Should_Return_False()
        {
            Assert.IsFalse(Lesson1.Program.game("1325", new int[] { 1, 2, 3, 4 }));
        }
    }
}
