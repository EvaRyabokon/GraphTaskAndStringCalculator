using System.Collections.Generic;
using System.Linq;

namespace TheGraph
{
    public struct TheGraphTaskSolution
    {
        public readonly List<int> VerticesWithZeroParent;
        public readonly List<int> VerticesWithOneParent;

        public TheGraphTaskSolution(List<int> verticesWithZeroParent, List<int> verticesWithOneParent)
        {
            VerticesWithZeroParent = verticesWithZeroParent;
            VerticesWithOneParent = verticesWithOneParent;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || GetType() != obj.GetType())
            {
                return false;
            }

            TheGraphTaskSolution solution = (TheGraphTaskSolution)obj;

            return Enumerable.SequenceEqual(VerticesWithZeroParent.OrderBy(t => t),
                       solution.VerticesWithZeroParent.OrderBy(t => t)) &&
                   Enumerable.SequenceEqual(VerticesWithOneParent.OrderBy(t => t),
                       solution.VerticesWithOneParent.OrderBy(t => t));
        }
    }

    public class TheGraphTaskSolver
    {
        public TheGraphTaskSolution FindParentCount(int[,] edges)
        {
            var verticesParentsCount = new Dictionary<int, int>();

            for (int i = 0; i < edges.GetLength(0); ++i)
            {
                var parent = edges[i, 0];
                var child = edges[i, 1];

                verticesParentsCount[parent] = verticesParentsCount.GetValueOrDefault(parent);
                verticesParentsCount[child] = verticesParentsCount.GetValueOrDefault(child) + 1;
            }

            var zeroParentCount = verticesParentsCount.Where(x => x.Value == 0).Select(x => x.Key).ToList();
            var oneParentCount = verticesParentsCount.Where(x => x.Value == 1).Select(x => x.Key).ToList();

            return new TheGraphTaskSolution(zeroParentCount, oneParentCount);
        }
    }
}
