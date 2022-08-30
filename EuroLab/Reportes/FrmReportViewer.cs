using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ClassLibraryEuroLab;
using EuroLab.Helpers;

namespace EuroLab.Reportes
{
  

    public partial class FrmReportViewer : Form
    {

        public static int NumeroDeEnvio = 0;
        //C:\Users\dmarroquin\source\repos\EuroLab\EuroLab\Reportes
        string PathReports = System.IO.Path.Combine(@"C:\", "Users", "dmarroquin", "source", "repos", "EuroLab", "EuroLab", "Reportes");
        Envio envio = new Envio();

        public FrmReportViewer(int numeroDeEnvio)
        {
            InitializeComponent();
            NumeroDeEnvio = numeroDeEnvio;
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
            try
            {

            
            this.WindowState = FormWindowState.Maximized;
            this.ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            this.ReportViewer.ZoomPercent = 100;
            this.ReportViewer.ProcessingMode = ProcessingMode.Local;
            this.ReportViewer.LocalReport.ReportPath = System.IO.Path.Combine(PathReports, "rptEnvio.rdlc");
            //DataTable Table = empleado.LoadDataCarnet(Environment.MachineName);
            DataTable Table = envio.GetDataReportePorEnvio(NumeroDeEnvio);
            ReportDataSource datasource = new ReportDataSource("dsReporteEnvio", (DataTable)Table);
            this.ReportViewer.LocalReport.DataSources.Clear();
            this.ReportViewer.LocalReport.DataSources.Add(datasource);
            this.ReportViewer.RefreshReport();

            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }
        }
         
    }

        
          
    
}
