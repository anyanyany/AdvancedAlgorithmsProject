using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
    /// <summary>
    /// Class containing many graph algorithms.
    /// </summary>
    public static class Algorithms
    {


        public static bool isConnected(IGraph graph)
        {
            for (int i = 0; i < graph.VerticesCount; i++)
            {
                if (graph.GetOutEdges(i) == null && graph.GetInEdges(i) == null)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<Edge> BFS(IGraph graph, int startingVertice, int endingVertice)
        {
            Queue<int> verticesStack = new Queue<int>();
            List<Edge> path = new List<Edge>();
            Edge[] previous = new Edge[graph.VerticesCount];
            int[] activeVertices = new int[graph.VerticesCount];
            for (int i = 0; i < graph.VerticesCount; i++)
            {
                activeVertices[i] = 1;
                previous[i] = null;
            }

            verticesStack.Enqueue(startingVertice);
            while (verticesStack.Count > 0)
            {
                int currentVertice = verticesStack.Dequeue();
                activeVertices[startingVertice] = 0;
                if (currentVertice == endingVertice) break;
                foreach (Edge e in graph.GetOutEdges(currentVertice))
                {
                    if (activeVertices[e.To] == 0)
                        continue;
                    activeVertices[e.To] = 0;
                    previous[e.To] = e;
                    verticesStack.Enqueue(e.To);
                }
            }

            int current = endingVertice;
            while (previous[current] != null)
            {
                path.Add(previous[current]);
                current = previous[current].From;
            }
            path.Reverse();
            return path;
        }

        public static int EdmondsKarp(IGraph graph, int source, int target)
        {
            int maxFlow = 0;

            //create flow graph
            MatrixGraph flow = new MatrixGraph(graph.VerticesCount, true, graph.GetEdges());
            foreach (Edge edge in flow.GetEdges())
                edge.Weight = 0;

            //create residual graph
            MatrixGraph residual = new MatrixGraph(graph.VerticesCount, true, graph.GetEdges());
            foreach (Edge edge in residual.GetEdges())
                edge.Weight = 0;

            while (true)
            {
                List<Edge> augmentingPath = BFS(residual, source, target);
                if (augmentingPath == null)
                    return maxFlow;

                int minWeight = int.MaxValue;
                foreach (Edge edge in augmentingPath)
                {
                    if (edge.Weight < minWeight)
                        minWeight = edge.Weight;
                }
                if(minWeight<1)
                    return maxFlow;

                maxFlow += minWeight;

                foreach (Edge edge in augmentingPath)
                {
                    residual.UpdateEdgeWeight(edge.From, edge.To, -minWeight);
                    residual.UpdateEdgeWeight(edge.To, edge.From, minWeight);

                    flow.UpdateEdgeWeight(edge.From, edge.To, minWeight); 
                    flow.UpdateEdgeWeight(edge.To, edge.From, -minWeight);
                }

            }

            return maxFlow;
        }

    }
}
