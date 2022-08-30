namespace EuroLab
{
    partial class FrmEnvioFiltro
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
            this.grdEnvios = new DevExpress.XtraGrid.GridControl();
            this.mnuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGrabar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EnvioIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroDeEnvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoDePago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Departamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Municipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFechaInicial = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaFinal = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClientes = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdEnvios)).BeginInit();
            this.mnuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEnvios
            // 
            this.grdEnvios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEnvios.ContextMenuStrip = this.mnuOpciones;
            this.grdEnvios.Location = new System.Drawing.Point(0, 3);
            this.grdEnvios.MainView = this.ViewPrincipal;
            this.grdEnvios.Name = "grdEnvios";
            this.grdEnvios.Size = new System.Drawing.Size(945, 393);
            this.grdEnvios.TabIndex = 0;
            this.grdEnvios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewPrincipal});
            this.grdEnvios.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdArticulos_MouseUp);
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGrabar,
            this.mnuModificar,
            this.mnuEliminar,
            this.toolStripSeparator1,
            this.mnuImprimir});
            this.mnuOpciones.Name = "mnuOpciones";
            this.mnuOpciones.Size = new System.Drawing.Size(126, 98);
            // 
            // mnuGrabar
            // 
            this.mnuGrabar.Name = "mnuGrabar";
            this.mnuGrabar.Size = new System.Drawing.Size(125, 22);
            this.mnuGrabar.Text = "Grabar";
            this.mnuGrabar.Click += new System.EventHandler(this.mnuGrabar_Click);
            // 
            // mnuModificar
            // 
            this.mnuModificar.Name = "mnuModificar";
            this.mnuModificar.Size = new System.Drawing.Size(125, 22);
            this.mnuModificar.Text = "Modificar";
            this.mnuModificar.Click += new System.EventHandler(this.mnuModificar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(125, 22);
            this.mnuEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // mnuImprimir
            // 
            this.mnuImprimir.Name = "mnuImprimir";
            this.mnuImprimir.Size = new System.Drawing.Size(125, 22);
            this.mnuImprimir.Text = "Imprimir ";
            this.mnuImprimir.Click += new System.EventHandler(this.mnuImprimir_Click);
            // 
            // ViewPrincipal
            // 
            this.ViewPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EnvioIDColumn,
            this.NumeroDeEnvio,
            this.Fecha,
            this.TipoDePago,
            this.NombreCliente,
            this.Telefono,
            this.NIT,
            this.Direccion,
            this.Departamento,
            this.Municipio,
            this.Cantidad,
            this.SubTotal});
            this.ViewPrincipal.GridControl = this.grdEnvios;
            this.ViewPrincipal.Name = "ViewPrincipal";
            this.ViewPrincipal.OptionsBehavior.Editable = false;
            this.ViewPrincipal.OptionsBehavior.ReadOnly = true;
            this.ViewPrincipal.OptionsView.ShowGroupPanel = false;
            // 
            // EnvioIDColumn
            // 
            this.EnvioIDColumn.Caption = "EnvioID";
            this.EnvioIDColumn.FieldName = "EnvioID";
            this.EnvioIDColumn.Name = "EnvioIDColumn";
            this.EnvioIDColumn.Width = 40;
            // 
            // NumeroDeEnvio
            // 
            this.NumeroDeEnvio.Caption = "Envío No.";
            this.NumeroDeEnvio.FieldName = "NumeroDeEnvio";
            this.NumeroDeEnvio.Name = "NumeroDeEnvio";
            this.NumeroDeEnvio.Visible = true;
            this.NumeroDeEnvio.VisibleIndex = 0;
            this.NumeroDeEnvio.Width = 35;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 1;
            this.Fecha.Width = 45;
            // 
            // TipoDePago
            // 
            this.TipoDePago.Caption = "Tipo De Pago";
            this.TipoDePago.FieldName = "TipoDePago";
            this.TipoDePago.Name = "TipoDePago";
            this.TipoDePago.Visible = true;
            this.TipoDePago.VisibleIndex = 2;
            this.TipoDePago.Width = 45;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Caption = "Nombre Cliente";
            this.NombreCliente.FieldName = "NombreCliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Visible = true;
            this.NombreCliente.VisibleIndex = 3;
            this.NombreCliente.Width = 180;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Teléfono";
            this.Telefono.FieldName = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 4;
            this.Telefono.Width = 53;
            // 
            // NIT
            // 
            this.NIT.Caption = "NIT";
            this.NIT.FieldName = "NIT";
            this.NIT.Name = "NIT";
            this.NIT.Visible = true;
            this.NIT.VisibleIndex = 5;
            this.NIT.Width = 58;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Dirección";
            this.Direccion.FieldName = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = true;
            this.Direccion.VisibleIndex = 6;
            this.Direccion.Width = 169;
            // 
            // Departamento
            // 
            this.Departamento.Caption = "Departamento";
            this.Departamento.FieldName = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.Visible = true;
            this.Departamento.VisibleIndex = 7;
            this.Departamento.Width = 100;
            // 
            // Municipio
            // 
            this.Municipio.Caption = "Municipio";
            this.Municipio.FieldName = "Municipio";
            this.Municipio.Name = "Municipio";
            this.Municipio.Visible = true;
            this.Municipio.VisibleIndex = 8;
            this.Municipio.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.Caption = "Cantidad";
            this.Cantidad.FieldName = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Visible = true;
            this.Cantidad.VisibleIndex = 9;
            this.Cantidad.Width = 40;
            // 
            // SubTotal
            // 
            this.SubTotal.Caption = "Sub Total";
            this.SubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SubTotal.FieldName = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Visible = true;
            this.SubTotal.VisibleIndex = 10;
            this.SubTotal.Width = 26;
            // 
            // txtFechaInicial
            // 
            this.txtFechaInicial.EditValue = null;
            this.txtFechaInicial.EnterMoveNextControl = true;
            this.txtFechaInicial.Location = new System.Drawing.Point(17, 40);
            this.txtFechaInicial.Name = "txtFechaInicial";
            this.txtFechaInicial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFechaInicial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFechaInicial.Properties.Appearance.Options.UseBackColor = true;
            this.txtFechaInicial.Properties.Appearance.Options.UseFont = true;
            this.txtFechaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaInicial.Size = new System.Drawing.Size(113, 24);
            this.txtFechaInicial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha:";
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.EditValue = null;
            this.txtFechaFinal.EnterMoveNextControl = true;
            this.txtFechaFinal.Location = new System.Drawing.Point(136, 40);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFechaFinal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFechaFinal.Properties.Appearance.Options.UseBackColor = true;
            this.txtFechaFinal.Properties.Appearance.Options.UseFont = true;
            this.txtFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaFinal.Size = new System.Drawing.Size(113, 24);
            this.txtFechaFinal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha:";
            // 
            // cboClientes
            // 
            this.cboClientes.EnterMoveNextControl = true;
            this.cboClientes.Location = new System.Drawing.Point(255, 40);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboClientes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboClientes.Properties.Appearance.Options.UseBackColor = true;
            this.cboClientes.Properties.Appearance.Options.UseFont = true;
            this.cboClientes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClientes.Properties.NullText = "[Seleccione una opcion]";
            this.cboClientes.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboClientes.Size = new System.Drawing.Size(272, 24);
            this.cboClientes.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtFechaInicial);
            this.groupBox1.Controls.Add(this.cboClientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFechaFinal);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros de Busqueda:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::EuroLab.Properties.Resources.Metro_Search_Blue_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(533, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grdEnvios);
            this.panel1.Location = new System.Drawing.Point(4, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 399);
            this.panel1.TabIndex = 27;
            // 
            // FrmEnvioFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEnvioFiltro";
            this.Text = "FrmEnvioFiltro";
            this.Load += new System.EventHandler(this.FrmEnvioFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEnvios)).EndInit();
            this.mnuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdEnvios;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn EnvioIDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroDeEnvio;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraEditors.DateEdit txtFechaInicial;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit txtFechaFinal;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cboClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn TipoDePago;
        private DevExpress.XtraGrid.Columns.GridColumn NIT;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn Departamento;
        private DevExpress.XtraGrid.Columns.GridColumn Municipio;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn SubTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuGrabar;
        private System.Windows.Forms.ToolStripMenuItem mnuModificar;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuImprimir;
    }
}