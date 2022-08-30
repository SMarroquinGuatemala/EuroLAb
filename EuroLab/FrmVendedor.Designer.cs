namespace EuroLab
{
    partial class FrmVendedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMunicipio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboDepartamento = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboMunicipio);
            this.panel1.Controls.Add(this.cboDepartamento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 439);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::EuroLab.Properties.Resources.Metro_Save_Blue_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(175, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Grabar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Municipio:";
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.EnterMoveNextControl = true;
            this.cboMunicipio.Location = new System.Drawing.Point(8, 357);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboMunicipio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboMunicipio.Properties.Appearance.Options.UseBackColor = true;
            this.cboMunicipio.Properties.Appearance.Options.UseFont = true;
            this.cboMunicipio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMunicipio.Properties.NullText = "[Seleccione una opcion]";
            this.cboMunicipio.Properties.PopupView = this.gridView3;
            this.cboMunicipio.Size = new System.Drawing.Size(269, 24);
            this.cboMunicipio.TabIndex = 6;
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
            this.cboDepartamento.Location = new System.Drawing.Point(8, 309);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboDepartamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboDepartamento.Properties.Appearance.Options.UseBackColor = true;
            this.cboDepartamento.Properties.Appearance.Options.UseFont = true;
            this.cboDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDepartamento.Properties.NullText = "[Seleccione una opcion]";
            this.cboDepartamento.Properties.PopupView = this.gridView2;
            this.cboDepartamento.Size = new System.Drawing.Size(269, 24);
            this.cboDepartamento.TabIndex = 5;
            this.cboDepartamento.EditValueChanged += new System.EventHandler(this.cboDepartamento_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Departamento:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(8, 218);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDireccion.Properties.Appearance.Options.UseBackColor = true;
            this.txtDireccion.Properties.WordWrap = false;
            this.txtDireccion.Size = new System.Drawing.Size(269, 67);
            this.txtDireccion.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Télefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.EnterMoveNextControl = true;
            this.txtTelefono.Location = new System.Drawing.Point(8, 170);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTelefono.Properties.Appearance.Options.UseBackColor = true;
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.Mask.EditMask = "n0";
            this.txtTelefono.Properties.MaxLength = 100;
            this.txtTelefono.Size = new System.Drawing.Size(269, 24);
            this.txtTelefono.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "NIT:";
            // 
            // txtNit
            // 
            this.txtNit.EnterMoveNextControl = true;
            this.txtNit.Location = new System.Drawing.Point(8, 122);
            this.txtNit.Name = "txtNit";
            this.txtNit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNit.Properties.Appearance.Options.UseBackColor = true;
            this.txtNit.Properties.Appearance.Options.UseFont = true;
            this.txtNit.Properties.Mask.EditMask = "n0";
            this.txtNit.Properties.MaxLength = 100;
            this.txtNit.Size = new System.Drawing.Size(269, 24);
            this.txtNit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.EnterMoveNextControl = true;
            this.txtApellidos.Location = new System.Drawing.Point(8, 74);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellidos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtApellidos.Properties.Appearance.Options.UseBackColor = true;
            this.txtApellidos.Properties.Appearance.Options.UseFont = true;
            this.txtApellidos.Properties.Mask.EditMask = "n0";
            this.txtApellidos.Properties.MaxLength = 100;
            this.txtApellidos.Size = new System.Drawing.Size(269, 24);
            this.txtApellidos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombres:";
            // 
            // txtNombre
            // 
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(8, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNombre.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.Mask.EditMask = "n0";
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Size = new System.Drawing.Size(269, 24);
            this.txtNombre.TabIndex = 0;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 443);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVendedor";
            this.Text = "FrmVendedor";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNit;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.MemoEdit txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit cboMunicipio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit cboDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}