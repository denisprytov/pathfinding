using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PathFindingApp.DataStructure;
using MoreLinq;
using PathFindingApp.DataProvider;
using System.Threading;
using PathFindingApp.test;

namespace PathFindingApp.Algorithms
{
    static class DijkstraAlgorithm
    {
        public static Algorithm Type => Algorithm.Dijkstra;
        public static int speed;
        public static bool wait = false;
        public static bool condition = true;
        private static int index;
        public static int maxSize = 100;
        public static ChartData dataFirst = new ChartData();
        public static ChartData dataBest = new ChartData();
        public static void Execute(LabirintGraph graph, TableLayoutPanel panel = null, LabelControl first = null,
            LabelControl best = null)
        {
            var found = false;
            graph.Start.Mark = 0;
            if (graph.Size < 25)
            {
                index = graph.Vertices.IndexOf(graph.Start);
                panel.Controls[index].Controls[0].Invoke((MethodInvoker) delegate
                {
                    panel.Controls[index].Controls[0].Text = "0";
                });
            }

            var iterations = 0;
            while (!graph.Vertices.TrueForAll(v => v.Visited) && condition)
            {
                var query = from vertex in graph.Vertices
                    where !vertex.Visited
                    select vertex;
                var curr = query.MinBy(s => s.Mark);
                if (curr.Mark > int.MaxValue - 100000) break;
                foreach (var v in curr.Neighbours)
                {
                    if (v.Visited) continue;
                    if (v.Mark > curr.Mark + 1)
                    {
                        v.Mark = curr.Mark + 1;

                        if (graph.Size < maxSize)
                        {
                            index = graph.Vertices.IndexOf(v);
                            if (graph.Size < 25)
                            {
                                panel.Controls[index].Controls[0].Invoke((MethodInvoker) delegate
                                {
                                    panel.Controls[index].Controls[0].Text = v.Mark.ToString();
                                });
                            }

                            if (v != graph.Finish)
                            {
                                panel.Controls[index].BackColor = GraphParser.Colors[5];

                            }
                        }


                        v.Parent = curr;
                    }

                    if (v == graph.Finish)
                    {
                        found = true;
                    }
                }
                curr.Visited = true;
                if (curr == graph.Finish)
                    condition = false;

                if (panel == null || curr.NodeType != CellTypes.Empty) continue;
                iterations++;
                if (graph.Size < maxSize)
                {
                    panel.Controls[graph.Vertices.IndexOf(curr)].BackColor = GraphParser.Colors[4];
                }

                if (first != null && !found)
                {
                    dataFirst.Data = iterations;
                    first.Invoke((MethodInvoker) delegate { first.Text = iterations.ToString(); });
                }

                best?.Invoke((MethodInvoker) delegate { best.Text = iterations.ToString(); });
                if (graph.Size < maxSize)
                {
                    Thread.Sleep(speed);
                }

                while (wait) ;
            }

            dataBest.Data = iterations;
            dataBest.Algo = "Dijkstra";
            dataFirst.Algo = "Dijkstra";
            dataBest.Type = "Best";
            dataFirst.Type = "First";

            if (graph.Size > maxSize)
            {
                return;
            }

            var built = false;
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
            }

        }
    }
}
