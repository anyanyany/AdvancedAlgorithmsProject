using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.GraphLibrary;

namespace Program
{
    public partial class Form1 : Form
    {
        MatrixGraph graph;

        public Form1()
        {
            InitializeComponent();
        }

        private void uploadGraphButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "?";
            listOfEgdes.Items.Clear();

            OpenFileDialog theDialog = new OpenFileDialog
            {
                Title = @"Open Text File",
                Filter = @"TXT files|*.txt",
                InitialDirectory = Directory.GetCurrentDirectory(),
                RestoreDirectory = true
            };
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = theDialog.FileName;
                int numberOfVertices = 0;
                int[,] edges = null;

                try
                {
                    numberOfVertices = new Parser().Parse(filename, out edges);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong file format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    graph = null;
                    return;
                }

                //graph construction
                graph = new MatrixGraph((uint)numberOfVertices, false);
                for (int i = 0; i < edges.GetLength(0); i++)
                {
                    graph.AddEdge(new Edge(edges[i, 0], edges[i, 1]));
                    listOfEgdes.Items.Add(""+edges[i,0].ToString()+"<------>" + edges[i, 1].ToString());
                }


            }
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            if(graph==null)
            {
                MessageBox.Show("There is no graph!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            resultLabel.Text = "?";

            //check if graph is disconnected
            for (int i = 0; i < graph.VerticesCount; i++)
            {
                if (graph.GetOutEdges(i).Capacity == 0)
                {
                    resultLabel.Text = "0";
                    return;
                }
            }

            //graph is connected - we can compute the edge connectivity

            //create flow network
            MatrixGraph flowNetworkGraph = new MatrixGraph(graph.VerticesCount);
            foreach (Edge edge in graph.GetEdges())
            {
                Edge e1 = new Edge(edge.From, edge.To, 1);
                Edge e2 = new Edge(edge.To, edge.From, 1);
                flowNetworkGraph.AddEdge(e1);
                flowNetworkGraph.AddEdge(e2);
            }

            Random rand = new Random();
            int source = rand.Next((int)flowNetworkGraph.VerticesCount);
            int minMaxFlow = int.MaxValue;

            for(int t=0;t<flowNetworkGraph.VerticesCount;t++)
            {
                if (t == source)
                    continue;
                //find max flow between s and t  

                //int maxFlow = Algorithms.EdmondsKarp(flowNetworkGraph, source, t);
                int maxFlow = 0;
                if (maxFlow < minMaxFlow)
                    minMaxFlow = maxFlow;
            }

            resultLabel.Text = minMaxFlow.ToString();
            //resultLabel.Text = "k";

            List<Edge> augmentingPath = Algorithms.BFS(graph, 0, 2);
        }
    }
}
