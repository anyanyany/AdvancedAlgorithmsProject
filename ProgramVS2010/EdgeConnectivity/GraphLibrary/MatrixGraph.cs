﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.GraphLibrary
{
    /// <summary>
    /// Class representing graph, holding information about edges in matrix.
    /// </summary>
    class MatrixGraph : IGraph
    {
        public uint VerticesCount { get; private set; }
        public bool IsDirected { get; private set; }
        private int[,] _edgesMatrix;

        public MatrixGraph(uint verticesCount, bool isDirected = false, List<Edge> edges = null)
        {
            this.VerticesCount = verticesCount;
            this.IsDirected = isDirected;
            _edgesMatrix = new int[VerticesCount, VerticesCount];

            for (int i = 0; i < VerticesCount; i++)
                for (int j = 0; j < VerticesCount; j++)
                    _edgesMatrix[i, j] = -1;

            if (null != edges)
                foreach (Edge e in edges)
                    AddEdge(e);
        }

        public void AddEdge(Edge e)
        {
            if (DoesEdgeCollide(e))
                throw new ArgumentException("Edge collides with another one in the graph");
            _edgesMatrix[e.From, e.To] = e.Weight;
            if (!this.IsDirected)
                _edgesMatrix[e.To, e.From] = e.Weight;
        }

        public void DeleteEdge(int from, int to)
        {
            if (_edgesMatrix[from, to] == -1)
                throw new ArgumentException("There is no such edge in the graph!");
            _edgesMatrix[from, to] = -1;
            if (!this.IsDirected)
                _edgesMatrix[to, from] = -1;
        }

        public void UpdateEdgeWeight(int from, int to, int weight)
        {
            if (_edgesMatrix[from, to] == -1)
                throw new ArgumentException("There is no such edge in the graph!");
            _edgesMatrix[from, to] += weight;
            if (!this.IsDirected)
                _edgesMatrix[to, from] += weight;
        }

        public int GetEdgeWeight(int from, int to)
        {
            if (_edgesMatrix[from, to] == -1)
                throw new ArgumentException("There is no such edge in the graph!");
            return _edgesMatrix[from, to];
        }

        public bool DoesEdgeExist(int from, int to)
        {
            return (_edgesMatrix[from, to] != -1);
        }

        public List<Edge> GetEdges()
        {
            List<Edge> edgeList = new List<Edge>();
            if (!this.IsDirected)
            {
                for (int i = 0; i < VerticesCount; i++)
                    for (int j = i; j < VerticesCount; j++)
                    {
                        if (_edgesMatrix[i, j] != -1)
                            edgeList.Add(new Edge(i, j, _edgesMatrix[i, j]));
                    }
            }
            else
            {
                for (int i = 0; i < VerticesCount; i++)
                    for (int j = 0; j < VerticesCount; j++)
                    {
                        if (_edgesMatrix[i, j] != -1)
                            edgeList.Add(new Edge(i, j, _edgesMatrix[i, j]));
                    }
            }

            return edgeList;
        }

        public List<Edge> GetInEdges(int vertexNumber)
        {
            CheckVertexNumberSanity(vertexNumber);

            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < VerticesCount; i++)
                if (_edgesMatrix[i, vertexNumber] != -1)
                    edges.Add(new Edge(i, vertexNumber, _edgesMatrix[i, vertexNumber]));

            return edges;
        }

        public List<Edge> GetOutEdges(int vertexNumber)
        {
            CheckVertexNumberSanity(vertexNumber);

            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < VerticesCount; i++)
                if (_edgesMatrix[vertexNumber, i] != -1)
                    edges.Add(new Edge(vertexNumber, i, _edgesMatrix[vertexNumber, i]));

            return edges;
        }

        public uint GetVertexDegree(int vertexNumber)
        {
            CheckVertexNumberSanity(vertexNumber);

            return (uint) (GetOutEdges(vertexNumber).Count + GetInEdges(vertexNumber).Count);
        }

        private bool DoesEdgeCollide(Edge e)
        {
            return (_edgesMatrix[e.From, e.To] != -1);
        }

        private void CheckVertexNumberSanity(int vertexNumber)
        {
            if (vertexNumber >= VerticesCount || vertexNumber < 0)
                throw new ArgumentException("Wrong vertex number");
        }
    }
}
