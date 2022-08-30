using ClassLibraryEuroLab;
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
    public partial class FrmPrecioClienteProducto : Form
    {
        Cliente cliente = new Cliente();
        Producto producto = new Producto();
        PrecioClienteProducto precioClienteProducto = new PrecioClienteProducto();
        public int ClienteId  { get; set; }
        public int ProductoId { get; set; }
        public FrmPrecioClienteProducto(int  clienteId, int  productoId)
        {
            InitializeComponent();
            ClienteId = clienteId;
            ProductoId = productoId;
            
        }

        private void PrecioClienteProducto_Load(object sender, EventArgs e)
        {
            FillClientes();
            FillProductos();
            if (ProductoId!=0)
            {
                cboProducto.EditValue = ProductoId;
                ActiveControl = cboClientes;
            }

            if (ClienteId != 0)
            {
                cboClientes.EditValue = ClienteId;
                ActiveControl = cboProducto;
            }

        }

        private void FillClientes()
        {
            cliente = new Cliente();
            //ContratosDAL db = new ContratosDAL();
            cboClientes.Properties.View.GridControl.ForceInitialize();
            cboClientes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            cboClientes.Properties.DataSource = cliente.GetAll();
            cboClientes.Properties.DisplayMember = "NombreCompleto";
            cboClientes.Properties.ValueMember = "ClienteID";

            cboClientes.Properties.PopulateViewColumns();
        }


        private void FillProductos()
        {
            producto = new Producto();

            cboProducto.Properties.View.GridControl.ForceInitialize();
            cboProducto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            cboProducto.Properties.DataSource = producto.GetAll();
            cboProducto.Properties.DisplayMember = "Nombre";
            cboProducto.Properties.ValueMember = "ProductoID";
            cboProducto.Properties.PopulateViewColumns();
        }

        private void cboProducto_EditValueChanged(object sender, EventArgs e)
            {
            DataTable data = new DataTable();
            data= producto.GetAllByID((int)cboProducto.EditValue);
            if (data != null)
            {            
                if (data.Rows.Count>0)
                {
                    txtPrecio.Text = data.Rows[0]["Precio"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                precioClienteProducto = new PrecioClienteProducto();
                precioClienteProducto.Save((int)cboClientes.EditValue, (int)cboProducto.EditValue, Convert.ToDecimal(txtPrecio.Text));

                string message = "Precio grabado correctamente.¿Desea grabar otro registro?";
                string title = "Mensaje del sistema";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    if (ProductoId != 0)
                    {
                        ActiveControl = cboClientes;
                    }

                    if (ClienteId != 0)
                    {
                        ActiveControl = cboProducto;
                    }
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
