namespace EuroLab
{
    partial class FrmProductoFiltro
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
            this.button1 = new System.Windows.Forms.Button();
            this.cboGrupoProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grdProducto = new DevExpress.XtraGrid.GridControl();
            this.mnuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGrabar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrecioCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.Precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblRegsitrosProducto = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGrupoProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).BeginInit();
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboGrupoProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros de Busqueda:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::EuroLab.Properties.Resources.Metro_Search_Blue_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(284, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboGrupoProducto
            // 
            this.cboGrupoProducto.EnterMoveNextControl = true;
            this.cboGrupoProducto.Location = new System.Drawing.Point(6, 38);
            this.cboGrupoProducto.Name = "cboGrupoProducto";
            this.cboGrupoProducto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboGrupoProducto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboGrupoProducto.Properties.Appearance.Options.UseBackColor = true;
            this.cboGrupoProducto.Properties.Appearance.Options.UseFont = true;
            this.cboGrupoProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGrupoProducto.Properties.NullText = "[Seleccione una opcion]";
            this.cboGrupoProducto.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboGrupoProducto.Size = new System.Drawing.Size(272, 24);
            this.cboGrupoProducto.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Grupo:";
            // 
            // grdProducto
            // 
            this.grdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProducto.ContextMenuStrip = this.mnuOpciones;
            this.grdProducto.Location = new System.Drawing.Point(4, 82);
            this.grdProducto.MainView = this.ViewPrincipal;
            this.grdProducto.Name = "grdProducto";
            this.grdProducto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.grdProducto.Size = new System.Drawing.Size(792, 340);
            this.grdProducto.TabIndex = 1;
            this.grdProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewPrincipal});
            this.grdProducto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdProducto_MouseUp);
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGrabar,
            this.mnuModificar,
            this.mnuEliminar,
            this.toolStripSeparator1,
            this.mnuPrecioCliente});
            this.mnuOpciones.Name = "mnuOpciones";
            this.mnuOpciones.Size = new System.Drawing.Size(148, 98);
            // 
            // mnuGrabar
            // 
            this.mnuGrabar.Name = "mnuGrabar";
            this.mnuGrabar.Size = new System.Drawing.Size(147, 22);
            this.mnuGrabar.Text = "Grabar";
            this.mnuGrabar.Click += new System.EventHandler(this.mnuGrabar_Click);
            // 
            // mnuModificar
            // 
            this.mnuModificar.Name = "mnuModificar";
            this.mnuModificar.Size = new System.Drawing.Size(147, 22);
            this.mnuModificar.Text = "Modificar";
            this.mnuModificar.Click += new System.EventHandler(this.mnuModificar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(147, 22);
            this.mnuEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // mnuPrecioCliente
            // 
            this.mnuPrecioCliente.Name = "mnuPrecioCliente";
            this.mnuPrecioCliente.Size = new System.Drawing.Size(147, 22);
            this.mnuPrecioCliente.Text = "Precio Cliente";
            this.mnuPrecioCliente.Click += new System.EventHandler(this.precioClienteToolStripMenuItem_Click);
            // 
            // ViewPrincipal
            // 
            this.ViewPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductoID,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Grupo});
            this.ViewPrincipal.GridControl = this.grdProducto;
            this.ViewPrincipal.Name = "ViewPrincipal";
            this.ViewPrincipal.OptionsBehavior.Editable = false;
            this.ViewPrincipal.OptionsBehavior.ReadOnly = true;
            this.ViewPrincipal.OptionsView.RowAutoHeight = true;
            this.ViewPrincipal.OptionsView.ShowGroupPanel = false;
            // 
            // ProductoID
            // 
            this.ProductoID.Caption = "ProductoID";
            this.ProductoID.FieldName = "ProductoID";
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.Width = 40;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 35;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            this.Nombre.Width = 45;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripción";
            this.Descripcion.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 2;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // Precio
            // 
            this.Precio.Caption = "Precio";
            this.Precio.FieldName = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Visible = true;
            this.Precio.VisibleIndex = 3;
            this.Precio.Width = 45;
            // 
            // Grupo
            // 
            this.Grupo.Caption = "Grupo";
            this.Grupo.FieldName = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.Visible = true;
            this.Grupo.VisibleIndex = 4;
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
            this.toolStrip1.TabIndex = 30;
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
            // FrmProductoFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdProducto);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProductoFiltro";
            this.Text = "FrmProductoFiltro";
            this.Load += new System.EventHandler(this.FrmProductoFiltro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGrupoProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).EndInit();
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
        private DevExpress.XtraEditors.SearchLookUpEdit cboGrupoProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grdProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn ProductoID;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Precio;
        private DevExpress.XtraGrid.Columns.GridColumn Grupo;
        private System.Windows.Forms.ContextMenuStrip mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuGrabar;
        private System.Windows.Forms.ToolStripMenuItem mnuModificar;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblRegsitrosProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuPrecioCliente;
    }
}