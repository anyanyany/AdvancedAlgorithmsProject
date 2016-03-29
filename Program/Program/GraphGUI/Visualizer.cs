using Program.GraphLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.GraphGUI
{
    /// <summary>
    /// Draws graph using Fruchterman-Reingold algorithm taken from: http://arxiv.org/pdf/1201.3011v1.pdf
    /// </summary>
    public class Visualizer
    {
        private const int ITERATIONS = 1000; // TODO: Change
        private double kValue, temperature;
        private List<Edge> graphEdges;

        private struct Position
        {
            public double x, y;
            public double dx, dy;
        }

        public void DrawGraph(PictureBox pictureBox, IGraph graph)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                Position[] vertices = FruchtermanReingold(graph, bitmap);
                foreach (Position p in vertices)
                    g.FillEllipse(Brushes.Red, (float)(p.x - 2.5), (float)(p.y - 2.5), 5, 5);
                foreach (Edge e in graphEdges)
                    g.DrawLine(Pens.Black, new Point((int)vertices[e.From].x, (int)vertices[e.From].y), 
                        new Point((int)vertices[e.To].x, (int)vertices[e.To].y));
            }

            pictureBox.Image = bitmap;
        }

        private Position[] FruchtermanReingold(IGraph graph, Bitmap image)
        {
            int height = image.Height, width = image.Width;
            int area = height * width;
            kValue = Math.Sqrt(area / graph.VerticesCount);
            temperature = (double)width / 10.0;
            Position[] vertices = initializePositions(width, height, graph);
            graphEdges = graph.GetEdges();

            for (int i = 0; i < ITERATIONS; i++)
            {
                calculateVertexDisplacement(ref vertices);
                calculateEdgeDisplacement(ref vertices);
                moveVertices(ref vertices, width, height);
                temperature -= (((double)width/10.0) / ITERATIONS);
            }

            return vertices;
        }

        private double fa(double value)
        {
            return value * value / kValue;
        }

        private double fr(double value)
        {
            return kValue * kValue / value;
        }

        private Position[] initializePositions(int width, int height, IGraph graph)
        {
            Position[] vertices = new Position[graph.VerticesCount];
            Random r = new Random();

            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].x = (double)(r.Next() % width);
                vertices[i].y = (double)(r.Next() % height);
                vertices[i].dx = vertices[i].dy = 0;
            }

            return vertices;
        }

        private void calculateVertexDisplacement(ref Position[] vertices)
        {
            Random r = new Random();
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].dx = vertices[i].dy = 0;
                for (int j = 0; j < vertices.Length; j++)
                    if (i != j)
                    {
                        double ddx = vertices[i].x - vertices[j].x;
                        double ddy = vertices[i].y - vertices[j].y;
                        if (Math.Abs(ddx) > 100.0 || Math.Abs(ddy) > 100.0) continue;
                        if (ddx == 0) ddx = (r.Next() % 2 == 0 ? 1 : -1) * 1e-6;
                        if (ddy == 0) ddy = (r.Next() % 2 == 0 ? 1 : -1) * 1e-6;
                        vertices[i].dx += Math.Sign(ddx) * fr(Math.Abs(ddx));
                        vertices[i].dy += Math.Sign(ddy) * fr(Math.Abs(ddy));
                    }
            }
        }

        private void calculateEdgeDisplacement(ref Position[] vertices)
        {
            Random r = new Random();
            foreach (Edge e in graphEdges)
            {
                int i = e.From, j = e.To;

                double ddx = vertices[i].x - vertices[j].x;
                double ddy = vertices[i].y - vertices[j].y;
                if (ddx == 0) ddx = (r.Next() % 2 == 0 ? 1 : -1) * 1e-6;
                if (ddy == 0) ddy = (r.Next() % 2 == 0 ? 1 : -1) * 1e-6;
                vertices[i].dx -= Math.Sign(ddx) * fa(Math.Abs(ddx));
                vertices[i].dy -= Math.Sign(ddy) * fa(Math.Abs(ddy));
                vertices[j].dx += Math.Sign(ddx) * fa(Math.Abs(ddx));
                vertices[j].dy += Math.Sign(ddy) * fa(Math.Abs(ddy));
            }
        }

        private void moveVertices(ref Position[] vertices, int width, int height)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].x += Math.Sign(vertices[i].dx) * Math.Min(Math.Abs(vertices[i].dx), temperature);
                vertices[i].y += Math.Sign(vertices[i].dy) * Math.Min(Math.Abs(vertices[i].dy), temperature);
                vertices[i].x = Math.Min((double)width - 1, Math.Max(0, vertices[i].x));
                vertices[i].y = Math.Min((double)height - 1, Math.Max(0, vertices[i].y));
            }
        }
    }
}
