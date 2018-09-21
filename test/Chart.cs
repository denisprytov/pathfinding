using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using PathFindingApp.Algorithms;

namespace PathFindingApp.test
{
    public partial class Chart : DevExpress.XtraEditors.XtraUserControl
    {
        private List<ChartData> dataInfo;
        public Chart()
        {
            InitializeComponent();
            dataInfo = new List<ChartData>();

        }


        



        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dataInfo.Clear();
            dataInfo.Add(DijkstraAlgorithm.dataFirst);
            dataInfo.Add(DijkstraAlgorithm.dataBest);
            chartControl1.DataSource = dataInfo;
            chartControl1.SeriesDataMember = "Type";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Algo";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Data");
            chartControl1.SeriesNameTemplate.BeginText = "Way: ";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dataInfo.Clear();
            dataInfo.Add(BreadthFirst.dataFirst);
            dataInfo.Add(BreadthFirst.dataBest);
            chartControl1.DataSource = dataInfo;
            chartControl1.SeriesDataMember = "Type";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Algo";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Data");
            chartControl1.SeriesNameTemplate.BeginText = "Way: ";
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dataInfo.Clear();
            dataInfo.Add(AStar.dataFirst);
            dataInfo.Add(AStar.dataBest);
            chartControl1.DataSource = dataInfo;
            chartControl1.SeriesDataMember = "Type";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Algo";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Data");
            chartControl1.SeriesNameTemplate.BeginText = "Way: ";
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dataInfo.Clear();
            dataInfo.Add(DijkstraAlgorithm.dataFirst);
            dataInfo.Add(DijkstraAlgorithm.dataBest);
            dataInfo.Add(BreadthFirst.dataFirst);
            dataInfo.Add(BreadthFirst.dataBest);
            dataInfo.Add(AStar.dataFirst);
            dataInfo.Add(AStar.dataBest);
            chartControl1.DataSource = dataInfo;
            //chartControl1.SeriesTemplate.View = new
            chartControl1.SeriesDataMember = "Type";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Algo";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Data");
            chartControl1.SeriesNameTemplate.BeginText = "Node visitations to ";
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}

