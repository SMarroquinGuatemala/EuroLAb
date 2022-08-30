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
    public partial class FrmProducto : Form
    {
        GrupoProducto grupoProducto  =new GrupoProducto();
        Producto producto = new Producto();
        int? productoID;
        public FrmProducto(int? productoIDFromForm)
        {
            InitializeComponent();
            productoID = productoIDFromForm;
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

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ActiveControl = cboGrupoProducto;
            FillGrupoProducto();

            if (productoID!= null)
            {
                LoadDataByID();
            }
        }

        private void LoadDataByID()
        {
            try
            {

            
            producto = new Producto();
            DataTable dataTable = new DataTable();
            dataTable= producto.GetAllByID((int)productoID);

            txtCodigo.Text = dataTable.Rows[0]["Codigo"].ToString();
            txtNombre.Text = dataTable.Rows[0]["Nombre"].ToString();
            txtPrecio.Text = dataTable.Rows[0]["Precio"].ToString();
            txtDescripcion.Text = dataTable.Rows[0]["Descripcion"].ToString();
            cboGrupoProducto.EditValue = dataTable.Rows[0]["GrupoProductoID"].ToString();
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }

        }

        private void cboClientes_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( String.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("Debe ingresar un código", "Mensaje del sistema");
                    ActiveControl = txtCodigo;
                    return;
                }

                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre", "Mensaje del sistema");
                    ActiveControl = txtNombre;
                    return;
                }


                if (String.IsNullOrEmpty(txtPrecio.Text.ToString()) || txtPrecio.Text == "0" || Convert.ToDecimal(txtPrecio.Text) < 0)
                {
                    MessageBox.Show("Debe ingresar un precio valido", "Mensaje del sistema");
                    ActiveControl = txtPrecio;
                    return;
                }

                producto = new Producto();
                producto.Save(txtCodigo.Text, txtNombre.Text,Convert.ToDecimal(txtPrecio.Text), txtDescripcion.Text,Convert.ToInt32( cboGrupoProducto.EditValue), productoID);

                string message = "Producto grabado correctamente.¿Desea grabar otro registro?";
                string title = "Mensaje del sistema";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    cboGrupoProducto.EditValue = null;
                    txtCodigo.ResetText();
                    txtNombre.ResetText();
                    txtDescripcion.ResetText();
                    txtPrecio.ResetText();                    
                    ActiveControl = cboGrupoProducto;
                    productoID = null;
                }
                else
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }

        }
    }
}

