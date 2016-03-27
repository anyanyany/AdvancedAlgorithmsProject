using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MatrixGraph graph = new MatrixGraph(5, false);
            graph.AddEdge(new Edge(0, 1));
            graph.AddEdge(new Edge(1, 2));
            graph.AddEdge(new Edge(2, 0));
            graph.AddEdge(new Edge(1, 4));
            graph.AddEdge(new Edge(2, 3));
            graph.AddEdge(new Edge(4, 3));

            //check if graph is disconnected
            if (!Algorithms.isConnected(graph))
            {
                Console.WriteLine("edge connectivity 0");
                return;
            }

            //create flow network
            MatrixGraph flowNetworkGraph = new MatrixGraph(graph.VerticesCount, true);
            foreach (Edge edge in graph.GetEdges())
            {
                flowNetworkGraph.AddEdge(new Edge(edge.From, edge.To, 1));
                flowNetworkGraph.AddEdge(new Edge(edge.To, edge.From, 1));
            }

            Random rand = new Random();
            int source = rand.Next((int)flowNetworkGraph.VerticesCount);
            int minMaxFlow = int.MaxValue;

            for (int t = 0; t < flowNetworkGraph.VerticesCount; t++)
            {
                if (t == source)
                    continue;
                //find max flow between s and t  
                int maxFlow = Algorithms.EdmondsKarp(flowNetworkGraph, source, t);
                //int maxFlow = 0;
                if (maxFlow < minMaxFlow)
                    minMaxFlow = maxFlow;
            }

            /*Console.WriteLine("path");
            List<Edge> augmentingPath = Algorithms.BFS(flowNetworkGraph, 3, 4);
            foreach (Edge e in augmentingPath)
                Console.WriteLine(e.ToString());*/

            Console.WriteLine(minMaxFlow);

        }
    }
}
