using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Parser
    {
        /// <summary>
        /// Method is used to parse input file with graph definition.
        /// </summary>
        /// 
        public int Parse(string path, out int[,] edges)
        {
            string[] inputFileLines = null;

            try
            {
                inputFileLines = File.ReadAllLines(path);
            }
            catch (Exception ex)
            {
                throw new IOException(ex.Message);
            }

            // Get number of vertices and number of edges
            int numberOfVertices = int.Parse(inputFileLines[0].Split(' ')[0]);
            int numberOfEdges = int.Parse(inputFileLines[0].Split(' ')[1]);


            // Get all defined edges
            edges = new int[numberOfEdges, 2];
            for (int i = 0; i < numberOfEdges; i++)
            {
               edges[i, 0] = int.Parse(inputFileLines[i + 1].Split(' ')[0]);
               edges[i, 1] = int.Parse(inputFileLines[i + 1].Split(' ')[1]);
            }

            return numberOfVertices;
        }
    }
}
