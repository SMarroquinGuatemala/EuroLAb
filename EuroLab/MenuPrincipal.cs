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
    public partial class MenuPrincipal : Form
    {        

        public MenuPrincipal()
        {
            InitializeComponent();
        }

      

        private void enviosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

            
            Form form = new FrmEnvioFiltro();
            
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }

        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            Form form = new Reportes.FrmReportViewer(0);
            form.Show();
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            Form form = new FrmClienteFiltro();

            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }

        }

        private void maetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FrmProductoFiltro();

            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }
        }

        private void enviosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FrmVendedorFiltro();

                form.WindowState = FormWindowState.Maximized;
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex)
            {

                Log.Add(ex);
            }
        }
    }
}
