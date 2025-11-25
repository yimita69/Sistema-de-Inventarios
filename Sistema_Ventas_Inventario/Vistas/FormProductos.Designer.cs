namespace Sistema_Ventas_Inventario.Vistas
{
    partial class FormProductos
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
<<<<<<< Updated upstream
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormProductos";
        }

        #endregion
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.gbActProducto = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbActPrecio = new System.Windows.Forms.TextBox();
            this.txtActIdProveedor = new System.Windows.Forms.Label();
            this.tbActDescripcion = new System.Windows.Forms.TextBox();
            this.tbActStock = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tbActNomProducto = new System.Windows.Forms.TextBox();
            this.tbActIdProducto = new System.Windows.Forms.TextBox();
            this.cbActProveedores = new System.Windows.Forms.ComboBox();
            this.txtActDescripcion = new System.Windows.Forms.Label();
            this.txtActPrecio = new System.Windows.Forms.Label();
            this.txtActIdProducto = new System.Windows.Forms.Label();
            this.txtActStock = new System.Windows.Forms.Label();
            this.txtActNomProducto = new System.Windows.Forms.Label();
            this.gbBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.tbBuscarProducto = new System.Windows.Forms.TextBox();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.txtNomProducto = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.tbNomProducto = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.idProveedor = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.gbAddUsuario = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbImagenProducto1 = new System.Windows.Forms.PictureBox();
            this.pbImagenProducto2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbActProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbBuscarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.gbAddUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActProducto
            // 
            this.gbActProducto.Controls.Add(this.button4);
            this.gbActProducto.Controls.Add(this.pbImagenProducto2);
            this.gbActProducto.Controls.Add(this.pictureBox5);
            this.gbActProducto.Controls.Add(this.pictureBox3);
            this.gbActProducto.Controls.Add(this.tbActPrecio);
            this.gbActProducto.Controls.Add(this.txtActIdProveedor);
            this.gbActProducto.Controls.Add(this.tbActDescripcion);
            this.gbActProducto.Controls.Add(this.tbActStock);
            this.gbActProducto.Controls.Add(this.btnActualizar);
            this.gbActProducto.Controls.Add(this.tbActNomProducto);
            this.gbActProducto.Controls.Add(this.tbActIdProducto);
            this.gbActProducto.Controls.Add(this.cbActProveedores);
            this.gbActProducto.Controls.Add(this.txtActDescripcion);
            this.gbActProducto.Controls.Add(this.txtActPrecio);
            this.gbActProducto.Controls.Add(this.txtActIdProducto);
            this.gbActProducto.Controls.Add(this.txtActStock);
            this.gbActProducto.Controls.Add(this.txtActNomProducto);
            this.gbActProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActProducto.Location = new System.Drawing.Point(490, 16);
            this.gbActProducto.Name = "gbActProducto";
            this.gbActProducto.Size = new System.Drawing.Size(389, 281);
            this.gbActProducto.TabIndex = 24;
            this.gbActProducto.TabStop = false;
            this.gbActProducto.Text = "Editar Producto";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(249, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 247);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // tbActPrecio
            // 
            this.tbActPrecio.BackColor = System.Drawing.Color.AliceBlue;
            this.tbActPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbActPrecio.Location = new System.Drawing.Point(265, 63);
            this.tbActPrecio.Name = "tbActPrecio";
            this.tbActPrecio.Size = new System.Drawing.Size(96, 20);
            this.tbActPrecio.TabIndex = 22;
            // 
            // txtActIdProveedor
            // 
            this.txtActIdProveedor.AutoSize = true;
            this.txtActIdProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActIdProveedor.Location = new System.Drawing.Point(267, 99);
            this.txtActIdProveedor.Name = "txtActIdProveedor";
            this.txtActIdProveedor.Size = new System.Drawing.Size(108, 17);
            this.txtActIdProveedor.TabIndex = 21;
            this.txtActIdProveedor.Text = "ID PROVEEDOR:";
            // 
            // tbActDescripcion
            // 
            this.tbActDescripcion.BackColor = System.Drawing.Color.AliceBlue;
            this.tbActDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbActDescripcion.Location = new System.Drawing.Point(28, 217);
            this.tbActDescripcion.Multiline = true;
            this.tbActDescripcion.Name = "tbActDescripcion";
            this.tbActDescripcion.Size = new System.Drawing.Size(202, 44);
            this.tbActDescripcion.TabIndex = 20;
            // 
            // tbActStock
            // 
            this.tbActStock.BackColor = System.Drawing.Color.AliceBlue;
            this.tbActStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbActStock.Location = new System.Drawing.Point(25, 163);
            this.tbActStock.Name = "tbActStock";
            this.tbActStock.Size = new System.Drawing.Size(202, 20);
            this.tbActStock.TabIndex = 12;
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(356, 241);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(33, 34);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // tbActNomProducto
            // 
            this.tbActNomProducto.BackColor = System.Drawing.Color.AliceBlue;
            this.tbActNomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbActNomProducto.Location = new System.Drawing.Point(25, 103);
            this.tbActNomProducto.Name = "tbActNomProducto";
            this.tbActNomProducto.Size = new System.Drawing.Size(202, 20);
            this.tbActNomProducto.TabIndex = 11;
            // 
            // tbActIdProducto
            // 
            this.tbActIdProducto.BackColor = System.Drawing.Color.AliceBlue;
            this.tbActIdProducto.Enabled = false;
            this.tbActIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbActIdProducto.Location = new System.Drawing.Point(25, 51);
            this.tbActIdProducto.Name = "tbActIdProducto";
            this.tbActIdProducto.Size = new System.Drawing.Size(202, 20);
            this.tbActIdProducto.TabIndex = 10;
            // 
            // cbActProveedores
            // 
            this.cbActProveedores.BackColor = System.Drawing.Color.AliceBlue;
            this.cbActProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbActProveedores.FormattingEnabled = true;
            this.cbActProveedores.Location = new System.Drawing.Point(265, 119);
            this.cbActProveedores.Name = "cbActProveedores";
            this.cbActProveedores.Size = new System.Drawing.Size(96, 21);
            this.cbActProveedores.TabIndex = 8;
            // 
            // txtActDescripcion
            // 
            this.txtActDescripcion.AutoSize = true;
            this.txtActDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActDescripcion.Location = new System.Drawing.Point(25, 199);
            this.txtActDescripcion.Name = "txtActDescripcion";
            this.txtActDescripcion.Size = new System.Drawing.Size(100, 17);
            this.txtActDescripcion.TabIndex = 7;
            this.txtActDescripcion.Text = "DESCRIPCION:";
            // 
            // txtActPrecio
            // 
            this.txtActPrecio.AutoSize = true;
            this.txtActPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActPrecio.Location = new System.Drawing.Point(267, 46);
            this.txtActPrecio.Name = "txtActPrecio";
            this.txtActPrecio.Size = new System.Drawing.Size(60, 17);
            this.txtActPrecio.TabIndex = 5;
            this.txtActPrecio.Text = "PRECIO:";
            // 
            // txtActIdProducto
            // 
            this.txtActIdProducto.AutoSize = true;
            this.txtActIdProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActIdProducto.Location = new System.Drawing.Point(22, 32);
            this.txtActIdProducto.Name = "txtActIdProducto";
            this.txtActIdProducto.Size = new System.Drawing.Size(25, 17);
            this.txtActIdProducto.TabIndex = 2;
            this.txtActIdProducto.Text = "ID:";
            // 
            // txtActStock
            // 
            this.txtActStock.AutoSize = true;
            this.txtActStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActStock.Location = new System.Drawing.Point(22, 143);
            this.txtActStock.Name = "txtActStock";
            this.txtActStock.Size = new System.Drawing.Size(53, 17);
            this.txtActStock.TabIndex = 4;
            this.txtActStock.Text = "STOCK:";
            this.txtActStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtActNomProducto
            // 
            this.txtActNomProducto.AutoSize = true;
            this.txtActNomProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActNomProducto.Location = new System.Drawing.Point(22, 90);
            this.txtActNomProducto.Name = "txtActNomProducto";
            this.txtActNomProducto.Size = new System.Drawing.Size(84, 17);
            this.txtActNomProducto.TabIndex = 3;
            this.txtActNomProducto.Text = "PRODUCTO:";
            // 
            // gbBuscarUsuario
            // 
            this.gbBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscarUsuario.Controls.Add(this.button2);
            this.gbBuscarUsuario.Controls.Add(this.btnMostrarProductos);
            this.gbBuscarUsuario.Controls.Add(this.txtBuscarProducto);
            this.gbBuscarUsuario.Controls.Add(this.btnBuscarProducto);
            this.gbBuscarUsuario.Controls.Add(this.tbBuscarProducto);
            this.gbBuscarUsuario.Location = new System.Drawing.Point(391, 297);
            this.gbBuscarUsuario.Name = "gbBuscarUsuario";
            this.gbBuscarUsuario.Size = new System.Drawing.Size(488, 52);
            this.gbBuscarUsuario.TabIndex = 25;
            this.gbBuscarUsuario.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(417, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 30);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarProductos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarProductos.Image")));
            this.btnMostrarProductos.Location = new System.Drawing.Point(385, 18);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(31, 26);
            this.btnMostrarProductos.TabIndex = 9;
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscarProducto.AutoSize = true;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(7, 24);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(133, 19);
            this.txtBuscarProducto.TabIndex = 6;
            this.txtBuscarProducto.Text = "Buscar Producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(335, 16);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(33, 30);
            this.btnBuscarProducto.TabIndex = 8;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // tbBuscarProducto
            // 
            this.tbBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarProducto.BackColor = System.Drawing.Color.AliceBlue;
            this.tbBuscarProducto.Location = new System.Drawing.Point(145, 23);
            this.tbBuscarProducto.Name = "tbBuscarProducto";
            this.tbBuscarProducto.Size = new System.Drawing.Size(184, 20);
            this.tbBuscarProducto.TabIndex = 7;
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToAddRows = false;
            this.DGVProductos.AllowUserToDeleteRows = false;
            this.DGVProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGVProductos.BackgroundColor = System.Drawing.Color.White;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(281, 350);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.ReadOnly = true;
            this.DGVProductos.RowHeadersWidth = 51;
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(598, 182);
            this.DGVProductos.TabIndex = 26;
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.AutoSize = true;
            this.txtNomProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNomProducto.Location = new System.Drawing.Point(25, 82);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(84, 17);
            this.txtNomProducto.TabIndex = 3;
            this.txtNomProducto.Text = "PRODUCTO:";
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStock.Location = new System.Drawing.Point(25, 135);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(53, 17);
            this.txtStock.TabIndex = 4;
            this.txtStock.Text = "STOCK:";
            this.txtStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.AutoSize = true;
            this.txtIdProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdProducto.Location = new System.Drawing.Point(25, 24);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(25, 17);
            this.txtIdProducto.TabIndex = 2;
            this.txtIdProducto.Text = "ID:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.Location = new System.Drawing.Point(266, 43);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(60, 17);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "PRECIO:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcion.Location = new System.Drawing.Point(25, 199);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 17);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "DESCRIPCION:";
            // 
            // cbProveedores
            // 
            this.cbProveedores.BackColor = System.Drawing.Color.AliceBlue;
            this.cbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(269, 119);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(91, 21);
            this.cbProveedores.TabIndex = 8;
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.BackColor = System.Drawing.Color.AliceBlue;
            this.tbIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbIdProducto.Location = new System.Drawing.Point(28, 43);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(202, 20);
            this.tbIdProducto.TabIndex = 10;
            // 
            // tbNomProducto
            // 
            this.tbNomProducto.BackColor = System.Drawing.Color.AliceBlue;
            this.tbNomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbNomProducto.Location = new System.Drawing.Point(28, 101);
            this.tbNomProducto.Name = "tbNomProducto";
            this.tbNomProducto.Size = new System.Drawing.Size(202, 20);
            this.tbNomProducto.TabIndex = 11;
            // 
            // tbStock
            // 
            this.tbStock.BackColor = System.Drawing.Color.AliceBlue;
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbStock.Location = new System.Drawing.Point(28, 155);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(202, 20);
            this.tbStock.TabIndex = 12;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.AliceBlue;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbDescripcion.Location = new System.Drawing.Point(28, 219);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(202, 42);
            this.tbDescripcion.TabIndex = 20;
            // 
            // idProveedor
            // 
            this.idProveedor.AutoSize = true;
            this.idProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idProveedor.Location = new System.Drawing.Point(266, 99);
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.Size = new System.Drawing.Size(108, 17);
            this.idProveedor.TabIndex = 21;
            this.idProveedor.Text = "ID PROVEEDOR:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.AliceBlue;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbPrecio.Location = new System.Drawing.Point(269, 63);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(93, 20);
            this.tbPrecio.TabIndex = 22;
            // 
            // gbAddUsuario
            // 
            this.gbAddUsuario.Controls.Add(this.button3);
            this.gbAddUsuario.Controls.Add(this.pbImagenProducto1);
            this.gbAddUsuario.Controls.Add(this.pictureBox4);
            this.gbAddUsuario.Controls.Add(this.pictureBox2);
            this.gbAddUsuario.Controls.Add(this.tbPrecio);
            this.gbAddUsuario.Controls.Add(this.idProveedor);
            this.gbAddUsuario.Controls.Add(this.tbDescripcion);
            this.gbAddUsuario.Controls.Add(this.tbStock);
            this.gbAddUsuario.Controls.Add(this.tbNomProducto);
            this.gbAddUsuario.Controls.Add(this.btnAgregar);
            this.gbAddUsuario.Controls.Add(this.tbIdProducto);
            this.gbAddUsuario.Controls.Add(this.cbProveedores);
            this.gbAddUsuario.Controls.Add(this.txtDescripcion);
            this.gbAddUsuario.Controls.Add(this.txtPrecio);
            this.gbAddUsuario.Controls.Add(this.txtIdProducto);
            this.gbAddUsuario.Controls.Add(this.txtStock);
            this.gbAddUsuario.Controls.Add(this.txtNomProducto);
            this.gbAddUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddUsuario.Location = new System.Drawing.Point(12, 16);
            this.gbAddUsuario.Name = "gbAddUsuario";
            this.gbAddUsuario.Size = new System.Drawing.Size(399, 281);
            this.gbAddUsuario.TabIndex = 22;
            this.gbAddUsuario.TabStop = false;
            this.gbAddUsuario.Text = "Agregar Producto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 247);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(349, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 34);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Sistema_Ventas_Inventario.Properties.Resources.arrow_back_30dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.button1.Location = new System.Drawing.Point(15, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 283);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(367, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(357, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pbImagenProducto1
            // 
            this.pbImagenProducto1.Location = new System.Drawing.Point(270, 199);
            this.pbImagenProducto1.Name = "pbImagenProducto1";
            this.pbImagenProducto1.Size = new System.Drawing.Size(92, 50);
            this.pbImagenProducto1.TabIndex = 26;
            this.pbImagenProducto1.TabStop = false;
            // 
            // pbImagenProducto2
            // 
            this.pbImagenProducto2.Location = new System.Drawing.Point(283, 199);
            this.pbImagenProducto2.Name = "pbImagenProducto2";
            this.pbImagenProducto2.Size = new System.Drawing.Size(86, 50);
            this.pbImagenProducto2.TabIndex = 29;
            this.pbImagenProducto2.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(291, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 46);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(300, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 46);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.gbBuscarUsuario);
            this.Controls.Add(this.gbActProducto);
            this.Controls.Add(this.gbAddUsuario);
            this.Name = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.gbActProducto.ResumeLayout(false);
            this.gbActProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbBuscarUsuario.ResumeLayout(false);
            this.gbBuscarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.gbAddUsuario.ResumeLayout(false);
            this.gbAddUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbActProducto;
        private System.Windows.Forms.TextBox tbActPrecio;
        private System.Windows.Forms.Label txtActIdProveedor;
        private System.Windows.Forms.TextBox tbActDescripcion;
        private System.Windows.Forms.TextBox tbActStock;
        private System.Windows.Forms.TextBox tbActNomProducto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox tbActIdProducto;
        private System.Windows.Forms.ComboBox cbActProveedores;
        private System.Windows.Forms.Label txtActDescripcion;
        private System.Windows.Forms.Label txtActPrecio;
        private System.Windows.Forms.Label txtActIdProducto;
        private System.Windows.Forms.Label txtActStock;
        private System.Windows.Forms.Label txtActNomProducto;
        private System.Windows.Forms.GroupBox gbBuscarUsuario;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Label txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox tbBuscarProducto;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Label txtNomProducto;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.Label txtIdProducto;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNomProducto;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label idProveedor;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.GroupBox gbAddUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbImagenProducto2;
        private System.Windows.Forms.PictureBox pbImagenProducto1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
>>>>>>> Stashed changes
    }
}