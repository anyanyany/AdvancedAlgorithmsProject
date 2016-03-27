using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
    /// <summary>
    /// Interface for each graph. 
    /// </summary>
    public interface IGraph
    {
        uint VerticesCount { get; }
        bool isDirected { get; }

        /// <summary>
        /// Returns edges connected to vertex with specified number. 
        /// In case of number greater than highest vertex number 
        /// or lower than -1 exception is thrown. 
        /// If vertex number is -1 (which is by default) list of all 
        /// edges in graph is returned.
        /// </summary>
        /// <param name="vertexNumber">vertex from which edges will be collected</param>
        /// <returns></returns>
        List<Edge> GetEdges();

        /// <summary>
        /// Returns outgoing edges for specified vertex.
        /// If vertex number does not exist in graph,
        /// exception with error description is thrown.
        /// </summary>
        /// <param name="vertexNumber"></param>
        /// <returns></returns>
        List<Edge> GetOutEdges(int vertexNumber);

        /// <summary>
        /// Returns incoming edges for specified vertex.
        /// If vertex number does not exist in graph,
        /// exception with error description is thrown.
        /// </summary>
        /// <param name="vertexNumber"></param>
        /// <returns></returns>
        List<Edge> GetInEdges(int vertexNumber);

        /// <summary>
        /// Adds edge to graph. If edge between e.From and e.To
        /// vertices already exists, exception is thrown.
        /// </summary>
        /// <param name="e"></param>
        void AddEdge(Edge e);

    }
}
