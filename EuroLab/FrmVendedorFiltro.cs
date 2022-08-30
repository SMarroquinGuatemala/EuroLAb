using ClassLibraryEuroLab;
using EuroLab.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroLab
{
    public partial class FrmVendedorFiltro : Form
    {
        Departamento departamento = new Departamento();
        Municipio municipio = new Municipio();
        Vendedor vendedor = new Vendedor();

        public FrmVendedorFiltro()
        {
            InitializeComponent();
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

        private void FillMunicipiosPorDepartamento(int DepartamentoID)
        {
            municipio = new Municipio();

            cboMunicipio.Properties.View.GridControl.ForceInitialize();
            cboMunicipio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            cboMunicipio.Properties.DataSource = municipio.GetAllByDepartamento(DepartamentoID);
            cboMunicipio.Properties.DisplayMember = "Nombre";
            cboMunicipio.Properties.ValueMember = "MunicipioID";
            cboMunicipio.Properties.PopulateViewColumns();
        }

        private void FillDepartamentos()
        {
            departamento = new Departamento();

            cboDepartamento.Properties.View.GridControl.ForceInitialize();
            cboDepartamento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            cboDepartamento.Properties.DataSource = departamento.GetDepartamentos();
            cboDepartamento.Properties.DisplayMember = "Nombre";
            cboDepartamento.Properties.ValueMember = "DepartamentoID";
            cboDepartamento.Properties.PopulateViewColumns();
        }

        private void FrmClienteFiltro_Load(object sender, EventArgs e)
        {
            ActiveControl = cboDepartamento;
            FillDepartamentos();
        }

        private void cboDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.EditValue!= null)
            {

            
            if (!string.IsNullOrEmpty(cboDepartamento.EditValue.ToString()))
            {
                FillMunicipiosPorDepartamento(Convert.ToInt16(cboDepartamento.EditValue));
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {           
                int? DepartamentoID = null;
                int? MunicipioID = null;
                DepartamentoID = !String.IsNullOrEmpty(Convert.ToString(cboDepartamento.EditValue)) ? Convert.ToInt32(cboDepartamento.EditValue) : (int?)null;
                MunicipioID = !String.IsNullOrEmpty(Convert.ToString(cboMunicipio.EditValue)) ? Convert.ToInt32(cboMunicipio.EditValue) : (int?)null;
                grdVendedor.DataSource = vendedor.GetAll(DepartamentoID, MunicipioID);
                lblRegsitrosProducto.Text = grdVendedor.MainView.RowCount.ToString();
            }
            catch (Exception ex)
            {
                Log.Add(ex);
            }
        }

        private void grdCliente_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    DeshabilitaMenuContextual();
                    mnuGrabar.Enabled = true;
                    if (ViewPrincipal.DataRowCount > 1)
                    {
                        mnuModificar.Enabled = true;
                        mnuEliminar.Enabled = true;

                    }
                }
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
                Form form = new FrmVendedor(null);

                form.ShowDialog();
                button1_Click(sender, e);
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
                object VendedorIDValue = 0;
                VendedorIDValue = ViewPrincipal.GetRowCellValue(ViewPrincipal.FocusedRowHandle, VendedorID);
                Form form = new FrmVendedor((int)VendedorIDValue);
                form.ShowDialog();
                button1_Click(sender, e);
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }

        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Form form = new FrmCliente(null);
                //form.ShowDialog();
                //button1_Click(sender, e);
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }
        }

        private void precioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void mnuGrabar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Form form = new FrmCliente(null);

        //        form.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

        //private void mnuModificar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        object ClienteIDValue = 0;
        //        ClienteIDValue = ViewPrincipal.GetRowCellValue(ViewPrincipal.FocusedRowHandle, ClienteID);
        //        Form form = new FrmCliente((int)ClienteIDValue);
        //        form.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}




    }
}
