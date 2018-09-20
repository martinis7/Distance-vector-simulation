using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DistanceVector
{
    public partial class DistanceVectorForm : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        List<Router> routers = new List<Router>();
        List<Link> links = new List<Link>();
        public const int Infinity = int.MaxValue;

        public DistanceVectorForm()
        {
            InitializeComponent();
        }

        private void btn_CreateRouter_Click(object sender, EventArgs e)
        {
            routers.Add(new Router());
            UpdateComboBoxes();
        }

        private void UpdateComboBoxes()
        {
            box_RouterOne.Items.Clear();
            box_RouterTwo.Items.Clear();

            foreach (var id in routers)
            {
                box_RouterOne.Items.Add(id.Id);
                box_RouterTwo.Items.Add(id.Id);
            }
        }

        private void btn_addNode_Click(object sender, EventArgs e)
        {
            bool condition = true;
            int vertexValue = -1;

            // reset color if previously changed
            box_RouterOne.BackColor = Color.White;
            box_RouterTwo.BackColor = Color.White;
            txt_VertexValue.BackColor = Color.White;

            if (box_RouterOne.SelectedItem == null)
            {
                box_RouterOne.BackColor = Color.Red;
                condition = false;
            }
            if (box_RouterTwo.SelectedItem == null)
            {
                box_RouterTwo.BackColor = Color.Red;
                condition = false;
            }
            if (box_RouterOne.SelectedItem != null && box_RouterOne.SelectedItem.Equals(box_RouterTwo.SelectedItem))
            {
                box_RouterOne.BackColor = Color.Red;
                box_RouterTwo.BackColor = Color.Red;
                condition = false;
            }
            if (string.IsNullOrWhiteSpace(txt_VertexValue.Text) || !int.TryParse(txt_VertexValue.Text, out vertexValue) || Convert.ToInt32(txt_VertexValue.Text) < 0)
            {
                txt_VertexValue.BackColor = Color.Red;
                condition = false;
            }

            if (condition)
            {
                // check if vertex already exists (if yes do nothing, if no create new vertex and add to list)
                int id1 = (int) box_RouterOne.SelectedItem;
                int id2 = (int) box_RouterTwo.SelectedItem;
                int x;
                if (!IsVertexBetweenTwoNodes(id1, id2, out x))
                {
                    links.Add(new Link(id1,id2, vertexValue));
                }
            }            
        }

        bool IsVertexBetweenTwoNodes(int id1, int id2, out int value)
        {
            value = 0;
            foreach (var vertex in links)
            {
                if ((vertex.nodeOne == id1 && vertex.nodeTwo == id2) || (vertex.nodeOne == id2 && vertex.nodeTwo == id1))
                {
                    value = vertex.value;
                    return true;
                }
            }
            return false;
        }

        private void btn_RunSimulation_Click(object sender, EventArgs e)
        {
            AllocConsole();
            foreach (var router in routers)
            {
                int[] nexthop;
                List<Router> neighbors;
                int[,] matrix = GenerateNewMatrix(router.Id, out nexthop, out neighbors);
                //PrintMatrix(matrix);
                router.Vector = matrix;
                router.NextHop = nexthop;
                router.Neighbors = neighbors;
            }
            // Enable all simulation buttons
            btn_PrintRouters.Visible = true;
            btn_PrintRouters.Enabled = true;

            RunSimulation();
        }

        // FOR DEBUGING ONLY
/*
        private void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
*/

        private void RunSimulation()
        {
            foreach (var router in routers)
            {
                router.InitializeBeforeStart();
            }
            
            for (int i = 0; i < routers.Count; i++)
            {
                routers[i].Run();
            }
        }

        int[,] GenerateNewMatrix(int id, out int[] hop, out List<Router> neighbors)
        {
            int n = routers.Count;
            //int m = links.Count(x => x.nodeOne == id || x.nodeTwo == id);
            // kadangi reikia ir savo vektoriu laikyt tai m++
            //m++;
            int[,] vectorTable = new int[n,n];
            hop = new int[n];
            neighbors = new List<Router>();
            int value;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == id)
                    {
                        if (j == id)
                        {
                            vectorTable[i, j] = 0;
                            hop[j] = -1;
                        }
                        else
                        {
                            if (IsVertexBetweenTwoNodes(id, j, out value))
                            {
                                vectorTable[i, j] = value;
                                hop[j] = j;
                                neighbors.Add(routers.Find(x => x.Id == j));
                            }
                            else
                            {
                                vectorTable[i, j] = Infinity;
                                hop[j] = -2;
                            }
                        }
                    }
                    else
                    {
                        vectorTable[i, j] = Infinity;
                    }
                }
            }
            return vectorTable;
        }

        private void btn_PrintRouters_Click(object sender, EventArgs e)
        {
            int n = routers.Count;
            foreach (var router in routers)
            {
                Console.WriteLine(@"Router: " + router.Id);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(router.Vector[i, j] + " ");
                    }
                    Console.WriteLine();
                }            
                Console.WriteLine(@"This router next hops:");
                foreach (var hop in router.NextHop)
                {
                    Console.Write(hop + " ");
                }
                Console.WriteLine("\nThis router neighbors:");
                foreach (var neighbor in router.Neighbors)
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine("\n------------------");
            }
        }
    }
}
