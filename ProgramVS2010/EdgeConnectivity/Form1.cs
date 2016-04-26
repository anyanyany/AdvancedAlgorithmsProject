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
using Program.GraphGUI;

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
            clearAllAndCreateNewGraph(true);

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
                int numOfVertices = 0;
                int[,] edges = null;

                try
                {
                    numOfVertices = new Parser().Parse(filename, out edges);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong file format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    graph = null;
                    return;
                }

                //graph construction
                graph = new MatrixGraph((uint)numOfVertices);
                numberOfVertices.Value = numOfVertices;
                for (int i = 0; i < edges.GetLength(0); i++)
                {
                    graph.AddEdge(new Edge(edges[i, 0], edges[i, 1]));
                    listOfEgdes.Items.Add("" + edges[i, 0].ToString() + "<------>" + edges[i, 1].ToString());
                }
            }
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "?";

            if (graph == null)
            {
                MessageBox.Show("There is no graph!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            resultLabel.Text = Algorithms.ChceckConnectivity(graph).ToString();           
        }

        private void deleteEdgeButton_Click(object sender, EventArgs e)
        {
            if (listOfEgdes.SelectedIndex >= 0)
            {
                string selectedEdge = listOfEgdes.SelectedItem.ToString();
                listOfEgdes.Items.RemoveAt(listOfEgdes.SelectedIndex);
                int index = selectedEdge.IndexOf("<");
                string eFrom = selectedEdge.Substring(0, index);
                index = selectedEdge.IndexOf(">");
                string eTo = selectedEdge.Substring(index+1);
                graph.DeleteEdge(Int32.Parse(eFrom), Int32.Parse(eTo));
            }
        }

        private void numberOfVerticesValueChanged(object sender, EventArgs e)
        {
            clearAllAndCreateNewGraph(false);
            int noOfVertices = (int)numberOfVertices.Value;
            edgeFrom.Maximum = noOfVertices - 1;
            edgeTo.Maximum = noOfVertices - 1;
        }

        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            if (edgeFrom.Value == edgeTo.Value)
                return;
            string newItem = edgeFrom.Value.ToString() + "<------>" + edgeTo.Value.ToString();
            string reverseItem = edgeTo.Value.ToString() + "<------>" + edgeFrom.Value.ToString();
            if (!listOfEgdes.Items.Contains(newItem) && !listOfEgdes.Items.Contains(reverseItem))
            {
                listOfEgdes.Items.Add(newItem);
                if(graph==null)
                    graph=new MatrixGraph((uint)numberOfVertices.Value);
                graph.AddEdge(new Edge((int)edgeFrom.Value, (int)edgeTo.Value));
            }
        }

        private void clearAllAndCreateNewGraph(bool graphUploaded)
        {
            graph = null;
            if (!graphUploaded)
                graph = new MatrixGraph((uint)numberOfVertices.Value);
            listOfEgdes.Items.Clear();
            resultLabel.Text = "?";
            graphImage.Image = null;
        }

        private void showGraphButton_Click(object sender, EventArgs e)
        {
            if (graph == null)
            {
                MessageBox.Show("There is no graph!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Visualizer v = new Visualizer();
            v.DrawGraph(graphImage, graph);
        }
    }
}
