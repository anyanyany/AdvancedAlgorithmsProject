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
            int solution = 0;

            Console.WriteLine("***graph1 - simple***");
            MatrixGraph graph = new MatrixGraph(5, false);
            graph.AddEdge(new Edge(0, 1));
            graph.AddEdge(new Edge(1, 2));
            graph.AddEdge(new Edge(2, 0));
            graph.AddEdge(new Edge(1, 4));
            graph.AddEdge(new Edge(2, 3));
            graph.AddEdge(new Edge(4, 3));

            solution = Algorithms.chceckConnectivity(graph);
            Console.WriteLine(solution + " " + (solution == 2));

            Console.WriteLine("***graph2 - bottleneck***");
            MatrixGraph graph2 = new MatrixGraph(10, false);
            graph2.AddEdge(new Edge(4, 0));
            graph2.AddEdge(new Edge(4, 1));
            graph2.AddEdge(new Edge(4, 2));
            graph2.AddEdge(new Edge(4, 3));
            graph2.AddEdge(new Edge(4, 5));
            graph2.AddEdge(new Edge(0, 1));
            graph2.AddEdge(new Edge(2, 1));
            graph2.AddEdge(new Edge(2, 3));
            graph2.AddEdge(new Edge(5, 6));
            graph2.AddEdge(new Edge(5, 7));
            graph2.AddEdge(new Edge(5, 8));
            graph2.AddEdge(new Edge(5, 9));
            graph2.AddEdge(new Edge(6, 7));
            graph2.AddEdge(new Edge(7, 8));
            graph2.AddEdge(new Edge(8, 9));

            solution = Algorithms.chceckConnectivity(graph2);
            Console.WriteLine(solution + " " + (solution == 1));

            Console.WriteLine("***graph3 - full***");
            MatrixGraph graph3 = new MatrixGraph(10, false);
            for (int i = 0; i < 10; i++)
                for (int j = i + 1; j < 10; j++)
                    graph3.AddEdge(new Edge(i, j));
            solution = Algorithms.chceckConnectivity(graph3);
            Console.WriteLine(solution + " " + (solution == 9));

            Console.WriteLine("***graph4 - full + 1 vertex and 2 edges***");
            MatrixGraph graph4 = new MatrixGraph(11, false);
            for (int i = 0; i < 10; i++)
                for (int j = i + 1; j < 10; j++)
                    graph4.AddEdge(new Edge(i, j));
            graph4.AddEdge(new Edge(10, 0));
            graph4.AddEdge(new Edge(10, 5));
            solution = Algorithms.chceckConnectivity(graph4);
            Console.WriteLine(solution + " " + (solution == 2));

            Console.WriteLine("***graph5 - full + 1 isolated vertex***");
            MatrixGraph graph5 = new MatrixGraph(11, false);
            for (int i = 0; i < 10; i++)
                for (int j = i + 1; j < 10; j++)
                    graph5.AddEdge(new Edge(i, j));
            solution = Algorithms.chceckConnectivity(graph5);
            Console.WriteLine(solution + " " + (solution == 0));

            Console.WriteLine("***graph6 - 2 full graphs connected by 1 edge***");
            MatrixGraph graph6 = new MatrixGraph(20, false);
            for (int i = 0; i < 10; i++)
                for (int j = i + 1; j < 10; j++)
                    graph6.AddEdge(new Edge(i, j));
            for (int i =10; i < 20; i++)
                for (int j = i + 1; j < 20; j++)
                    graph6.AddEdge(new Edge(i, j));
            graph6.AddEdge(new Edge(9, 10));
            solution = Algorithms.chceckConnectivity(graph6);
            Console.WriteLine(solution + " " + (solution == 1));


        }
    }
}
