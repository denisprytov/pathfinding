using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PathFindingApp
{
    partial class ResolverControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResolverControl));
            this.LargeMazePictureBox1 = new System.Windows.Forms.PictureBox();
            this.LargeMazeSize1 = new DevExpress.XtraEditors.LabelControl();
            this.LargeMazePictureBox2 = new System.Windows.Forms.PictureBox();
            this.LargeMazeSize2 = new DevExpress.XtraEditors.LabelControl();
            this.LargeMazePictureBox3 = new System.Windows.Forms.PictureBox();
            this.LargeMazeSize3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDijkstra = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBfs = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAstar = new DevExpress.XtraEditors.LabelControl();
            this.dijkstraPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bFirstPanel = new System.Windows.Forms.TableLayoutPanel();
            this.aStarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dijkstraFirst = new DevExpress.XtraEditors.LabelControl();
            this.dijkstraBest = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.bfFirst = new DevExpress.XtraEditors.LabelControl();
            this.bfBest = new DevExpress.XtraEditors.LabelControl();
            this.asFirst = new DevExpress.XtraEditors.LabelControl();
            this.asBest = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelDijFirst = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDijBest = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBfsFirst = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBfsBest = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAstarFirst = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAstarBest = new System.Windows.Forms.FlowLayoutPanel();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.loadButton = new DevExpress.XtraBars.BarButtonItem();
            this.dijkstraButton = new DevExpress.XtraBars.BarButtonItem();
            this.bfsButton = new DevExpress.XtraBars.BarButtonItem();
            this.astarButton = new DevExpress.XtraBars.BarButtonItem();
            this.allAlgsButton = new DevExpress.XtraBars.BarButtonItem();
            this.speedUp = new DevExpress.XtraBars.BarButtonItem();
            this.speedDown = new DevExpress.XtraBars.BarButtonItem();
            this.RunBuntton = new DevExpress.XtraBars.BarButtonItem();
            this.pauseButton = new DevExpress.XtraBars.BarButtonItem();
            this.stopButton = new DevExpress.XtraBars.BarButtonItem();
            this.resumeButton = new DevExpress.XtraBars.BarButtonItem();
            this.speedEditor = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.main = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.view = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.defaultBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.LargeMazePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargeMazePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargeMazePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelDijFirst.SuspendLayout();
            this.flowLayoutPanelDijBest.SuspendLayout();
            this.flowLayoutPanelBfsFirst.SuspendLayout();
            this.flowLayoutPanelBfsBest.SuspendLayout();
            this.flowLayoutPanelAstarFirst.SuspendLayout();
            this.flowLayoutPanelAstarBest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).BeginInit();
            this.SuspendLayout();
            // 
            // LargeMazePictureBox1
            // 
            this.LargeMazePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LargeMazePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("LargeMazePictureBox1.Image")));
            this.LargeMazePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.LargeMazePictureBox1.Name = "LargeMazePictureBox1";
            this.LargeMazePictureBox1.Size = new System.Drawing.Size(100, 50);
            this.LargeMazePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LargeMazePictureBox1.TabIndex = 0;
            this.LargeMazePictureBox1.TabStop = false;
            // 
            // LargeMazeSize1
            // 
            this.LargeMazeSize1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LargeMazeSize1.Location = new System.Drawing.Point(0, 0);
            this.LargeMazeSize1.Name = "LargeMazeSize1";
            this.LargeMazeSize1.Size = new System.Drawing.Size(75, 14);
            this.LargeMazeSize1.TabIndex = 0;
            // 
            // LargeMazePictureBox2
            // 
            this.LargeMazePictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LargeMazePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("LargeMazePictureBox2.Image")));
            this.LargeMazePictureBox2.Location = new System.Drawing.Point(0, 0);
            this.LargeMazePictureBox2.Name = "LargeMazePictureBox2";
            this.LargeMazePictureBox2.Size = new System.Drawing.Size(100, 50);
            this.LargeMazePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LargeMazePictureBox2.TabIndex = 0;
            this.LargeMazePictureBox2.TabStop = false;
            // 
            // LargeMazeSize2
            // 
            this.LargeMazeSize2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LargeMazeSize2.Location = new System.Drawing.Point(0, 0);
            this.LargeMazeSize2.Name = "LargeMazeSize2";
            this.LargeMazeSize2.Size = new System.Drawing.Size(75, 14);
            this.LargeMazeSize2.TabIndex = 0;
            // 
            // LargeMazePictureBox3
            // 
            this.LargeMazePictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LargeMazePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("LargeMazePictureBox3.Image")));
            this.LargeMazePictureBox3.Location = new System.Drawing.Point(0, 0);
            this.LargeMazePictureBox3.Name = "LargeMazePictureBox3";
            this.LargeMazePictureBox3.Size = new System.Drawing.Size(100, 50);
            this.LargeMazePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LargeMazePictureBox3.TabIndex = 0;
            this.LargeMazePictureBox3.TabStop = false;
            // 
            // LargeMazeSize3
            // 
            this.LargeMazeSize3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LargeMazeSize3.Location = new System.Drawing.Point(0, 0);
            this.LargeMazeSize3.Name = "LargeMazeSize3";
            this.LargeMazeSize3.Size = new System.Drawing.Size(75, 14);
            this.LargeMazeSize3.TabIndex = 0;
            // 
            // labelControlDijkstra
            // 
            this.labelControlDijkstra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlDijkstra.Appearance.Options.UseFont = true;
            this.labelControlDijkstra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlDijkstra.Location = new System.Drawing.Point(6, 3);
            this.labelControlDijkstra.Name = "labelControlDijkstra";
            this.labelControlDijkstra.Size = new System.Drawing.Size(214, 20);
            this.labelControlDijkstra.TabIndex = 0;
            this.labelControlDijkstra.Text = "Дейкстра";
            // 
            // labelControlBfs
            // 
            this.labelControlBfs.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlBfs.Appearance.Options.UseFont = true;
            this.labelControlBfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlBfs.Location = new System.Drawing.Point(231, 3);
            this.labelControlBfs.Name = "labelControlBfs";
            this.labelControlBfs.Size = new System.Drawing.Size(214, 20);
            this.labelControlBfs.TabIndex = 1;
            this.labelControlBfs.Text = "Поиск в ширину";
            // 
            // labelControlAstar
            // 
            this.labelControlAstar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControlAstar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlAstar.Appearance.Options.UseBackColor = true;
            this.labelControlAstar.Appearance.Options.UseFont = true;
            this.labelControlAstar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlAstar.Location = new System.Drawing.Point(456, 3);
            this.labelControlAstar.Name = "labelControlAstar";
            this.labelControlAstar.Size = new System.Drawing.Size(214, 20);
            this.labelControlAstar.TabIndex = 2;
            this.labelControlAstar.Text = "A* алгоритм";
            // 
            // dijkstraPanel
            // 
            this.dijkstraPanel.BackColor = System.Drawing.Color.Transparent;
            this.dijkstraPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dijkstraPanel.ColumnCount = 2;
            this.dijkstraPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dijkstraPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dijkstraPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dijkstraPanel.Location = new System.Drawing.Point(6, 29);
            this.dijkstraPanel.Name = "dijkstraPanel";
            this.dijkstraPanel.RowCount = 2;
            this.dijkstraPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dijkstraPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dijkstraPanel.Size = new System.Drawing.Size(214, 178);
            this.dijkstraPanel.TabIndex = 2;
            // 
            // bFirstPanel
            // 
            this.bFirstPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bFirstPanel.ColumnCount = 2;
            this.bFirstPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bFirstPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bFirstPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bFirstPanel.Location = new System.Drawing.Point(231, 29);
            this.bFirstPanel.Name = "bFirstPanel";
            this.bFirstPanel.RowCount = 2;
            this.bFirstPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bFirstPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bFirstPanel.Size = new System.Drawing.Size(214, 178);
            this.bFirstPanel.TabIndex = 3;
            // 
            // aStarPanel
            // 
            this.aStarPanel.BackColor = System.Drawing.Color.Transparent;
            this.aStarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aStarPanel.ColumnCount = 2;
            this.aStarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aStarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aStarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aStarPanel.Location = new System.Drawing.Point(456, 29);
            this.aStarPanel.Name = "aStarPanel";
            this.aStarPanel.RowCount = 2;
            this.aStarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.90196F));
            this.aStarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.09804F));
            this.aStarPanel.Size = new System.Drawing.Size(214, 178);
            this.aStarPanel.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelControl4.Location = new System.Drawing.Point(3, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(105, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Поиск первого пути:";
            // 
            // labelControl5
            // 
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl5.Location = new System.Drawing.Point(3, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(132, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Поиск кратчайщего пути:";
            // 
            // dijkstraFirst
            // 
            this.dijkstraFirst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dijkstraFirst.Location = new System.Drawing.Point(114, 3);
            this.dijkstraFirst.Name = "dijkstraFirst";
            this.dijkstraFirst.Size = new System.Drawing.Size(6, 13);
            this.dijkstraFirst.TabIndex = 7;
            this.dijkstraFirst.Text = "0";
            // 
            // dijkstraBest
            // 
            this.dijkstraBest.Dock = System.Windows.Forms.DockStyle.Top;
            this.dijkstraBest.Location = new System.Drawing.Point(141, 3);
            this.dijkstraBest.Name = "dijkstraBest";
            this.dijkstraBest.Size = new System.Drawing.Size(6, 13);
            this.dijkstraBest.TabIndex = 8;
            this.dijkstraBest.Text = "0";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(3, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(105, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Поиск первого пути:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(3, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(105, 13);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Поиск первого пути:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(3, 3);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(132, 13);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Поиск кратчайщего пути:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(3, 3);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(132, 13);
            this.labelControl11.TabIndex = 12;
            this.labelControl11.Text = "Поиск кратчайщего пути:";
            // 
            // bfFirst
            // 
            this.bfFirst.Location = new System.Drawing.Point(114, 3);
            this.bfFirst.Name = "bfFirst";
            this.bfFirst.Size = new System.Drawing.Size(6, 13);
            this.bfFirst.TabIndex = 13;
            this.bfFirst.Text = "0";
            // 
            // bfBest
            // 
            this.bfBest.Location = new System.Drawing.Point(141, 3);
            this.bfBest.Name = "bfBest";
            this.bfBest.Size = new System.Drawing.Size(6, 13);
            this.bfBest.TabIndex = 14;
            this.bfBest.Text = "0";
            // 
            // asFirst
            // 
            this.asFirst.Location = new System.Drawing.Point(114, 3);
            this.asFirst.Name = "asFirst";
            this.asFirst.Size = new System.Drawing.Size(6, 13);
            this.asFirst.TabIndex = 15;
            this.asFirst.Text = "0";
            // 
            // asBest
            // 
            this.asBest.Location = new System.Drawing.Point(141, 3);
            this.asBest.Name = "asBest";
            this.asBest.Size = new System.Drawing.Size(6, 13);
            this.asBest.TabIndex = 16;
            this.asBest.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelDijFirst, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelDijBest, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelBfsFirst, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelBfsBest, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dijkstraPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bFirstPanel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.aStarPanel, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelAstarFirst, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelAstarBest, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControlAstar, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControlBfs, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControlDijkstra, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 264);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanelDijFirst
            // 
            this.flowLayoutPanelDijFirst.Controls.Add(this.labelControl4);
            this.flowLayoutPanelDijFirst.Controls.Add(this.dijkstraFirst);
            this.flowLayoutPanelDijFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDijFirst.Location = new System.Drawing.Point(6, 213);
            this.flowLayoutPanelDijFirst.Name = "flowLayoutPanelDijFirst";
            this.flowLayoutPanelDijFirst.Size = new System.Drawing.Size(214, 20);
            this.flowLayoutPanelDijFirst.TabIndex = 18;
            // 
            // flowLayoutPanelDijBest
            // 
            this.flowLayoutPanelDijBest.Controls.Add(this.labelControl5);
            this.flowLayoutPanelDijBest.Controls.Add(this.dijkstraBest);
            this.flowLayoutPanelDijBest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDijBest.Location = new System.Drawing.Point(6, 239);
            this.flowLayoutPanelDijBest.Name = "flowLayoutPanelDijBest";
            this.flowLayoutPanelDijBest.Size = new System.Drawing.Size(214, 22);
            this.flowLayoutPanelDijBest.TabIndex = 18;
            // 
            // flowLayoutPanelBfsFirst
            // 
            this.flowLayoutPanelBfsFirst.Controls.Add(this.labelControl8);
            this.flowLayoutPanelBfsFirst.Controls.Add(this.bfFirst);
            this.flowLayoutPanelBfsFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBfsFirst.Location = new System.Drawing.Point(231, 213);
            this.flowLayoutPanelBfsFirst.Name = "flowLayoutPanelBfsFirst";
            this.flowLayoutPanelBfsFirst.Size = new System.Drawing.Size(214, 20);
            this.flowLayoutPanelBfsFirst.TabIndex = 18;
            // 
            // flowLayoutPanelBfsBest
            // 
            this.flowLayoutPanelBfsBest.Controls.Add(this.labelControl10);
            this.flowLayoutPanelBfsBest.Controls.Add(this.bfBest);
            this.flowLayoutPanelBfsBest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBfsBest.Location = new System.Drawing.Point(231, 239);
            this.flowLayoutPanelBfsBest.Name = "flowLayoutPanelBfsBest";
            this.flowLayoutPanelBfsBest.Size = new System.Drawing.Size(214, 22);
            this.flowLayoutPanelBfsBest.TabIndex = 18;
            // 
            // flowLayoutPanelAstarFirst
            // 
            this.flowLayoutPanelAstarFirst.Controls.Add(this.labelControl9);
            this.flowLayoutPanelAstarFirst.Controls.Add(this.asFirst);
            this.flowLayoutPanelAstarFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAstarFirst.Location = new System.Drawing.Point(456, 213);
            this.flowLayoutPanelAstarFirst.Name = "flowLayoutPanelAstarFirst";
            this.flowLayoutPanelAstarFirst.Size = new System.Drawing.Size(214, 20);
            this.flowLayoutPanelAstarFirst.TabIndex = 18;
            // 
            // flowLayoutPanelAstarBest
            // 
            this.flowLayoutPanelAstarBest.Controls.Add(this.labelControl11);
            this.flowLayoutPanelAstarBest.Controls.Add(this.asBest);
            this.flowLayoutPanelAstarBest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAstarBest.Location = new System.Drawing.Point(456, 239);
            this.flowLayoutPanelAstarBest.Name = "flowLayoutPanelAstarBest";
            this.flowLayoutPanelAstarBest.Size = new System.Drawing.Size(214, 22);
            this.flowLayoutPanelAstarBest.TabIndex = 18;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowKeyTips = false;
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.loadButton,
            this.dijkstraButton,
            this.bfsButton,
            this.astarButton,
            this.allAlgsButton,
            this.speedUp,
            this.speedDown,
            this.RunBuntton,
            this.pauseButton,
            this.stopButton,
            this.resumeButton,
            this.speedEditor});
            this.ribbonControl1.ItemsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 37;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsAnimation.PageCategoryShowAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.OptionsTouch.AffectOnlyRibbon = true;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.main,
            this.view});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemTrackBar1,
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTimeEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(678, 98);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // loadButton
            // 
            this.loadButton.Caption = "Загрузить лабиринт";
            this.loadButton.Id = 1;
            this.loadButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("loadButton.ImageOptions.Image")));
            this.loadButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("loadButton.ImageOptions.LargeImage")));
            this.loadButton.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
            this.loadButton.LargeWidth = 100;
            this.loadButton.Name = "loadButton";
            this.loadButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.loadButton_ItemClick);
            // 
            // dijkstraButton
            // 
            this.dijkstraButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.dijkstraButton.Caption = "Дейкстра";
            this.dijkstraButton.Id = 3;
            this.dijkstraButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dijkstraButton.ImageOptions.Image")));
            this.dijkstraButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dijkstraButton.ImageOptions.LargeImage")));
            this.dijkstraButton.LargeWidth = 100;
            this.dijkstraButton.Name = "dijkstraButton";
            this.dijkstraButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dijkstraButton_ItemClick);
            // 
            // bfsButton
            // 
            this.bfsButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bfsButton.Caption = "Поиск в ширину";
            this.bfsButton.Id = 5;
            this.bfsButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bfsButton.ImageOptions.Image")));
            this.bfsButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bfsButton.ImageOptions.LargeImage")));
            this.bfsButton.LargeWidth = 100;
            this.bfsButton.Name = "bfsButton";
            this.bfsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bfsButton_ItemClick);
            // 
            // astarButton
            // 
            this.astarButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.astarButton.Caption = "А* алгоритм";
            this.astarButton.Id = 6;
            this.astarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("astarButton.ImageOptions.Image")));
            this.astarButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("astarButton.ImageOptions.LargeImage")));
            this.astarButton.LargeWidth = 100;
            this.astarButton.Name = "astarButton";
            this.astarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.astarButton_ItemClick);
            // 
            // allAlgsButton
            // 
            this.allAlgsButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.allAlgsButton.Caption = "Визуалиция всех трех алгоритмов";
            this.allAlgsButton.Down = true;
            this.allAlgsButton.Id = 8;
            this.allAlgsButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("allAlgsButton.ImageOptions.Image")));
            this.allAlgsButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("allAlgsButton.ImageOptions.LargeImage")));
            this.allAlgsButton.LargeWidth = 100;
            this.allAlgsButton.Name = "allAlgsButton";
            this.allAlgsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.allAlgsButton_ItemClick);
            // 
            // speedUp
            // 
            this.speedUp.Caption = "Увеличить скорость";
            this.speedUp.Id = 22;
            this.speedUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("speedUp.ImageOptions.Image")));
            this.speedUp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("speedUp.ImageOptions.LargeImage")));
            this.speedUp.Name = "speedUp";
            this.speedUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.speedUp_ItemClick);
            // 
            // speedDown
            // 
            this.speedDown.Caption = "Уменьшить скорость";
            this.speedDown.Id = 24;
            this.speedDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("speedDown.ImageOptions.Image")));
            this.speedDown.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("speedDown.ImageOptions.LargeImage")));
            this.speedDown.Name = "speedDown";
            this.speedDown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.speedDown_ItemClick);
            // 
            // RunBuntton
            // 
            this.RunBuntton.Caption = "Пуск!";
            this.RunBuntton.Id = 23;
            this.RunBuntton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RunBuntton.ImageOptions.Image")));
            this.RunBuntton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RunBuntton.ImageOptions.LargeImage")));
            this.RunBuntton.LargeWidth = 100;
            this.RunBuntton.Name = "RunBuntton";
            this.RunBuntton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RunBuntton_ItemClick);
            // 
            // pauseButton
            // 
            this.pauseButton.Caption = "Пауза";
            this.pauseButton.Id = 25;
            this.pauseButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.ImageOptions.Image")));
            this.pauseButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.ImageOptions.LargeImage")));
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pauseButton_ItemClick);
            // 
            // stopButton
            // 
            this.stopButton.Caption = "Стоп";
            this.stopButton.Id = 27;
            this.stopButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.ImageOptions.Image")));
            this.stopButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("stopButton.ImageOptions.LargeImage")));
            this.stopButton.Name = "stopButton";
            this.stopButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stopButton_ItemClick);
            // 
            // resumeButton
            // 
            this.resumeButton.Caption = "Продолжить";
            this.resumeButton.Id = 26;
            this.resumeButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resumeButton.ImageOptions.Image")));
            this.resumeButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("resumeButton.ImageOptions.LargeImage")));
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.resumeButton_ItemClick);
            // 
            // speedEditor
            // 
            this.speedEditor.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
            this.speedEditor.Caption = " Скорость";
            this.speedEditor.Edit = this.repositoryItemTrackBar1;
            this.speedEditor.EditHeight = 50;
            this.speedEditor.EditWidth = 400;
            this.speedEditor.Id = 29;
            this.speedEditor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("speedEditor.ImageOptions.Image")));
            this.speedEditor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("speedEditor.ImageOptions.LargeImage")));
            this.speedEditor.Name = "speedEditor";
            this.speedEditor.EditValueChanged += new System.EventHandler(this.speedEditor_EditValueChanged);
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTrackBar1.LargeChange = 100;
            this.repositoryItemTrackBar1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.repositoryItemTrackBar1.Maximum = 8000;
            this.repositoryItemTrackBar1.Minimum = 1;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            // 
            // main
            // 
            this.main.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.main.Name = "main";
            this.main.Text = "Главная";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.loadButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.RunBuntton);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // view
            // 
            this.view.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.view.Name = "view";
            this.view.Text = "Вид";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.dijkstraButton);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bfsButton, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.astarButton);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.allAlgsButton);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.speedUp);
            this.ribbonStatusBar1.ItemLinks.Add(this.speedDown);
            this.ribbonStatusBar1.ItemLinks.Add(this.RunBuntton);
            this.ribbonStatusBar1.ItemLinks.Add(this.pauseButton);
            this.ribbonStatusBar1.ItemLinks.Add(this.resumeButton);
            this.ribbonStatusBar1.ItemLinks.Add(this.stopButton);
            this.ribbonStatusBar1.ItemLinks.Add(this.speedEditor);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 302);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(678, 28);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Пуск!";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Пуск!";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Пуск!";
            this.barButtonItem4.Id = 2;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Пуск!";
            this.barButtonItem5.Id = 2;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // defaultBarAndDockingController1
            // 
            this.defaultBarAndDockingController1.Controller.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.defaultBarAndDockingController1.Controller.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "0";
            this.barStaticItem1.Id = 33;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // ResolverControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResolverControl";
            this.Size = new System.Drawing.Size(678, 330);
            ((System.ComponentModel.ISupportInitialize)(this.LargeMazePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargeMazePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargeMazePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanelDijFirst.ResumeLayout(false);
            this.flowLayoutPanelDijFirst.PerformLayout();
            this.flowLayoutPanelDijBest.ResumeLayout(false);
            this.flowLayoutPanelDijBest.PerformLayout();
            this.flowLayoutPanelBfsFirst.ResumeLayout(false);
            this.flowLayoutPanelBfsFirst.PerformLayout();
            this.flowLayoutPanelBfsBest.ResumeLayout(false);
            this.flowLayoutPanelBfsBest.PerformLayout();
            this.flowLayoutPanelAstarFirst.ResumeLayout(false);
            this.flowLayoutPanelAstarFirst.PerformLayout();
            this.flowLayoutPanelAstarBest.ResumeLayout(false);
            this.flowLayoutPanelAstarBest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LargeMazePictureBox1;
        private LabelControl LargeMazeSize1;
        private PictureBox LargeMazePictureBox2;
        private LabelControl LargeMazeSize2;
        private PictureBox LargeMazePictureBox3;
        private LabelControl LargeMazeSize3;
        private DevExpress.XtraEditors.LabelControl labelControlDijkstra;
        private DevExpress.XtraEditors.LabelControl labelControlBfs;
        private DevExpress.XtraEditors.LabelControl labelControlAstar;
        private System.Windows.Forms.TableLayoutPanel dijkstraPanel;
        private System.Windows.Forms.TableLayoutPanel bFirstPanel;
        private System.Windows.Forms.TableLayoutPanel aStarPanel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl dijkstraFirst;
        private DevExpress.XtraEditors.LabelControl dijkstraBest;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl bfFirst;
        private DevExpress.XtraEditors.LabelControl bfBest;
        private DevExpress.XtraEditors.LabelControl asFirst;
        private DevExpress.XtraEditors.LabelControl asBest;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAstarFirst;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDijBest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDijFirst;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAstarBest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBfsBest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBfsFirst;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage main;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem loadButton;
        private DevExpress.XtraBars.BarButtonItem dijkstraButton;
        private DevExpress.XtraBars.BarButtonItem bfsButton;
        private DevExpress.XtraBars.BarButtonItem astarButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage view;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem allAlgsButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private DevExpress.XtraBars.BarButtonItem speedUp;
        private DevExpress.XtraBars.BarButtonItem speedDown;
        private DevExpress.XtraBars.BarButtonItem RunBuntton;
        private DevExpress.XtraBars.BarButtonItem pauseButton;
        private DevExpress.XtraBars.BarButtonItem stopButton;
        private DevExpress.XtraBars.BarButtonItem resumeButton;
        private DevExpress.XtraBars.BarEditItem speedEditor;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}
