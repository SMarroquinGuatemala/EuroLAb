namespace EuroLab
{
    partial class FrmClienteFiltro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMunicipio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboDepartamento = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdCliente = new DevExpress.XtraGrid.GridControl();
            this.mnuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGrabar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrecioProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClienteID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Apellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.Departamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Municipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblRegsitrosProducto = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.mnuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboMunicipio);
            this.groupBox1.Controls.Add(this.cboDepartamento);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 76);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros de Busqueda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Municipio:";
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.EnterMoveNextControl = true;
            this.cboMunicipio.Location = new System.Drawing.Point(284, 38);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboMunicipio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboMunicipio.Properties.Appearance.Options.UseBackColor = true;
            this.cboMunicipio.Properties.Appearance.Options.UseFont = true;
            this.cboMunicipio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMunicipio.Properties.NullText = "[Seleccione una opcion]";
            this.cboMunicipio.Properties.PopupView = this.gridView3;
            this.cboMunicipio.Size = new System.Drawing.Size(272, 24);
            this.cboMunicipio.TabIndex = 2;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.EnterMoveNextControl = true;
            this.cboDepartamento.Location = new System.Drawing.Point(6, 38);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboDepartamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboDepartamento.Properties.Appearance.Options.UseBackColor = true;
            this.cboDepartamento.Properties.Appearance.Options.UseFont = true;
            this.cboDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDepartamento.Properties.NullText = "[Seleccione una opcion]";
            this.cboDepartamento.Properties.PopupView = this.gridView2;
            this.cboDepartamento.Size = new System.Drawing.Size(272, 24);
            this.cboDepartamento.TabIndex = 1;
            this.cboDepartamento.EditValueChanged += new System.EventHandler(this.cboDepartamento_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::EuroLab.Properties.Resources.Metro_Search_Blue_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(562, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento:";
            // 
            // grdCliente
            // 
            this.grdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCliente.ContextMenuStrip = this.mnuOpciones;
            this.grdCliente.Location = new System.Drawing.Point(4, 83);
            this.grdCliente.MainView = this.ViewPrincipal;
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.grdCliente.Size = new System.Drawing.Size(792, 340);
            this.grdCliente.TabIndex = 0;
            this.grdCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewPrincipal});
            this.grdCliente.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdCliente_MouseUp);
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGrabar,
            this.mnuModificar,
            this.mnuEliminar,
            this.toolStripSeparator1,
            this.mnuPrecioProducto});
            this.mnuOpciones.Name = "mnuOpciones";
            this.mnuOpciones.Size = new System.Drawing.Size(181, 120);
            // 
            // mnuGrabar
            // 
            this.mnuGrabar.Name = "mnuGrabar";
            this.mnuGrabar.Size = new System.Drawing.Size(180, 22);
            this.mnuGrabar.Text = "Grabar";
            this.mnuGrabar.Click += new System.EventHandler(this.mnuGrabar_Click);
            // 
            // mnuModificar
            // 
            this.mnuModificar.Name = "mnuModificar";
            this.mnuModificar.Size = new System.Drawing.Size(180, 22);
            this.mnuModificar.Text = "Modificar";
            this.mnuModificar.Click += new System.EventHandler(this.mnuModificar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(180, 22);
            this.mnuEliminar.Text = "Eliminar";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuPrecioProducto
            // 
            this.mnuPrecioProducto.Name = "mnuPrecioProducto";
            this.mnuPrecioProducto.Size = new System.Drawing.Size(180, 22);
            this.mnuPrecioProducto.Text = "Precio Producto";
            this.mnuPrecioProducto.Click += new System.EventHandler(this.precioClienteToolStripMenuItem_Click);
            // 
            // ViewPrincipal
            // 
            this.ViewPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClienteID,
            this.Nombres,
            this.Apellidos,
            this.Telefono,
            this.NIT,
            this.Direccion,
            this.Departamento,
            this.Municipio});
            this.ViewPrincipal.GridControl = this.grdCliente;
            this.ViewPrincipal.Name = "ViewPrincipal";
            this.ViewPrincipal.OptionsBehavior.Editable = false;
            this.ViewPrincipal.OptionsBehavior.ReadOnly = true;
            this.ViewPrincipal.OptionsView.RowAutoHeight = true;
            this.ViewPrincipal.OptionsView.ShowGroupPanel = false;
            // 
            // ClienteID
            // 
            this.ClienteID.Caption = "ClienteID";
            this.ClienteID.FieldName = "ClienteID";
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.Width = 40;
            // 
            // Nombres
            // 
            this.Nombres.Caption = "Nombres";
            this.Nombres.FieldName = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Visible = true;
            this.Nombres.VisibleIndex = 0;
            this.Nombres.Width = 45;
            // 
            // Apellidos
            // 
            this.Apellidos.Caption = "Apellidos";
            this.Apellidos.FieldName = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Visible = true;
            this.Apellidos.VisibleIndex = 1;
            this.Apellidos.Width = 35;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Teléfono";
            this.Telefono.FieldName = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 2;
            // 
            // NIT
            // 
            this.NIT.Caption = "NIT";
            this.NIT.FieldName = "NIT";
            this.NIT.Name = "NIT";
            this.NIT.Visible = true;
            this.NIT.VisibleIndex = 3;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Dirección";
            this.Direccion.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Direccion.FieldName = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = true;
            this.Direccion.VisibleIndex = 4;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // Departamento
            // 
            this.Departamento.Caption = "Departamento";
            this.Departamento.FieldName = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.Visible = true;
            this.Departamento.VisibleIndex = 5;
            // 
            // Municipio
            // 
            this.Municipio.Caption = "Municipio";
            this.Municipio.FieldName = "Municipio";
            this.Municipio.Name = "Municipio";
            this.Municipio.Visible = true;
            this.Municipio.VisibleIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegsitrosProducto,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblRegsitrosProducto
            // 
            this.lblRegsitrosProducto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblRegsitrosProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRegsitrosProducto.Name = "lblRegsitrosProducto";
            this.lblRegsitrosProducto.Size = new System.Drawing.Size(18, 22);
            this.lblRegsitrosProducto.Text = "0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Registros:";
            // 
            // FrmClienteFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmClienteFiltro";
            this.Text = "FrmClienteFiltrocs";
            this.Load += new System.EventHandler(this.FrmClienteFiltro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.mnuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit cboMunicipio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit cboDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn ClienteID;
        private DevExpress.XtraGrid.Columns.GridColumn Apellidos;
        private DevExpress.XtraGrid.Columns.GridColumn Nombres;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Departamento;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblRegsitrosProducto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.Columns.GridColumn NIT;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraGrid.Columns.GridColumn Municipio;
        private System.Windows.Forms.ContextMenuStrip mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuGrabar;
        private System.Windows.Forms.ToolStripMenuItem mnuModificar;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuPrecioProducto;
    }
}