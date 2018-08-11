namespace PuntoVenta
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNConsultar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.CBXEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DTPFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NDUDescuento = new System.Windows.Forms.NumericUpDown();
            this.NUDImpuesto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTPrecioCompra = new System.Windows.Forms.TextBox();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DTGDatos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTCNSDescripcion = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NDUDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDImpuesto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.CBXEstado);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.DTPFechaRegistro);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.NDUDescuento);
            this.tabPage1.Controls.Add(this.NUDImpuesto);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TXTPrecioCompra);
            this.tabPage1.Controls.Add(this.TXTDescripcion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TXTCodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNCancelar);
            this.groupBox1.Controls.Add(this.BTNConsultar);
            this.groupBox1.Controls.Add(this.BTNEliminar);
            this.groupBox1.Controls.Add(this.BTNModificar);
            this.groupBox1.Controls.Add(this.BTNAgregar);
            this.groupBox1.Location = new System.Drawing.Point(64, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNCancelar.Image = global::PuntoVenta.Properties.Resources._16__Cancel_;
            this.BTNCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCancelar.Location = new System.Drawing.Point(694, 26);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(166, 68);
            this.BTNCancelar.TabIndex = 4;
            this.BTNCancelar.TabStop = false;
            this.BTNCancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.BTNCancelar, "Click para limpiar la pantalla");
            this.BTNCancelar.UseVisualStyleBackColor = false;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNConsultar
            // 
            this.BTNConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNConsultar.Image = global::PuntoVenta.Properties.Resources._16__Search_;
            this.BTNConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNConsultar.Location = new System.Drawing.Point(6, 26);
            this.BTNConsultar.Name = "BTNConsultar";
            this.BTNConsultar.Size = new System.Drawing.Size(166, 68);
            this.BTNConsultar.TabIndex = 3;
            this.BTNConsultar.Text = "Consultar";
            this.toolTip1.SetToolTip(this.BTNConsultar, "Click para consultar un producto");
            this.BTNConsultar.UseVisualStyleBackColor = true;
            this.BTNConsultar.Click += new System.EventHandler(this.BTNConsultar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNEliminar.Image = global::PuntoVenta.Properties.Resources._16__Db_delete_;
            this.BTNEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEliminar.Location = new System.Drawing.Point(522, 26);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(166, 68);
            this.BTNEliminar.TabIndex = 2;
            this.BTNEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.BTNEliminar, "Click para eliminar un producto");
            this.BTNEliminar.UseVisualStyleBackColor = false;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNModificar.Image = global::PuntoVenta.Properties.Resources._16__Edit_1;
            this.BTNModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNModificar.Location = new System.Drawing.Point(350, 26);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(166, 68);
            this.BTNModificar.TabIndex = 1;
            this.BTNModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.BTNModificar, "Click para modificar un producto");
            this.BTNModificar.UseVisualStyleBackColor = false;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNAgregar.Image = global::PuntoVenta.Properties.Resources._16__Save_;
            this.BTNAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAgregar.Location = new System.Drawing.Point(178, 26);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(166, 68);
            this.BTNAgregar.TabIndex = 0;
            this.BTNAgregar.Text = "Agregar";
            this.toolTip1.SetToolTip(this.BTNAgregar, "Click para agregar un producto");
            this.BTNAgregar.UseVisualStyleBackColor = false;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // CBXEstado
            // 
            this.CBXEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXEstado.FormattingEnabled = true;
            this.CBXEstado.Items.AddRange(new object[] {
            "Activo.",
            "Nulo."});
            this.CBXEstado.Location = new System.Drawing.Point(215, 186);
            this.CBXEstado.Name = "CBXEstado";
            this.CBXEstado.Size = new System.Drawing.Size(192, 28);
            this.CBXEstado.TabIndex = 18;
            this.toolTip1.SetToolTip(this.CBXEstado, "Seleccione el estado del producto");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Estado";
            // 
            // DTPFechaRegistro
            // 
            this.DTPFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFechaRegistro.Location = new System.Drawing.Point(215, 138);
            this.DTPFechaRegistro.Name = "DTPFechaRegistro";
            this.DTPFechaRegistro.Size = new System.Drawing.Size(192, 27);
            this.DTPFechaRegistro.TabIndex = 16;
            this.toolTip1.SetToolTip(this.DTPFechaRegistro, "Fecha de registro del producto");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Registrado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Impuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descuento";
            // 
            // NDUDescuento
            // 
            this.NDUDescuento.Location = new System.Drawing.Point(557, 94);
            this.NDUDescuento.Name = "NDUDescuento";
            this.NDUDescuento.Size = new System.Drawing.Size(53, 27);
            this.NDUDescuento.TabIndex = 11;
            this.toolTip1.SetToolTip(this.NDUDescuento, "Seleccione el descuento del producto");
            // 
            // NUDImpuesto
            // 
            this.NUDImpuesto.Location = new System.Drawing.Point(730, 94);
            this.NUDImpuesto.Name = "NUDImpuesto";
            this.NUDImpuesto.Size = new System.Drawing.Size(53, 27);
            this.NUDImpuesto.TabIndex = 10;
            this.toolTip1.SetToolTip(this.NUDImpuesto, "Seleccione el impuesto del producto");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio Compra";
            // 
            // TXTPrecioCompra
            // 
            this.TXTPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXTPrecioCompra.Location = new System.Drawing.Point(215, 93);
            this.TXTPrecioCompra.Name = "TXTPrecioCompra";
            this.TXTPrecioCompra.Size = new System.Drawing.Size(100, 27);
            this.TXTPrecioCompra.TabIndex = 5;
            this.toolTip1.SetToolTip(this.TXTPrecioCompra, "Agregue un precio al producto");
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXTDescripcion.Location = new System.Drawing.Point(557, 46);
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(325, 27);
            this.TXTDescripcion.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TXTDescripcion, "Agregue una descripcion para el producto");
            this.TXTDescripcion.TextChanged += new System.EventHandler(this.TXTDescripcion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // TXTCodigo
            // 
            this.TXTCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXTCodigo.Location = new System.Drawing.Point(215, 46);
            this.TXTCodigo.Name = "TXTCodigo";
            this.TXTCodigo.Size = new System.Drawing.Size(192, 27);
            this.TXTCodigo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TXTCodigo, "Ingrese el codigo del producto");
            this.TXTCodigo.TextChanged += new System.EventHandler(this.TXTCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de producto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Búsqueda de productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.DTGDatos);
            this.groupBox3.Location = new System.Drawing.Point(8, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1027, 207);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de resultado";
            // 
            // DTGDatos
            // 
            this.DTGDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGDatos.Location = new System.Drawing.Point(3, 23);
            this.DTGDatos.Name = "DTGDatos";
            this.DTGDatos.Size = new System.Drawing.Size(1021, 181);
            this.DTGDatos.TabIndex = 0;
            this.DTGDatos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DTGDatos_RowHeaderMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTCNSDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1027, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro de busqueda por descripcion";
            // 
            // TXTCNSDescripcion
            // 
            this.TXTCNSDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTCNSDescripcion.Location = new System.Drawing.Point(18, 38);
            this.TXTCNSDescripcion.Name = "TXTCNSDescripcion";
            this.TXTCNSDescripcion.Size = new System.Drawing.Size(453, 27);
            this.TXTCNSDescripcion.TabIndex = 0;
            this.TXTCNSDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCNSDescripcion_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Mensaje";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 372);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo para productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NDUDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDImpuesto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TXTPrecioCompra;
        private System.Windows.Forms.TextBox TXTDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NDUDescuento;
        private System.Windows.Forms.NumericUpDown NUDImpuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBXEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTPFechaRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNConsultar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DTGDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTCNSDescripcion;
    }
}