using ClassLibraryEuroLab;
using EuroLab.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroLab
{
    public partial class FrmEnvioFiltro : Form
    {
        Envio envio = new Envio();
        Cliente cliente = new Cliente();
        public FrmEnvioFiltro()
        {
            InitializeComponent();
        }

        private void FrmEnvioFiltro_Load(object sender, EventArgs e)
        {
            ActiveControl = txtFechaInicial;
            txtFechaInicial.DateTime = DateTime.Today.AddMonths(-1);
            txtFechaFinal.DateTime = DateTime.Today;
            FillClientes();
            BuscarEnvios();
        }

        private void FillClientes()
        {
            cliente = new Cliente();
            
            cboClientes.Properties.View.GridControl.ForceInitialize();
            cboClientes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            cboClientes.Properties.DataSource = cliente.GetAll();
            cboClientes.Properties.DisplayMember = "NombreCompleto";
            cboClientes.Properties.ValueMember = "ClienteID";

            cboClientes.Properties.PopulateViewColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            BuscarEnvios();
            Cursor.Current = Cursors.Default;
        }

        private void BuscarEnvios()
        {
            try
            {

            
            int? clienteID = null;
            clienteID = !String.IsNullOrEmpty(Convert.ToString(cboClientes.EditValue)) ? Convert.ToInt32(cboClientes.EditValue) : (int?)null;
            grdEnvios.DataSource = envio.GetData(txtFechaInicial.DateTime, txtFechaFinal.DateTime, clienteID);
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }
        }

        private void mnuImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                object EnvioIDValue = 0;
                EnvioIDValue = ViewPrincipal.GetRowCellValue(ViewPrincipal.FocusedRowHandle, EnvioIDColumn);                
                Form form = new Reportes.FrmReportViewer((int)EnvioIDValue);                
                form.Show();
            }
            catch (Exception ex)
            {
                Log.Add(ex);                
            }
        }

        private void mnuGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FrmEnvio(FrmEnvio.ModoFormulario.Grabar, null);      
                
                form.ShowDialog();
                BuscarEnvios();
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }
        }

        private void mnuModificar_Click(object sender, EventArgs e)
        {
            try
            {
                object EnvioIDValue = 0;
                EnvioIDValue = ViewPrincipal.GetRowCellValue(ViewPrincipal.FocusedRowHandle, EnvioIDColumn);
                Form form = new FrmEnvio(FrmEnvio.ModoFormulario.Modificar, (int)EnvioIDValue);
                form.ShowDialog();
                BuscarEnvios();
            }
            catch (Exception ex)
            { 

                Log.Add(ex);
            }

        }

        public void DeshabilitaMenuContextual()
        {
            foreach (ToolStripItem item in mnuOpciones.Items)
            {
                if (item.GetType().Name == "ToolStripMenuItem")
                {
                    item.Enabled = false;
                }

            }
           
        }

        private void grdArticulos_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {

                    DeshabilitaMenuContextual();
                    mnuGrabar.Enabled = true;
                    if (ViewPrincipal.DataRowCount >= 1)
                    {
                        mnuModificar.Enabled = true;
                        mnuEliminar.Enabled = true;
                        mnuImprimir.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }
        }

       
    }
}
