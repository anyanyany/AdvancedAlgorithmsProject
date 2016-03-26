using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.GraphLibrary
{
    /// <summary>
    /// Represents edge in graph. Each edge has one starting and one ending vertex, 
    /// each accessible as From and To class fields. Edge can also be undirected 
    /// which means that each of those two vertices can act as starting and ending points.
    /// </summary>
    public class Edge
    {
        public bool IsDirected { get; private set; }
        public uint From { get; private set; }
        public uint To { get; private set; }
        public int Weight { get; set; }

        /// <summary>
        /// Creates edge from provided information. Edge is undirected by default.
        /// </summary>
        /// <param name="from">edge starting point</param>
        /// <param name="to">edge ending point</param>
        /// <param name="isDirected">information if edge is directed</param>
        public Edge(uint from, uint to, bool isDirected = false, int weight = 0)
        {
            this.From = from;
            this.To = to;
            this.IsDirected = isDirected;
            this.Weight = weight;
        }
    }
}
