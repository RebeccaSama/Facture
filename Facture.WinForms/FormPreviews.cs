
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Facture.WinForms
{
    public partial class formPreview : Form
    {
        public formPreview()
        {
            InitializeComponent();
            
        }

        private void FormPreview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "RptFacture.rdlc";

            List<Identification> identification = new List<Identification>
            {                
                new Identification("NANA Cabrel","69 Rue Nations","680930001"," 305","12/05/2020",File.ReadAllBytes("logo.png"))
            };

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", identification));

            List<ClientAccount> client = new List<ClientAccount>
            {
                new ClientAccount("45","Moulinex",Convert.ToDouble(4),Convert.ToDouble(20000),Convert.ToDouble(null),Convert.ToDouble(null)),
                new ClientAccount("08","Radio",Convert.ToDouble(1),Convert.ToDouble(6500),Convert.ToDouble(null),Convert.ToDouble(null)),
                new ClientAccount("25","Grand Noir",Convert.ToDouble(4),Convert.ToDouble(4000),Convert.ToDouble(null),Convert.ToDouble(null)),
                new ClientAccount("21","louche",Convert.ToDouble(1),Convert.ToDouble(10000),Convert.ToDouble(null),Convert.ToDouble(null)),
                new ClientAccount("40","Rechaud", Convert.ToDouble(2), Convert.ToDouble(8000),Convert.ToDouble(null),Convert.ToDouble(null)),
                new ClientAccount("42","Marmite", Convert.ToDouble(3), Convert.ToDouble(6345),Convert.ToDouble(null),Convert.ToDouble(null)),
                new ClientAccount(null,null, Convert.ToDouble(null),Convert.ToDouble(null),Convert.ToDouble(0),Convert.ToDouble(0))


            };

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Consommation", client));

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
