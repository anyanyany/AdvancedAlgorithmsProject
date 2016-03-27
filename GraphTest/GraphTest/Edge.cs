using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
    /// <summary>
    /// Represents edge in graph. Each edge has one starting and one ending vertex, 
    /// each accessible as From and To class fields. 
    /// </summary>
    public class Edge
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public int Weight { get; set; }

        /// <summary>
        /// Creates edge from provided information. Edge is undirected by default.
        /// </summary>
        /// <param name="from">edge starting point</param>
        /// <param name="to">edge ending point</param>
        /// <param name="isDirected">information if edge is directed</param>
        public Edge(int from, int to, int weight = 0)
        {
            this.From = from;
            this.To = to;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return "("+From.ToString() + ", " + To.ToString()+", "+Weight.ToString()+")";
        }
    }
}
