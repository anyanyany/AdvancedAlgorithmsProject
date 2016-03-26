using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.GraphLibrary
{
    class MatrixGraph : IGraph
    {
        public uint VerticesCount { get; private set; }
        private Edge[,] _edgesMatrix;

        public MatrixGraph(uint verticesCount, List<Edge> edges = null)
        {
            this.VerticesCount = verticesCount;
            _edgesMatrix = new Edge[VerticesCount, VerticesCount];

            if (null != edges)
                foreach (Edge e in edges)
                    AddEdge(e);
        }

        public void AddEdge(Edge e)
        {
            if (DoesEdgeCollide(e))
                throw new ArgumentException("Edge collides with another one in the graph");
            _edgesMatrix[e.From, e.To] = e;
            if (!e.IsDirected)
                _edgesMatrix[e.To, e.From] = e;
        }

        public void UpdateEdgeWeight(int from, int to, int weight)
        {
            if (_edgesMatrix[from, to] == null)
                throw new ArgumentException("There is no such edge in the graph!");
            _edgesMatrix[from, to].Weight = weight;
            if (!_edgesMatrix[from, to].IsDirected)
                _edgesMatrix[to, from].Weight += weight;
        }

        public uint AddVertex()
        {
            this.VerticesCount++;
            Edge[,] tmp = _edgesMatrix;
            _edgesMatrix = new Edge[VerticesCount, VerticesCount];
            for (int i = 0; i < VerticesCount - 1; i++)
                for (int j = 0; j < VerticesCount - 1; j++)
                    _edgesMatrix[i, j] = tmp[i, j];

            return VerticesCount - 1;
        }

        public List<Edge> GetEdges(int vertexNumber = -1)
        {
            if (vertexNumber != -1)
                CheckVertexNumberSanity(vertexNumber);

            HashSet<Edge> edgeSet = new HashSet<Edge>();
            for (int i = 0; i < VerticesCount; i++)
            {
                if (vertexNumber != -1 && i != vertexNumber) continue;
                edgeSet.UnionWith(GetInEdges(i));
                edgeSet.UnionWith(GetOutEdges(i));
            }

            return new List<Edge>(edgeSet);
        }

        public List<Edge> GetInEdges(int vertexNumber)
        {
            CheckVertexNumberSanity(vertexNumber);

            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < VerticesCount; i++)
                if (_edgesMatrix[i, vertexNumber] != null)
                    edges.Add(_edgesMatrix[i, vertexNumber]);

            return edges;
        }

        public List<Edge> GetOutEdges(int vertexNumber)
        {
            CheckVertexNumberSanity(vertexNumber);

            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < VerticesCount; i++)
                if (_edgesMatrix[vertexNumber, i] != null)
                    edges.Add(_edgesMatrix[vertexNumber, i]);

            return edges;
        }

        private bool DoesEdgeCollide(Edge e)
        {
            return (_edgesMatrix[e.From, e.To] != null || (!e.IsDirected && _edgesMatrix[e.To, e.From] != null));
        }

        private void CheckVertexNumberSanity(int vertexNumber)
        {
            if (vertexNumber >= VerticesCount || vertexNumber < 0)
                throw new ArgumentException("Wrong vertex number");
        }
    }
}
