using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.GraphLibrary
{

    public static class Algorithms
    {
        public static bool isConnected(IGraph graph)
        {
            for (int i = 0; i < graph.VerticesCount; i++)
                if (graph.GetOutEdges(i) == null && graph.GetInEdges(i) == null)
                    return false;
            return true;
        }

        public static List<Edge> BFS(IGraph graph, int startingVertice, int endingVertice)
        {
            if (graph.GetOutEdges(startingVertice) == null)
                return null;

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
            if (path.Count >= 1)
                return path;
            return null;
        }

        public static int EdmondsKarp(IGraph graph, int source, int target)
        {
            int maxFlow = 0;

            //create flow graph
            MatrixGraph flow = new MatrixGraph(graph.VerticesCount, true, graph.GetEdges());
            foreach (Edge edge in flow.GetEdges())
                flow.UpdateEdgeWeight(edge.From, edge.To, -edge.Weight);

            //create residual graph
            MatrixGraph residual = new MatrixGraph(graph.VerticesCount, true, graph.GetEdges());

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

                maxFlow += minWeight;

                //uptade residual and flow graph
                foreach (Edge edge in augmentingPath)
                {
                    if (residual.DoesEdgeExist(edge.From, edge.To))
                    {
                        residual.UpdateEdgeWeight(edge.From, edge.To, -minWeight);
                        if (residual.GetEdgeWeight(edge.From, edge.To) == 0)
                            residual.DeleteEdge(edge.From, edge.To);
                    }

                    if (!residual.DoesEdgeExist(edge.To, edge.From))
                        residual.AddEdge(new Edge(edge.To, edge.From));
                    residual.UpdateEdgeWeight(edge.To, edge.From, minWeight);

                    flow.UpdateEdgeWeight(edge.From, edge.To, minWeight);
                    flow.UpdateEdgeWeight(edge.To, edge.From, -minWeight);
                }
            }
        }


        public static int chceckConnectivity(IGraph graph)
        {
            int connectivity = 0;

            if (!Algorithms.isConnected(graph))
                return connectivity;

            //create flow network
            MatrixGraph flowNetworkGraph = new MatrixGraph(graph.VerticesCount, true);
            foreach (Edge edge in graph.GetEdges())
            {
                flowNetworkGraph.AddEdge(new Edge(edge.From, edge.To, 1));
                flowNetworkGraph.AddEdge(new Edge(edge.To, edge.From, 1));
            }

            //pick random vertex
            Random rand = new Random();
            int source = rand.Next((int)flowNetworkGraph.VerticesCount);
            int minMaxFlow = int.MaxValue;

            for (int target = 0; target < flowNetworkGraph.VerticesCount; target++)
            {
                if (target == source)
                    continue;
                //find max flow between s and t  
                int maxFlow = Algorithms.EdmondsKarp(flowNetworkGraph, source, target);
                if (maxFlow < minMaxFlow)
                    minMaxFlow = maxFlow;
            }

            connectivity = minMaxFlow;
            return connectivity;
        }
    }
}
