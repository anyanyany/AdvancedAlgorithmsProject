﻿using System;
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
    }
}