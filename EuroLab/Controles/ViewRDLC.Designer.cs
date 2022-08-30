namespace Contratos.Controls
{
    partial class ViewRDLC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbltituloreporte = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CboImpresoras = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.CmdExportar = new DevExpress.XtraEditors.DropDownButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.SeparatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewerRDLC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CboImpresoras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorControl2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.lbltituloreporte);
            this.Panel1.Controls.Add(this.SeparatorControl1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(619, 43);
            this.Panel1.TabIndex = 4;
            // 
            // lbltituloreporte
            // 
            this.lbltituloreporte.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbltituloreporte.Appearance.Options.UseFont = true;
            this.lbltituloreporte.Location = new System.Drawing.Point(3, 3);
            this.lbltituloreporte.Name = "lbltituloreporte";
            this.lbltituloreporte.Size = new System.Drawing.Size(50, 28);
            this.lbltituloreporte.TabIndex = 1;
            this.lbltituloreporte.Text = "Titulo";
            // 
            // SeparatorControl1
            // 
            this.SeparatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorControl1.Location = new System.Drawing.Point(2, 24);
            this.SeparatorControl1.Name = "SeparatorControl1";
            this.SeparatorControl1.Size = new System.Drawing.Size(614, 18);
            this.SeparatorControl1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CboImpresoras);
            this.panel2.Controls.Add(this.CmdExportar);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.CmdImprimir);
            this.panel2.Controls.Add(this.SeparatorControl2);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 390);
            this.panel2.TabIndex = 5;
            // 
            // CboImpresoras
            // 
            this.CboImpresoras.Location = new System.Drawing.Point(3, 74);
            this.CboImpresoras.Name = "CboImpresoras";
            this.CboImpresoras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CboImpresoras.Size = new System.Drawing.Size(163, 20);
            this.CboImpresoras.TabIndex = 7;
            // 
            // CmdExportar
            // 
            this.CmdExportar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CmdExportar.Appearance.Options.UseFont = true;
            this.CmdExportar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.CmdExportar.Location = new System.Drawing.Point(3, 212);
            this.CmdExportar.Name = "CmdExportar";
            this.CmdExportar.Size = new System.Drawing.Size(163, 59);
            this.CmdExportar.TabIndex = 6;
            this.CmdExportar.Text = "Exportar";
            this.CmdExportar.Click += new System.EventHandler(this.CmdExportar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Impresora";
            // 
            // CmdImprimir
            // 
            this.CmdImprimir.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CmdImprimir.Appearance.Options.UseFont = true;
            this.CmdImprimir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.CmdImprimir.Location = new System.Drawing.Point(3, 100);
            this.CmdImprimir.Name = "CmdImprimir";
            this.CmdImprimir.Size = new System.Drawing.Size(163, 59);
            this.CmdImprimir.TabIndex = 3;
            this.CmdImprimir.Text = "Imprimir";
            this.CmdImprimir.Click += new System.EventHandler(this.CmdImprimir_Click);
            // 
            // SeparatorControl2
            // 
            this.SeparatorControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeparatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.SeparatorControl2.Location = new System.Drawing.Point(163, 0);
            this.SeparatorControl2.Name = "SeparatorControl2";
            this.SeparatorControl2.Size = new System.Drawing.Size(20, 390);
            this.SeparatorControl2.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 166);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 40);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Exportar";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 40);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Imprimir";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewerRDLC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(183, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 390);
            this.panel3.TabIndex = 7;
            // 
            // viewerRDLC
            // 
            this.viewerRDLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerRDLC.Location = new System.Drawing.Point(0, 0);
            this.viewerRDLC.Name = "viewerRDLC";
            this.viewerRDLC.ShowExportButton = false;
            this.viewerRDLC.ShowPrintButton = false;
            this.viewerRDLC.ShowProgress = false;
            this.viewerRDLC.Size = new System.Drawing.Size(436, 390);
            this.viewerRDLC.TabIndex = 0;
            // 
            // ViewRDLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "ViewRDLC";
            this.Size = new System.Drawing.Size(619, 433);
            this.Load += new System.EventHandler(this.ViewRDLC_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CboImpresoras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorControl2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal DevExpress.XtraEditors.LabelControl lbltituloreporte;
        internal DevExpress.XtraEditors.SeparatorControl SeparatorControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.ImageComboBoxEdit CboImpresoras;
        private DevExpress.XtraEditors.DropDownButton CmdExportar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton CmdImprimir;
        internal DevExpress.XtraEditors.SeparatorControl SeparatorControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer viewerRDLC;
    }
}
