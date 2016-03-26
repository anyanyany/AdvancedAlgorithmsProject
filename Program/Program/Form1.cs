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

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uploadGraphButton_Click(object sender, EventArgs e)
        {
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
                    //graph = null;
                    return;
                }

                //Console.WriteLine(numberOfVertices);
                //Console.WriteLine(edges.Length);
                //graph construction

            }
        }
    }
}
