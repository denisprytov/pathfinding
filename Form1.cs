using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.CodeParser;
using PathFindingApp.test;
using PathFindingApp.UserControls;

namespace PathFindingApp
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        private ResolverControl resView = new ResolverControl { Dock = DockStyle.Fill };
        private LabirinthEditor editor = new LabirinthEditor { Dock = DockStyle.Fill };
        private Chart chart = new Chart { Dock = DockStyle.Fill};
        public Form1()
        {
            InitializeComponent();
            ResolvePage.ContentContainer.Controls.Add(resView);
            EditPage.ContentContainer.Controls.Add(editor);
            ChartPage.ContentContainer.Controls.Add(chart);
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;
    }
}
