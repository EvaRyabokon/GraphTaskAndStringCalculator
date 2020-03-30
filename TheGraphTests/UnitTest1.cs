using NUnit.Framework;
using System.Collections.Generic;
using TheGraph;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void SimpleTest()
        {
            int[,] pairs = { { 10, 3 }, { 2, 3 }, { 3, 6 }, { 5, 6 }, { 5, 17 }, { 4, 5 }, { 4, 8 }, { 8, 9 }, { 3, 1 } };

            var solver = new TheGraphTaskSolver();

            var expectedSolution = new TheGraphTaskSolution(new List<int>() { 10, 2, 4 }, new List<int>() { 5, 8, 1, 17, 9 });
            Assert.AreEqual(expectedSolution, solver.FindParentCount(pairs));
        }

        [Test]
        public void ThreeGenerations()
        {
            int[,] pairs = { { 5, 4 }, { 4, 3 } };

            var solver = new TheGraphTaskSolver();

            var expectedSolution = new TheGraphTaskSolution(new List<int>() { 5 }, new List<int>() { 3, 4 });
            Assert.AreEqual(expectedSolution, solver.FindParentCount(pairs));
        }

        [Test]
        public void EmptyGraph()
        {
            int[,] pairs = { };

            var solver = new TheGraphTaskSolver();

            var expectedSolution = new TheGraphTaskSolution(new List<int>(), new List<int>());
            Assert.AreEqual(expectedSolution, solver.FindParentCount(pairs));
        }

        [Test]
        public void FiveGenerations()
        {
            int[,] pairs = { { 5, 4 }, { 6, 4 }, { 4, 2 }, { 4, 3 }, { 2, 1 }, { 7, 1 }, { 1, 0 } };

            var solver = new TheGraphTaskSolver();

            var expectedSolution = new TheGraphTaskSolution(new List<int>() { 5, 6, 7 }, new List<int>() { 2, 3, 0 });
            Assert.AreEqual(expectedSolution, solver.FindParentCount(pairs));
        }

        [Test]
        public void DisconnectedGraph()
        {
            int[,] pairs = { { 1, 2}, { 3, 4 }, { 5, 4 } };

            var solver = new TheGraphTaskSolver();

            var expectedSolution = new TheGraphTaskSolution(new List<int>() { 1, 3, 5 }, new List<int>() { 2 });
            Assert.AreEqual(expectedSolution, solver.FindParentCount(pairs));
        }
    }
}
