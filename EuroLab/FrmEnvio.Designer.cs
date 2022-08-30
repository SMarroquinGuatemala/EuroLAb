namespace EuroLab
{
    partial class FrmEnvio
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
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnvio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClientes = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboVendedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDepartamento = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMunicipio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoDePago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EnvioDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdArticulos = new DevExpress.XtraGrid.GridControl();
            this.MnuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblTotalEnvio = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoDePago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            this.MnuOpciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deFecha
            // 
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(6, 28);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deFecha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.deFecha.Properties.Appearance.Options.UseBackColor = true;
            this.deFecha.Properties.Appearance.Options.UseFont = true;
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Size = new System.Drawing.Size(138, 24);
            this.deFecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // txtEnvio
            // 
            this.txtEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnvio.Location = new System.Drawing.Point(571, 26);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.Size = new System.Drawing.Size(100, 26);
            this.txtEnvio.TabIndex = 3;
            this.txtEnvio.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Envio No.:";
            // 
            // cboClientes
            // 
            this.cboClientes.Location = new System.Drawing.Point(6, 76);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboClientes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboClientes.Properties.Appearance.Options.UseBackColor = true;
            this.cboClientes.Properties.Appearance.Options.UseFont = true;
            this.cboClientes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClientes.Properties.NullText = "[Seleccione una opcion]";
            this.cboClientes.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboClientes.Size = new System.Drawing.Size(272, 24);
            this.cboClientes.TabIndex = 1;
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
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vendedor:";
            // 
            // cboVendedor
            // 
            this.cboVendedor.Location = new System.Drawing.Point(284, 76);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboVendedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboVendedor.Properties.Appearance.Options.UseBackColor = true;
            this.cboVendedor.Properties.Appearance.Options.UseFont = true;
            this.cboVendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVendedor.Properties.NullText = "[Seleccione una opcion]";
            this.cboVendedor.Properties.PopupView = this.gridView1;
            this.cboVendedor.Size = new System.Drawing.Size(272, 24);
            this.cboVendedor.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departamento:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.Location = new System.Drawing.Point(6, 124);
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
            this.cboDepartamento.TabIndex = 3;
            this.cboDepartamento.EditValueChanged += new System.EventHandler(this.cboDepartamento_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Municipio:";
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.Location = new System.Drawing.Point(284, 124);
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
            this.cboMunicipio.TabIndex = 4;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo de Pago:";
            // 
            // cboTipoDePago
            // 
            this.cboTipoDePago.Location = new System.Drawing.Point(6, 172);
            this.cboTipoDePago.Name = "cboTipoDePago";
            this.cboTipoDePago.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboTipoDePago.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboTipoDePago.Properties.Appearance.Options.UseBackColor = true;
            this.cboTipoDePago.Properties.Appearance.Options.UseFont = true;
            this.cboTipoDePago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTipoDePago.Properties.NullText = "[Seleccione una opcion]";
            this.cboTipoDePago.Properties.PopupView = this.gridView4;
            this.cboTipoDePago.Size = new System.Drawing.Size(272, 24);
            this.cboTipoDePago.TabIndex = 5;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(284, 172);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtEnvio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.deFecha);
            this.panel1.Controls.Add(this.cboTipoDePago);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboClientes);
            this.panel1.Controls.Add(this.cboMunicipio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboVendedor);
            this.panel1.Controls.Add(this.cboDepartamento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 205);
            this.panel1.TabIndex = 0;
            // 
            // ViewPrincipal
            // 
            this.ViewPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EnvioDetalle,
            this.ProductoID,
            this.Cantidad,
            this.Nombre,
            this.Precio,
            this.SubTotal});
            this.ViewPrincipal.GridControl = this.grdArticulos;
            this.ViewPrincipal.Name = "ViewPrincipal";
            this.ViewPrincipal.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.ViewPrincipal.OptionsBehavior.Editable = false;
            this.ViewPrincipal.OptionsBehavior.ReadOnly = true;
            this.ViewPrincipal.OptionsView.ShowGroupPanel = false;
            // 
            // EnvioDetalle
            // 
            this.EnvioDetalle.Caption = "EnvioDetalle";
            this.EnvioDetalle.FieldName = "EnvioDetalle";
            this.EnvioDetalle.Name = "EnvioDetalle";
            // 
            // ProductoID
            // 
            this.ProductoID.Caption = "ProductoID";
            this.ProductoID.FieldName = "ProductoID";
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.Width = 50;
            // 
            // Cantidad
            // 
            this.Cantidad.Caption = "Cantidad";
            this.Cantidad.FieldName = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Visible = true;
            this.Cantidad.VisibleIndex = 0;
            this.Cantidad.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Descripcion";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            this.Nombre.Width = 250;
            // 
            // Precio
            // 
            this.Precio.Caption = "Precio Unitario";
            this.Precio.FieldName = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Visible = true;
            this.Precio.VisibleIndex = 2;
            this.Precio.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.Caption = "Sub Total";
            this.SubTotal.FieldName = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Visible = true;
            this.SubTotal.VisibleIndex = 3;
            this.SubTotal.Width = 90;
            // 
            // grdArticulos
            // 
            this.grdArticulos.ContextMenuStrip = this.MnuOpciones;
            this.grdArticulos.Location = new System.Drawing.Point(6, 336);
            this.grdArticulos.MainView = this.ViewPrincipal;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.Size = new System.Drawing.Size(678, 400);
            this.grdArticulos.TabIndex = 0;
            this.grdArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewPrincipal});
            // 
            // MnuOpciones
            // 
            this.MnuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEliminar});
            this.MnuOpciones.Name = "MnuOpciones";
            this.MnuOpciones.Size = new System.Drawing.Size(118, 26);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(117, 22);
            this.mnuEliminar.Text = "Eliminar";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 224);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales de Envio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(6, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 82);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Envio";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.TxtCantidad);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboProducto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 63);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(581, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(281, 26);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtCantidad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtCantidad.Properties.Appearance.Options.UseBackColor = true;
            this.TxtCantidad.Properties.Appearance.Options.UseFont = true;
            this.TxtCantidad.Properties.Mask.EditMask = "n0";
            this.TxtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtCantidad.Size = new System.Drawing.Size(100, 24);
            this.TxtCantidad.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(497, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::EuroLab.Properties.Resources.Button_Add_blue_32;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(387, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 45);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cantidad:";
            // 
            // cboProducto
            // 
            this.cboProducto.Location = new System.Drawing.Point(3, 26);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboProducto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboProducto.Properties.Appearance.Options.UseBackColor = true;
            this.cboProducto.Properties.Appearance.Options.UseFont = true;
            this.cboProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProducto.Properties.NullText = "[Seleccione una opcion]";
            this.cboProducto.Properties.PopupView = this.gridView6;
            this.cboProducto.Size = new System.Drawing.Size(272, 24);
            this.cboProducto.TabIndex = 0;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Producto:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalEnvio,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 739);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblTotalEnvio
            // 
            this.lblTotalEnvio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblTotalEnvio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalEnvio.Name = "lblTotalEnvio";
            this.lblTotalEnvio.Size = new System.Drawing.Size(19, 22);
            this.lblTotalEnvio.Text = "0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel1.Text = "Total Envio:";
            // 
            // FrmEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 764);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdArticulos);
            this.Name = "FrmEnvio";
            this.Text = "Envio Eurolab";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoDePago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            this.MnuOpciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit deFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnvio;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cboClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SearchLookUpEdit cboVendedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SearchLookUpEdit cboDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit cboMunicipio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SearchLookUpEdit cboTipoDePago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewPrincipal;
        private DevExpress.XtraGrid.GridControl grdArticulos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SearchLookUpEdit cboProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private DevExpress.XtraGrid.Columns.GridColumn ProductoID;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Precio;
        private DevExpress.XtraGrid.Columns.GridColumn SubTotal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblTotalEnvio;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraEditors.TextEdit TxtCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip MnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn EnvioDetalle;
    }
}

