using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PathFindingApp.DataProvider;
using PathFindingApp.DataStructure;
using PathFindingApp.test;

namespace PathFindingApp.Algorithms
{
    static class BreadthFirst
    {
        public static Algorithm Type => Algorithm.BreadthFirst;
        public static int speed;
        public static bool wait = false;
        public static bool found = false;
        private static int index;
        public static int maxSize = 100;
        public static ChartData dataFirst = new ChartData();
        public static ChartData dataBest = new ChartData();
        public static void Execute(LabirintGraph graph, TableLayoutPanel panel = null, LabelControl first = null,
            LabelControl best = null)
        {
            var iterations = 0;
            var queue = new Queue<LabirintVertex>();
            queue.Enqueue(graph.Start);
            while (queue.Count > 0 && !found)
            {
                var curr = queue.Dequeue();
                curr.Visited = true;
                var elems = curr.Neighbours.FindAll(v => !v.Visited);
                foreach (var elem in elems)
                {
                    if (!queue.Contains(elem))
                    {
                        queue.Enqueue(elem);
                        if (graph.Size < maxSize)
                        {
                            index = graph.Vertices.IndexOf(elem);
                            if (elem != graph.Finish && panel != null)
                            {
                                panel.Controls[index].BackColor = GraphParser.Colors[5];

                            }
                        }

                        elem.Parent = curr;
                    }
                }

                if (queue.Contains(graph.Finish))
                {
                    found = true;
                }

                if (panel == null || curr.NodeType != CellTypes.Empty) continue;

                iterations++;

                if (first != null) //&& !found)
                {
                    dataFirst.Data = iterations;
                    first.Invoke((MethodInvoker) delegate { first.Text = iterations.ToString(); });
                }

                best?.Invoke((MethodInvoker) delegate { best.Text = iterations.ToString(); });
                if (graph.Size < maxSize)
                {
                    panel.Controls[graph.Vertices.IndexOf(curr)].BackColor = GraphParser.Colors[4];
                }

                if (graph.Size < maxSize)
                {
                    Thread.Sleep(speed);
                }

                while (wait) ;
            }

            dataBest.Data = iterations;
            dataBest.Algo = "BreadthFirst";
            dataFirst.Algo = "BreadthFirst";
            dataBest.Type = "Best";
            dataFirst.Type = "First";

            if (graph.Size > maxSize)
            {
                return;
            }

            var built = false;
            var steps = 1;
            var current = graph.Finish;
            while (!built)
            {
                if (panel == null) continue;
                if (current.Parent == graph.Start)
                {
                    built = true;
                    continue;
                }

                panel.Controls[graph.Vertices.IndexOf(current.Parent)].BackColor = Color.RoyalBlue;
                current = current.Parent;
                steps++;
            }

            if (graph.Size < 25)
            {
                built = false;
                current = graph.Finish;
                while (!built)
                {
                    if (current == graph.Start)
                    {
                        built = true;
                        continue;
                    }

                    panel.Controls[graph.Vertices.IndexOf(current)].Controls[0].Invoke((MethodInvoker) delegate
                    {
                        panel.Controls[graph.Vertices.IndexOf(current)].Controls[0].Text = steps.ToString();
                    });
                    steps--;
                    if (current == graph.Start)
                    {
                        built = true;
                        continue;
                    }

                    current = current.Parent;
                }
            }
        }
    }
}

