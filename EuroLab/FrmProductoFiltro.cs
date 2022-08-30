using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEuroLab;
using EuroLab.Helpers;

namespace EuroLab
{
    public partial class FrmProductoFiltro : Form
    {
        GrupoProducto grupoProducto = new GrupoProducto();
        Producto producto = new Producto();
        public FrmProductoFiltro()
        {
            InitializeComponent();
        }
        private void FillGrupoProducto()
        {
            grupoProducto = new GrupoProducto();
            //ContratosDAL db = new ContratosDAL();
            cboGrupoProducto.Properties.View.GridControl.ForceInitialize();
            cboGrupoProducto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            cboGrupoProducto.Properties.DataSource = grupoProducto.GetAll();
            cboGrupoProducto.Properties.DisplayMember = "Nombre";
            cboGrupoProducto.Properties.ValueMember = "GrupoProductoID";

            cboGrupoProducto.Properties.PopulateViewColumns();
        }

        private void FrmProductoFiltro_Load(object sender, EventArgs e)
        {
            ActiveControl = cboGrupoProducto;
            FillGrupoProducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int? grupoProductoID = null;
                grupoProductoID = !String.IsNullOrEmpty(Convert.ToString(cboGrupoProducto.EditValue)) ? Convert.ToInt32(cboGrupoProducto.EditValue) : (int?)null;
                grdProducto.DataSource = producto.GetAllByGrupoProducto(grupoProductoID);
                lblRegsitrosProducto.Text = grdProducto.MainView.RowCount.ToString();
                Cursor.Current = Cursors.Default;
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

        private void grdProducto_MouseUp(object sender, MouseEventArgs e)
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
                        mnuPrecioCliente.Enabled = true;
                        
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mnuGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FrmProducto(null);

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
                object ProductoIDValue = 0;
                ProductoIDValue = ViewPrincipal.GetRowCellValue(ViewPrincipal.FocusedRowHandle, ProductoID);
                Form form = new FrmProducto((int)ProductoIDValue);
                form.ShowDialog();
                button1_Click(sender, e);
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }
        }

        private void precioClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object ProductoIDValue = 0;
            ProductoIDValue = ViewPrincipal.GetRowCellValue(ViewPrincipal.FocusedRowHandle, ProductoID);
            Form form = new FrmPrecioClienteProducto(0,(int)ProductoIDValue);
            form.ShowDialog();
        }
    }
}
