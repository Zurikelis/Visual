namespace Ventas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigoV = new System.Windows.Forms.TextBox();
            this.lblCodigoV = new System.Windows.Forms.Label();
            this.lblNombreV = new System.Windows.Forms.Label();
            this.txtCodigoC = new System.Windows.Forms.TextBox();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodigoC = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.btnBuscarV = new System.Windows.Forms.Button();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtgvPrincipal = new System.Windows.Forms.DataGridView();
            this.CodigoV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblContISV = new System.Windows.Forms.Label();
            this.lblTotalISV = new System.Windows.Forms.Label();
            this.lblSinISV = new System.Windows.Forms.Label();
            this.lblTotalNoISV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoV
            // 
            this.txtCodigoV.Location = new System.Drawing.Point(113, 61);
            this.txtCodigoV.Name = "txtCodigoV";
            this.txtCodigoV.Size = new System.Drawing.Size(132, 26);
            this.txtCodigoV.TabIndex = 0;
            // 
            // lblCodigoV
            // 
            this.lblCodigoV.AutoSize = true;
            this.lblCodigoV.Location = new System.Drawing.Point(25, 58);
            this.lblCodigoV.Name = "lblCodigoV";
            this.lblCodigoV.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoV.TabIndex = 1;
            this.lblCodigoV.Text = "Codigo";
            // 
            // lblNombreV
            // 
            this.lblNombreV.AutoSize = true;
            this.lblNombreV.Location = new System.Drawing.Point(274, 61);
            this.lblNombreV.Name = "lblNombreV";
            this.lblNombreV.Size = new System.Drawing.Size(65, 20);
            this.lblNombreV.TabIndex = 2;
            this.lblNombreV.Text = "Nombre";
            // 
            // txtCodigoC
            // 
            this.txtCodigoC.Location = new System.Drawing.Point(113, 158);
            this.txtCodigoC.Name = "txtCodigoC";
            this.txtCodigoC.Size = new System.Drawing.Size(132, 26);
            this.txtCodigoC.TabIndex = 4;
            // 
            // txtNombreV
            // 
            this.txtNombreV.Location = new System.Drawing.Point(345, 58);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.Size = new System.Drawing.Size(132, 26);
            this.txtNombreV.TabIndex = 5;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(25, 16);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(79, 20);
            this.lblVendedor.TabIndex = 7;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(25, 111);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCodigoC
            // 
            this.lblCodigoC.AutoSize = true;
            this.lblCodigoC.Location = new System.Drawing.Point(25, 164);
            this.lblCodigoC.Name = "lblCodigoC";
            this.lblCodigoC.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoC.TabIndex = 9;
            this.lblCodigoC.Text = "Codigo";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(263, 164);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(65, 20);
            this.lblNombreC.TabIndex = 10;
            this.lblNombreC.Text = "Nombre";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(345, 158);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(132, 26);
            this.txtNombreC.TabIndex = 12;
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.Location = new System.Drawing.Point(113, 5);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(87, 31);
            this.btnBuscarV.TabIndex = 14;
            this.btnBuscarV.Text = "Buscar";
            this.btnBuscarV.UseVisualStyleBackColor = true;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(113, 103);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(87, 36);
            this.btnBuscarC.TabIndex = 15;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(682, 5);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(89, 31);
            this.btnBuscarP.TabIndex = 16;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(760, 315);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 40);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(760, 397);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 41);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(578, 14);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 20);
            this.lblProducto.TabIndex = 19;
            this.lblProducto.Text = "Producto";
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Location = new System.Drawing.Point(578, 55);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoP.TabIndex = 20;
            this.lblCodigoP.Text = "Codigo";
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(578, 103);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(65, 20);
            this.lblNombreP.TabIndex = 21;
            this.lblNombreP.Text = "Nombre";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(534, 155);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(657, 49);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(132, 26);
            this.txtCodigoP.TabIndex = 23;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(657, 100);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(132, 26);
            this.txtNombreP.TabIndex = 24;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(620, 149);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(78, 26);
            this.txtCantidad.TabIndex = 25;
            // 
            // dtgvPrincipal
            // 
            this.dtgvPrincipal.AllowUserToAddRows = false;
            this.dtgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoV,
            this.NombreV,
            this.CodigoC,
            this.NombreC,
            this.CodigoP,
            this.NombreP,
            this.cantidad,
            this.precio,
            this.SubTotal,
            this.Impuesto});
            this.dtgvPrincipal.Location = new System.Drawing.Point(12, 210);
            this.dtgvPrincipal.Name = "dtgvPrincipal";
            this.dtgvPrincipal.RowHeadersWidth = 62;
            this.dtgvPrincipal.RowTemplate.Height = 28;
            this.dtgvPrincipal.Size = new System.Drawing.Size(730, 249);
            this.dtgvPrincipal.TabIndex = 26;
            this.dtgvPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPrincipal_CellClick);
            // 
            // CodigoV
            // 
            this.CodigoV.HeaderText = "Codigo Vendedor";
            this.CodigoV.MinimumWidth = 8;
            this.CodigoV.Name = "CodigoV";
            this.CodigoV.Width = 150;
            // 
            // NombreV
            // 
            this.NombreV.HeaderText = "Nombre Vendedor";
            this.NombreV.MinimumWidth = 8;
            this.NombreV.Name = "NombreV";
            this.NombreV.Width = 150;
            // 
            // CodigoC
            // 
            this.CodigoC.HeaderText = "Codigo Cliente";
            this.CodigoC.MinimumWidth = 8;
            this.CodigoC.Name = "CodigoC";
            this.CodigoC.Width = 150;
            // 
            // NombreC
            // 
            this.NombreC.HeaderText = "Nombre Cliente";
            this.NombreC.MinimumWidth = 8;
            this.NombreC.Name = "NombreC";
            this.NombreC.Width = 150;
            // 
            // CodigoP
            // 
            this.CodigoP.HeaderText = "Codigo Producto";
            this.CodigoP.MinimumWidth = 8;
            this.CodigoP.Name = "CodigoP";
            this.CodigoP.Width = 150;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Producto";
            this.NombreP.MinimumWidth = 8;
            this.NombreP.Name = "NombreP";
            this.NombreP.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 8;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 150;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 8;
            this.precio.Name = "precio";
            this.precio.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 8;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 150;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "ISV";
            this.Impuesto.MinimumWidth = 8;
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Width = 150;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(760, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 41);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(591, 473);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(718, 149);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 30;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(777, 149);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(78, 26);
            this.txtPrecio.TabIndex = 31;
            // 
            // lblContISV
            // 
            this.lblContISV.AutoSize = true;
            this.lblContISV.Location = new System.Drawing.Point(39, 473);
            this.lblContISV.Name = "lblContISV";
            this.lblContISV.Size = new System.Drawing.Size(77, 20);
            this.lblContISV.TabIndex = 32;
            this.lblContISV.Text = "Con ISV: ";
            // 
            // lblTotalISV
            // 
            this.lblTotalISV.AutoSize = true;
            this.lblTotalISV.Location = new System.Drawing.Point(437, 473);
            this.lblTotalISV.Name = "lblTotalISV";
            this.lblTotalISV.Size = new System.Drawing.Size(52, 20);
            this.lblTotalISV.TabIndex = 33;
            this.lblTotalISV.Text = "Total: ";
            // 
            // lblSinISV
            // 
            this.lblSinISV.AutoSize = true;
            this.lblSinISV.Location = new System.Drawing.Point(244, 473);
            this.lblSinISV.Name = "lblSinISV";
            this.lblSinISV.Size = new System.Drawing.Size(71, 20);
            this.lblSinISV.TabIndex = 34;
            this.lblSinISV.Text = "Sin ISV: ";
            // 
            // lblTotalNoISV
            // 
            this.lblTotalNoISV.AutoSize = true;
            this.lblTotalNoISV.Location = new System.Drawing.Point(458, 473);
            this.lblTotalNoISV.Name = "lblTotalNoISV";
            this.lblTotalNoISV.Size = new System.Drawing.Size(0, 20);
            this.lblTotalNoISV.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 527);
            this.Controls.Add(this.lblTotalNoISV);
            this.Controls.Add(this.lblSinISV);
            this.Controls.Add(this.lblTotalISV);
            this.Controls.Add(this.lblContISV);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgvPrincipal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.txtCodigoP);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreP);
            this.Controls.Add(this.lblCodigoP);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.btnBuscarV);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.lblCodigoC);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtNombreV);
            this.Controls.Add(this.txtCodigoC);
            this.Controls.Add(this.lblNombreV);
            this.Controls.Add(this.lblCodigoV);
            this.Controls.Add(this.txtCodigoV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoV;
        private System.Windows.Forms.Label lblCodigoV;
        private System.Windows.Forms.Label lblNombreV;
        private System.Windows.Forms.TextBox txtCodigoC;
        private System.Windows.Forms.TextBox txtNombreV;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCodigoC;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Button btnBuscarV;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dtgvPrincipal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label lblContISV;
        private System.Windows.Forms.Label lblTotalISV;
        private System.Windows.Forms.Label lblSinISV;
        private System.Windows.Forms.Label lblTotalNoISV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
    }
}

