using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.GraphLibrary
{
    /// <summary>
    /// Class containing many graph algorithms.
    /// </summary>
    public static class Algorithms
    {
        /// <summary>
        /// Runs BFS algorithm and returns the shortest path from starting to ending vertice in form
        /// of edge list. If there is no such path null value is returned.
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="startingVertice"></param>
        /// <param name="endingVertice"></param>
        /// <returns></returns>
        public static List<Edge> BFS(IGraph graph, int startingVertice, int endingVertice)
        {
            Queue<int> verticesStack = new Queue<int>();
            List<Edge>[] verticePath = new List<Edge>[graph.VerticesCount];
            verticePath[startingVertice] = new List<Edge>();

            verticesStack.Enqueue(startingVertice);
            while (verticesStack.Count > 0)
            {
                int currentVertice = verticesStack.First();
                if (currentVertice == endingVertice) break;
                foreach (Edge e in graph.GetOutEdges(currentVertice))
                {
                    if (verticePath[e.To] == null) continue;
                    verticePath[e.To] = new List<Edge>();
                    verticePath[e.To].AddRange(verticePath[currentVertice]);
                    verticesStack.Enqueue((int)e.To);
                }
            }

            return verticePath[endingVertice];
        }

        public static int EdmondsKarp(IGraph graph, int source, int target)
        {
            int maxFlow = 0;

            //create flow graph
            MatrixGraph flow = new MatrixGraph(graph.VerticesCount, graph.GetEdges());
            foreach (Edge edge in flow.GetEdges())
            {
                edge.Weight = 0;
            }
            //create residual graph
            MatrixGraph residual = new MatrixGraph(graph.VerticesCount, graph.GetEdges());

            while (true)
            {
                List<Edge> augmentingPath = BFS(residual, source, target);
                if(augmentingPath==null)
                    return maxFlow;

                int minWeight= int.MaxValue;
                foreach (Edge edge in augmentingPath)
                {
                    if (edge.Weight < minWeight)
                        minWeight = edge.Weight;
                }
                maxFlow += minWeight;

                foreach (Edge edge in augmentingPath)
                {
                    residual.UpdateEdgeWeight(edge.From, edge.To, -minWeight);
                    residual.UpdateEdgeWeight(edge.To, edge.From, minWeight);
                    flow.UpdateEdgeWeight(edge.From, edge.To, minWeight); //???
                }

            }

            return maxFlow;
        }
    }
}
