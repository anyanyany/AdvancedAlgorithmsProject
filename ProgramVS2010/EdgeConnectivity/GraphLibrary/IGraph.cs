using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.GraphLibrary
{
    /// <summary>
    /// Interface for each graph. 
    /// </summary>
    public interface IGraph
    {
        uint VerticesCount { get; }
        bool IsDirected { get; }

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
        /// Returns number of incoming and outgoing
        /// edges from specified vertex. If provided 
        /// vertex number does not exist, exception is thrown.
        /// </summary>
        /// <param name="vertexNumber"></param>
        /// <returns></returns>
        uint GetVertexDegree(int vertexNumber);

        /// <summary>
        /// Adds edge to graph. If edge between e.From and e.To
        /// vertices already exists, exception is thrown.
        /// </summary>
        /// <param name="e"></param>
        void AddEdge(Edge e);

        /// <summary>
        /// Returns weight of the edge connecting two specified
        /// vertices. Throws exception if there is no such edge.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        int GetEdgeWeight(int from, int to);

        /// <summary>
        /// Returns information if specified edge exists in the graph.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        bool DoesEdgeExist(int from, int to);

        /// <summary>
        /// Deletes specified edge, or throws exception
        /// if there is no edge to delete.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        void DeleteEdge(int from, int to);

        /// <summary>
        /// Modifies specified edge's weight. Throws exception
        /// if there's no such edge.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="weight"></param>
        void UpdateEdgeWeight(int from, int to, int weight);
    }
}
