namespace EuroLab
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.enviosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 470);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(648, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // enviosToolStripMenuItem
            // 
            this.enviosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviosToolStripMenuItem1});
            this.enviosToolStripMenuItem.Name = "enviosToolStripMenuItem";
            this.enviosToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.enviosToolStripMenuItem.Text = "&Transaccionales";
            this.enviosToolStripMenuItem.Click += new System.EventHandler(this.enviosToolStripMenuItem_Click);
            // 
            // enviosToolStripMenuItem1
            // 
            this.enviosToolStripMenuItem1.Name = "enviosToolStripMenuItem1";
            this.enviosToolStripMenuItem1.Size = new System.Drawing.Size(120, 24);
            this.enviosToolStripMenuItem1.Text = "&Envios";
            this.enviosToolStripMenuItem1.Click += new System.EventHandler(this.enviosToolStripMenuItem1_Click);
            // 
            // maetrosToolStripMenuItem
            // 
            this.maetrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.tipoDePagoToolStripMenuItem});
            this.maetrosToolStripMenuItem.Name = "maetrosToolStripMenuItem";
            this.maetrosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.maetrosToolStripMenuItem.Text = "&Maestros";
            this.maetrosToolStripMenuItem.Click += new System.EventHandler(this.maetrosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.productosToolStripMenuItem.Text = "&Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.vendedoresToolStripMenuItem.Text = "&Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // tipoDePagoToolStripMenuItem
            // 
            this.tipoDePagoToolStripMenuItem.Name = "tipoDePagoToolStripMenuItem";
            this.tipoDePagoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.tipoDePagoToolStripMenuItem.Text = "&Tipo de Pago";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviosToolStripMenuItem,
            this.maetrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl
            // 
            this.tabControl.MdiParent = this;
            this.tabControl.TabGroupSettings.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.Tab;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 492);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "::- Menu Principal EuroLab -::";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enviosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maetrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagoToolStripMenuItem;
        private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager tabControl;
    }
}



