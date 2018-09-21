using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGauges.Core.Styles;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraScheduler;
using PathFindingApp.DataProvider;
using DevExpress.XtraToolbox;

namespace PathFindingApp.UserControls
{
    public partial class LabirinthEditor : XtraUserControl
    {
        private CellTypes _currntMode;
        private bool isDown = false;
        private bool visualization = true;
        public LabirinthEditor()
        {
            InitializeComponent();
            RepositoryItemComboBox resizeCo = new RepositoryItemComboBox();
            for (int i = 5; i < 51; i++)
            {
                resizeCo.Items.Add(i);
            }

            resizeBar.Edit = resizeCo;
            for (int i = 0; i < toolboxControl1.Groups[0].Items.Count; i++)
            {
                Image resultImage = new Bitmap(20, 20);
                using (Graphics gr = Graphics.FromImage(resultImage))
                {
                    Brush br = new SolidBrush(GraphParser.Colors[i]);
                    gr.FillRectangle(br, 0, 0, 20, 20);
                }

                toolboxControl1.Groups[0].Items[i].ImageOptions.Image = resultImage;
            }

            toolboxControl1.ItemClick += NewCellMode;
            resizeBar.EditValue = "5";
            InitTable(5, 5);
        }

        private void NewCellMode(object sender, ToolboxItemClickEventArgs e)
        {
            switch (e.Item.Caption)
            {
                case "Старт":
                {
                    _currntMode = CellTypes.Start;
                    break;
                }
                case "Финиш":
                {
                    _currntMode = CellTypes.Finish;
                    break;
                }
                case "Блок":
                {
                    _currntMode = CellTypes.Block;
                    break;
                }
                default:
                {
                    _currntMode = CellTypes.Empty;
                    break;
                }
            }

        }

        private void openFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var str = "";
            //находим файл через диалог, читаем текст
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
            //разбиваем текст по строкам

            var data = str.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            if (data.Length > 50)
            {
                MessageBox.Show("Слишком большой лабиринт для редактирования!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
               return;
            }
            InitTable(data.Length, data[0].Length);

            GraphParser.ParsePanel(data, tableLayoutPanel2);
        }

        private void InitTable(int rows, int columns)
        {
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.RowCount = rows;
            tableLayoutPanel2.ColumnCount = columns;
            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();
            for (var i = 0; i < columns; i++)
            {
                tableLayoutPanel2.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, (float) 100 / columns));
            }

            for (var i = 0; i < rows; i++)
            {
                tableLayoutPanel2.RowStyles.Add(
                    new RowStyle(SizeType.Percent, (float) 100 / rows));
            }

            for (var i = 0; i < tableLayoutPanel2.ColumnCount; i++)
            for (var j = 0; j < tableLayoutPanel2.RowCount; j++)
            {
                tableLayoutPanel2.Controls.Add(new PanelControl
                {
                    BackColor = Color.White,
                    BorderStyle = BorderStyles.Office2003,
                    Tag = CellTypes.Empty,
                    LookAndFeel = {UseDefaultLookAndFeel = false, Style = LookAndFeelStyle.Flat},
                    Margin = Padding.Empty,
                    Dock = DockStyle.Fill
                });
            }

            foreach (PanelControl control in tableLayoutPanel2.Controls)
            {
                control.Click += CellClick;
                control.MouseMove += CellMove;
            }
        }

        private void CellMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDown = true;
            }

            if (e.Button != MouseButtons.Left)
            {
                isDown = false;
            }

            if (isDown)
            {
                var panel = (PanelControl) sender;
                switch (_currntMode)
                {
                    case CellTypes.Empty:
                        break;
                    case CellTypes.Block:
                        break;
                    case CellTypes.Start:
                    case CellTypes.Finish:
                    {
                        foreach (PanelControl control in tableLayoutPanel2.Controls)
                        {
                            if ((CellTypes) control.Tag != _currntMode) continue;
                            control.Tag = CellTypes.Empty;
                            control.BackColor = GraphParser.Colors[0];
                            break;
                        }

                        break;
                    }

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                panel.Tag = _currntMode;
                panel.BackColor = GraphParser.Colors[(int) _currntMode];

            }
        }

        private void CellClick(object sender, EventArgs eventArgs)
        {
            var panel = (PanelControl) sender;
            switch (_currntMode)
            {
                case CellTypes.Empty:
                    break;
                case CellTypes.Block:
                    break;
                case CellTypes.Start:
                case CellTypes.Finish:
                {
                    foreach (PanelControl control in tableLayoutPanel2.Controls)
                    {
                        if ((CellTypes) control.Tag != _currntMode) continue;
                        control.Tag = CellTypes.Empty;
                        control.BackColor = GraphParser.Colors[0];
                        break;
                    }

                    break;
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }

            panel.Tag = _currntMode;
            panel.BackColor = GraphParser.Colors[(int) _currntMode];
        }

        private void clearTable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (visualization == false)
            {
                MessageBox.Show("Доступно только редактирование через .txt файл!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Очистить лабиринт?", "Очистка", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (PanelControl panel in tableLayoutPanel2.Controls)
                {
                    panel.BackColor = GraphParser.Colors[0];
                    panel.Tag = CellTypes.Empty;
                }
            }
        }

        private void saveFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string s = "";
            if (visualization == false)
            {
                s += 2;
                string tmp = tableLayoutPanel2.Controls[0].Controls[1].Text;
                if (MessageBox.Show(
                        "Внимание! Вы сохраняете пустой лабиринт размерности " + tmp +
                        ", его прототип представлен на картинке", "Режим выключенной визуализации!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int size = int.Parse(tmp);
                    string str1 = new string('0', size - 1);
                    s += str1;
                    s += "\r\n";
                    string str2 = new string('0', size);
                    for (var i = 0; i < size - 2; i++)
                    {

                        s += str2;
                        s += "\r\n";
                    }

                    s += str1;
                    s += 3;
                    s += "\r\n";
                }
                else
                {
                    return;
                }
            }

            if (visualization)
            {
                var intView = new int[tableLayoutPanel2.RowCount, tableLayoutPanel2.ColumnCount];
                //перегоняем табличный контрол в двумерный массив чисел на основе enum CellTypes
                foreach (Control control in tableLayoutPanel2.Controls)
                {
                    var pos = tableLayoutPanel2.GetPositionFromControl(control);
                    var row = pos.Row;
                    var col = pos.Column;
                    var cellType = (CellTypes) control.Tag;
                    intView[row, col] = (int) cellType;
                }

                //перегон массива в строку с переносами

                for (var i = 0; i < tableLayoutPanel2.RowCount; i++)
                {
                    for (var j = 0; j < tableLayoutPanel2.ColumnCount; j++)
                    {
                        s += intView[i, j];
                    }

                    s += "\r\n";
                }
            }

            //файловый диалог и сохранение
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, s);
                }
            }
        }

        private void resizeBar_EditValueChanged(object sender, EventArgs e)
        {
            BarEditItem size = (BarEditItem) sender;
            int tmp = int.Parse(size.EditValue.ToString());
            if (tmp > 150)
            {
                InitLargeTable(2, 3);
                visualBar.Checked = true;
                visualization = false;
                return;
            }

            InitTable(tmp, tmp);
            visualBar.Checked = false;
            visualization = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (visualization == false)
            {
                MessageBox.Show("Визуализация выключена!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var str = "";
            //находим файл через диалог, читаем текст

            Stream fileStream =
                new FileStream(@"C:\Users\Denis\source\repos\PathFindingApp\PathFindingApp\29x29Maze.txt",
                    FileMode.Open);
            using (var sr = new StreamReader(fileStream))
            {
                str = sr.ReadToEnd();
            }

            fileStream.Close();
            var data = str.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            InitTable(data.Length, data[0].Length);

            GraphParser.ParsePanel(data, tableLayoutPanel2);
            backstageViewControl1.Close();
        }

        private void backstageViewButtonItem2_ItemClick(object sender,
            DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            string s = new string('2',1);
            if (visualization == false)
            {
                backstageViewControl1.Close();
                string tmp = tableLayoutPanel2.Controls[0].Controls[1].Text;
                if (MessageBox.Show(
                        "Внимание! Вы сохраняете пустой лабиринт размерности " + tmp +
                        ", его прототип представлен на картинке", "Режим выключенной визуализации!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int size = int.Parse(tmp);
                    string str1 = new string('0', size - 1);
                    s += str1;
                    s += "\r\n";
                    string str2 = new string('0', size);
                    for (var i = 0; i < size - 2; i++)
                    {

                        s += str2;
                        s += "\r\n";
                    }

                    s += str1;
                    s += 3;
                    s += "\r\n";
                }
                else
                {
                    return;
                }
            }

            if (visualization)
            {
                var intView = new int[tableLayoutPanel2.RowCount, tableLayoutPanel2.ColumnCount];
                //перегоняем табличный контрол в двумерный массив чисел на основе enum CellTypes
                foreach (Control control in tableLayoutPanel2.Controls)
                {
                    var pos = tableLayoutPanel2.GetPositionFromControl(control);
                    var row = pos.Row;
                    var col = pos.Column;
                    var cellType = (CellTypes) control.Tag;
                    intView[row, col] = (int) cellType;
                }

                //перегон массива в строку с переносами

                for (var i = 0; i < tableLayoutPanel2.RowCount; i++)
                {
                    for (var j = 0; j < tableLayoutPanel2.ColumnCount; j++)
                    {
                        s += intView[i, j];
                    }

                    s += "\r\n";
                }
            }

            //файловый диалог и сохранение
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, s);
                }
            }
        }


        private void backstageViewButtonItem3_ItemClick(object sender,
            DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            var str = "";
            //находим файл через диалог, читаем текст
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
            //разбиваем текст по строкам

            var data = str.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            if (data.Length > 50)
            {
                MessageBox.Show("Слишком большой лабиринт для редактирования!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            InitTable(data.Length, data[0].Length);

            GraphParser.ParsePanel(data, tableLayoutPanel2);
        }

        private void backstageViewButtonItem1_ItemClick(object sender,
            DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Application.Exit();
        }

        private void InitLargeTable(int rows, int columns)
        {
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.RowCount = rows;
            tableLayoutPanel2.ColumnCount = columns;
            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();
            tableLayoutPanel2.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 40));
            tableLayoutPanel2.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 60));          
            tableLayoutPanel2.RowStyles.Add(
                    new RowStyle(SizeType.Percent,  100 ));
            tableLayoutPanel2.Controls.Add(new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1               
            });

            tableLayoutPanel2.Controls[0].Controls.Add(new LabelControl
            {
                Text = "Размерность лабиринта: ",
                Dock = DockStyle.Fill
            });
            string tmp = resizeBar.EditValue.ToString();
            tableLayoutPanel2.Controls[0].Controls.Add(new LabelControl
            {
                Text = tmp,
                Dock = DockStyle.Fill,
            });
            tableLayoutPanel2.Controls[0].Controls.Add(new LabelControl
            {
                Text = "\nДля редактирования лабиринта пройдите в дирректорию проекта и откройте соответствубщий .txt файл",
                AutoSizeMode = LabelAutoSizeMode.Vertical
            });
            tableLayoutPanel2.Controls.Add(new PictureBox
            {
                Dock = DockStyle.Fill,
                //Image = Image.FromFile(@"C:\Users\Denis\source\repos\PathFindingApp\PathFindingApp\largeMaze.png"),
                Image = Image.FromFile(@"C:\Users\DENIS\Documents\Visual Studio 2017\Projects\PathFindingApp1.1\largeMaze.png"),
                SizeMode = PictureBoxSizeMode.Zoom
            });
        }

        private void visualBar_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (visualBar.Checked)
            {
                visualBar.Caption = "Визуализация: OFF";
                toolboxControl1.Visible = false;
                InitLargeTable(2, 3);
                visualization = false;
                return;
            }

            if (visualBar.Checked == false)
            {
                visualBar.Caption = "Визуализация: ON";
                InitTable(5, 5);
                resizeBar.EditValue = "5";
                visualization = true;
                toolboxControl1.Visible = true;
            }
        }
    }
}

