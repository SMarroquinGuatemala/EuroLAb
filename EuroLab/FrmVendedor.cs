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
    public partial class FrmVendedor : Form
    {
        Departamento departamento = new Departamento();
        Municipio municipio = new Municipio();
        Vendedor vendedor = new Vendedor();

        int? vendedorID;
        public FrmVendedor(int? vendedorIDFromForm)
        {
            
            InitializeComponent();
            vendedorID = vendedorIDFromForm;
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



        private void FrmCliente_Load(object sender, EventArgs e)
        {
            try
            {
            ActiveControl = txtNombre;
            FillDepartamentos();
                if (vendedorID != null)
                {
                    LoadDataByID();
                }

            }
            catch (Exception ex)
            {

               Log.Add(ex);
            }
        }

        private void LoadDataByID()
        {
            try
            {

           
            vendedor = new Vendedor();
            DataTable dataTable = new DataTable();
            dataTable = vendedor.GetAllByID((int)vendedorID);

            txtNombre.Text = dataTable.Rows[0]["Nombres"].ToString();
            txtApellidos .Text = dataTable.Rows[0]["Apellidos"].ToString();
            txtNit.Text = dataTable.Rows[0]["NIT"].ToString();
            txtTelefono.Text = dataTable.Rows[0]["Telefono"].ToString();
            txtDireccion.Text = dataTable.Rows[0]["Direccion"].ToString();            
            cboDepartamento.EditValue = dataTable.Rows[0]["DepartamentoID"].ToString();
            cboMunicipio.EditValue = dataTable.Rows[0]["MunicipioID"].ToString();
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void cboDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.EditValue !=null)
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
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre", "Mensaje del sistema");
                    ActiveControl = txtNombre;
                    return;
                }

                if (String.IsNullOrEmpty(txtApellidos.Text))
                {
                    MessageBox.Show("Debe ingresar un apellido", "Mensaje del sistema");
                    ActiveControl = txtApellidos;
                    return;
                }

                if (String.IsNullOrEmpty(txtNit.Text))
                {
                    MessageBox.Show("Debe ingresar un NIT", "Mensaje del sistema");
                    ActiveControl = txtNit;
                    return;
                }


                //if (String.IsNullOrEmpty(txtPrecio.Text.ToString()) || txtPrecio.Text == "0" || Convert.ToDecimal(txtPrecio.Text) < 0)
                //{
                //    MessageBox.Show("Debe ingresar un precio valido", "Mensaje del sistema");
                //    ActiveControl = txtPrecio;
                //    return;
                //}

                vendedor = new Vendedor();
                vendedor.Save(txtNombre.Text, txtApellidos.Text, txtNit.Text, txtTelefono.Text, txtDireccion.Text, Convert.ToInt32(cboDepartamento.EditValue), Convert.ToInt32(cboMunicipio.EditValue), vendedorID);

                string message = "Cliente grabado correctamente.¿Desea grabar otro registro?";
                string title = "Mensaje del sistema";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    
                    txtNombre.ResetText();
                    txtApellidos.ResetText();
                    txtNit.ResetText();
                    txtTelefono.ResetText();
                    txtDireccion.ResetText();                    
                    cboDepartamento.EditValue = null;
                    cboMunicipio.EditValue = null;
                    vendedorID = null;
                    ActiveControl = txtNombre;
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
