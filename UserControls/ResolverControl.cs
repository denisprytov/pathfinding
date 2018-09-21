using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PathFindingApp.DataProvider;
using PathFindingApp.DataStructure;
using System.IO;
using DevExpress.CodeParser;
using DevExpress.DataAccess.UI.Native.Sql.QueryBuilder;
using DevExpress.LookAndFeel;
using PathFindingApp.Algorithms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraRichEdit.Import.OpenXml;
using Label = System.Windows.Forms.Label;

namespace PathFindingApp
{
    public partial class ResolverControl : System.Windows.Forms.UserControl
    {
        private string[] data = null;
        private LabirintGraph _dGraph;
        private LabirintGraph _bGraph;
        private LabirintGraph _aGraph;

        public ResolverControl()
        {
            InitializeComponent();
        }

        private void loadButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            string str = string.Empty;
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = ofd.OpenFile();
                    using (var sr = new StreamReader(fileStream))
                    {
                        str = sr.ReadToEnd();
                    }

                    fileStream.Close();
                }
            }

            try
            {
                data = str.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

                _dGraph = GraphParser.ParseGraph(data);
                _bGraph = GraphParser.ParseGraph(data);
                _aGraph = GraphParser.ParseGraph(data);
                AStar.condition = true;
                BreadthFirst.found = false;
                DijkstraAlgorithm.condition = true;

                if (data.Length > 100)
                {
                    speedUp.Enabled = false;
                    speedDown.Enabled = false;
                    dijkstraPanel.Controls.Clear();
                    dijkstraPanel.RowCount = 2;
                    dijkstraPanel.ColumnCount = 1;
                    dijkstraPanel.ColumnStyles.Clear();
                    dijkstraPanel.RowStyles.Clear();
                    dijkstraPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                    dijkstraPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90));
                    dijkstraPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                    dijkstraPanel.Controls.Add(LargeMazePictureBox1);
                    LargeMazeSize1.Text = "Размерность лабиринта:" + data.Length.ToString();
                    dijkstraPanel.Controls.Add(LargeMazeSize1);

                    bFirstPanel.Controls.Clear();
                    bFirstPanel.RowCount = 2;
                    bFirstPanel.ColumnCount = 1;
                    bFirstPanel.ColumnStyles.Clear();
                    bFirstPanel.RowStyles.Clear();
                    bFirstPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                    bFirstPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90));
                    bFirstPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                    bFirstPanel.Controls.Add(LargeMazePictureBox2);
                    LargeMazeSize2.Text = "Размерность лабиринта:" + data.Length.ToString();
                    bFirstPanel.Controls.Add(LargeMazeSize2);

                    aStarPanel.Controls.Clear();
                    aStarPanel.RowCount = 2;
                    aStarPanel.ColumnCount = 1;
                    aStarPanel.ColumnStyles.Clear();
                    aStarPanel.RowStyles.Clear();
                    aStarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                    aStarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90));
                    aStarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                    aStarPanel.Controls.Add(LargeMazePictureBox3);
                    LargeMazeSize3.Text = "Размерность лабиринта:" + data.Length.ToString();
                    aStarPanel.Controls.Add(LargeMazeSize3);
                    return;
                }

                speedUp.Enabled = true;
                speedDown.Enabled = true;
                AStar.speed = 501;
                DijkstraAlgorithm.speed = 1001;
                AStar.speed = 501;
                int rows = data.Length;
                int coloums = data[0].Length;

                //foreach (var control in tableLayoutPanel1.Controls)
                //{
                //    var table = control as TableLayoutPanel;
                //    if (table == null) continue;
                //    foreach (var panel in table.Controls)
                //    {
                //        var p = panel as PanelControl;
                //        if (p == null)
                //            continue;
                //        //foreach (var labelControl in p.Controls)
                //        //{
                //        //    var label = labelControl as System.Windows.Forms.Label;
                //        //    if (label == null) continue;
                //        //    label.Dispose();
                //        //}

                //        //p.Controls.Clear();
                //        p.Dispose();
                //    }
                //}

                dijkstraPanel.Controls.Clear();
                dijkstraPanel.RowCount = rows;
                dijkstraPanel.ColumnCount = coloums;
                dijkstraPanel.ColumnStyles.Clear();
                dijkstraPanel.RowStyles.Clear();
                for (int i = 0; i < coloums; i++)
                {
                    dijkstraPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 100 / coloums));
                }

                for (int i = 0; i < rows; i++)
                {
                    dijkstraPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (float) 100 / coloums));
                }

                for (int i = 0; i < dijkstraPanel.ColumnCount; i++)
                for (int j = 0; j < dijkstraPanel.RowCount; j++)
                {
                    PanelControl p = new PanelControl
                    {
                        BorderStyle = BorderStyles.UltraFlat,
                        LookAndFeel =
                        {
                            UseDefaultLookAndFeel = false,
                            Style = LookAndFeelStyle.Office2003

                        },
                        Dock = DockStyle.Fill,
                        Margin = Padding.Empty

                    };
                    if (data.Length < 25)
                    {
                        p.Controls.Add(new System.Windows.Forms.Label
                        {
                            Text = "",
                            AutoSize = true,
                            Dock = DockStyle.Fill,
                            Size = SizeFromClientSize(Parent.Size),
                            Font = new Font("Times New Roman", 14)
                        });
                    }

                    dijkstraPanel.Controls.Add(p);
                }

                GraphParser.ParsePanel(data, dijkstraPanel);

                bFirstPanel.Controls.Clear();
                bFirstPanel.RowCount = rows;
                bFirstPanel.ColumnCount = coloums;
                bFirstPanel.ColumnStyles.Clear();
                bFirstPanel.RowStyles.Clear();
                for (int i = 0; i < coloums; i++)
                {
                    bFirstPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 100 / coloums));
                }

                for (int i = 0; i < rows; i++)
                {
                    bFirstPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (float) 100 / coloums));
                }

                for (int i = 0; i < bFirstPanel.ColumnCount; i++)
                for (int j = 0; j < bFirstPanel.RowCount; j++)
                {
                    PanelControl p = new PanelControl
                    {
                        BorderStyle = BorderStyles.UltraFlat,
                        LookAndFeel =
                        {
                            UseDefaultLookAndFeel = false,
                            Style = LookAndFeelStyle.Office2003

                        },
                        Dock = DockStyle.Fill,
                        Margin = Padding.Empty

                    };
                    if (data.Length < 25)
                    {
                        p.Controls.Add(new System.Windows.Forms.Label
                        {
                            Text = "",
                            AutoSize = true,
                            Dock = DockStyle.Fill,
                            Size = SizeFromClientSize(Parent.Size),
                            Font = new Font("Times New Roman", 14)
                        });
                    }

                    bFirstPanel.Controls.Add(p);
                }

                GraphParser.ParsePanel(data, bFirstPanel);


                aStarPanel.Controls.Clear();
                aStarPanel.RowCount = rows;
                aStarPanel.ColumnCount = coloums;
                aStarPanel.ColumnStyles.Clear();
                aStarPanel.RowStyles.Clear();
                for (int i = 0; i < coloums; i++)
                {
                    aStarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 100 / coloums));
                }

                for (int i = 0; i < rows; i++)
                {
                    aStarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (float) 100 / coloums));
                }

                for (int i = 0; i < aStarPanel.ColumnCount; i++)
                for (int j = 0; j < aStarPanel.RowCount; j++)
                {
                    PanelControl p = new PanelControl
                    {
                        BorderStyle = BorderStyles.UltraFlat,
                        LookAndFeel =
                        {
                            UseDefaultLookAndFeel = false,
                            Style = LookAndFeelStyle.Office2003

                        },
                        Dock = DockStyle.Fill,
                        Margin = Padding.Empty

                    };
                    if (data.Length < 25)
                    {
                        p.Controls.Add(new System.Windows.Forms.Label
                        {
                            Text = "",
                            AutoSize = true,
                            Dock = DockStyle.Fill,
                            Size = SizeFromClientSize(Parent.Size),
                            Font = new Font("Times New Roman", 14)

                        });
                    }

                    aStarPanel.Controls.Add(p);
                }

                GraphParser.ParsePanel(data, aStarPanel);

                if (allAlgsButton.Down)
                {
                    allAlgsButton.PerformClick();
                }

                if (bfsButton.Down)
                {
                    bfsButton.PerformClick();
                }

                if (astarButton.Down)
                {
                    astarButton.PerformClick();
                }

                if (dijkstraButton.Down)
                {
                    dijkstraButton.PerformClick();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void dijkstraButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            astarButton.Down = false;
            bfsButton.Down = false;
            allAlgsButton.Down = false;
            try
            {
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowCount = 4;
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.Controls.Add(labelControlDijkstra);

                tableLayoutPanel1.Controls.Add(dijkstraPanel);

                tableLayoutPanel1.Controls.Add(flowLayoutPanelDijFirst);
                tableLayoutPanel1.Controls.Add(flowLayoutPanelDijBest);
            }

            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }



        private void bfsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            astarButton.Down = false;
            dijkstraButton.Down = false;
            allAlgsButton.Down = false;

            try
            {
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowCount = 4;
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.Controls.Add(labelControlBfs);
                tableLayoutPanel1.SetCellPosition(labelControlBfs, new TableLayoutPanelCellPosition(1, 0));

                tableLayoutPanel1.Controls.Add(bFirstPanel);
                tableLayoutPanel1.SetCellPosition(bFirstPanel, new TableLayoutPanelCellPosition(1, 1));

                tableLayoutPanel1.Controls.Add(flowLayoutPanelBfsFirst);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelBfsFirst, new TableLayoutPanelCellPosition(1, 2));
                tableLayoutPanel1.Controls.Add(flowLayoutPanelBfsBest);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelBfsBest, new TableLayoutPanelCellPosition(1, 3));
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private void astarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            bfsButton.Down = false;
            dijkstraButton.Down = false;
            allAlgsButton.Down = false;
            try
            {
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowCount = 4;
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4));
                tableLayoutPanel1.Controls.Add(labelControlAstar);
                tableLayoutPanel1.SetCellPosition(labelControlAstar, new TableLayoutPanelCellPosition(1, 0));

                tableLayoutPanel1.Controls.Add(aStarPanel);
                tableLayoutPanel1.SetCellPosition(aStarPanel, new TableLayoutPanelCellPosition(1, 1));

                tableLayoutPanel1.Controls.Add(flowLayoutPanelAstarFirst);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelAstarFirst, new TableLayoutPanelCellPosition(1, 2));
                tableLayoutPanel1.Controls.Add(flowLayoutPanelAstarBest);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelAstarBest, new TableLayoutPanelCellPosition(1, 3));
            }

            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private void allAlgsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            bfsButton.Down = false;
            dijkstraButton.Down = false;
            astarButton.Down = false;

            try
            {
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowCount = 4;
                tableLayoutPanel1.ColumnCount = 7;
                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 0.5));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 32.5));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 0.75));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 32.5));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 0.75));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 32.5));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) 0.5));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                tableLayoutPanel1.Controls.Add(labelControlDijkstra);
                tableLayoutPanel1.SetCellPosition(labelControlDijkstra, new TableLayoutPanelCellPosition(1, 0));
                tableLayoutPanel1.Controls.Add(labelControlBfs);
                tableLayoutPanel1.SetCellPosition(labelControlBfs, new TableLayoutPanelCellPosition(3, 0));
                tableLayoutPanel1.Controls.Add(labelControlAstar);
                tableLayoutPanel1.SetCellPosition(labelControlAstar, new TableLayoutPanelCellPosition(5, 0));

                tableLayoutPanel1.Controls.Add(dijkstraPanel);
                tableLayoutPanel1.SetCellPosition(dijkstraPanel, new TableLayoutPanelCellPosition(1, 1));
                tableLayoutPanel1.Controls.Add(bFirstPanel);
                tableLayoutPanel1.SetCellPosition(bFirstPanel, new TableLayoutPanelCellPosition(3, 1));
                tableLayoutPanel1.Controls.Add(aStarPanel);
                tableLayoutPanel1.SetCellPosition(aStarPanel, new TableLayoutPanelCellPosition(5, 1));

                tableLayoutPanel1.Controls.Add(flowLayoutPanelDijFirst);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelDijFirst, new TableLayoutPanelCellPosition(1, 2));
                tableLayoutPanel1.Controls.Add(flowLayoutPanelBfsFirst);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelBfsFirst, new TableLayoutPanelCellPosition(3, 2));
                tableLayoutPanel1.Controls.Add(flowLayoutPanelAstarFirst);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelAstarFirst, new TableLayoutPanelCellPosition(5, 2));

                tableLayoutPanel1.Controls.Add(flowLayoutPanelDijBest);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelDijBest, new TableLayoutPanelCellPosition(1, 3));
                tableLayoutPanel1.Controls.Add(flowLayoutPanelBfsBest);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelBfsBest, new TableLayoutPanelCellPosition(3, 3));
                tableLayoutPanel1.Controls.Add(flowLayoutPanelAstarBest);
                tableLayoutPanel1.SetCellPosition(flowLayoutPanelAstarBest, new TableLayoutPanelCellPosition(5, 3));
            }

            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private void speedUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (AStar.speed > 10)
            {
                AStar.speed -= 10;
                BreadthFirst.speed -= 10;
                DijkstraAlgorithm.speed -= 10;
            }
        }

        private void speedDown_ItemClick(object sender, ItemClickEventArgs e)
        {
            AStar.speed += 100;
            BreadthFirst.speed += 100;
            BreadthFirst.speed += 100;
        }

        private void pauseButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            AStar.wait = true;
            BreadthFirst.wait = true;
            DijkstraAlgorithm.wait = true;
        }

        private void resumeButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            AStar.wait = false;
            BreadthFirst.wait = false;
            DijkstraAlgorithm.wait = false;
        }

        private void stopButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            AStar.condition = false;
            BreadthFirst.found = true;
            DijkstraAlgorithm.condition = false;
        }

        private void RunBuntton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_dGraph == null) //|| _dGraph.Vertices.Any(v => v.Visited))
            {
                MessageBox.Show("Загрузите новый лабиринт!", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            //запускаем параллельно все наши алгоритмы
            if (dijkstraButton.Down)
            {
                Task.Run(() => DijkstraAlgorithm.Execute(_dGraph, dijkstraPanel, dijkstraFirst, dijkstraBest));
                return;
            }

            if (bfsButton.Down )
            {
                Task.Run(() => BreadthFirst.Execute(_bGraph, bFirstPanel, bfFirst, bfBest));
                return;
            }

            if (astarButton.Down)
            {
                Task.Run(() => AStar.Execute(_aGraph, aStarPanel, asFirst, asBest));
                return;
            }
            Task.Run(() => DijkstraAlgorithm.Execute(_dGraph, dijkstraPanel, dijkstraFirst, dijkstraBest));
            Task.Run(() => BreadthFirst.Execute(_bGraph, bFirstPanel, bfFirst, bfBest));
            Task.Run(() => AStar.Execute(_aGraph, aStarPanel, asFirst, asBest));
        }

        private void speedEditor_EditValueChanged(object sender, EventArgs e)
        {
            AStar.speed = (int)speedEditor.EditValue;
            DijkstraAlgorithm.speed = (int)speedEditor.EditValue;
            BreadthFirst.speed = (int)speedEditor.EditValue;
        }
    }
}
