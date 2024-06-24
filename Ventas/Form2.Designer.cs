namespace Ventas
{
    partial class Form2
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
            this.dtgvVendedores = new System.Windows.Forms.DataGridView();
            this.CodigosV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVendedores
            // 
            this.dtgvVendedores.AllowUserToAddRows = false;
            this.dtgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigosV,
            this.nombresV});
            this.dtgvVendedores.Location = new System.Drawing.Point(35, 59);
            this.dtgvVendedores.Name = "dtgvVendedores";
            this.dtgvVendedores.RowHeadersWidth = 62;
            this.dtgvVendedores.RowTemplate.Height = 28;
            this.dtgvVendedores.Size = new System.Drawing.Size(703, 464);
            this.dtgvVendedores.TabIndex = 0;
            this.dtgvVendedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVendedores_CellClick);
            // 
            // CodigosV
            // 
            this.CodigosV.HeaderText = "Codigos";
            this.CodigosV.MinimumWidth = 8;
            this.CodigosV.Name = "CodigosV";
            this.CodigosV.Width = 150;
            // 
            // nombresV
            // 
            this.nombresV.HeaderText = "Nombres";
            this.nombresV.MinimumWidth = 8;
            this.nombresV.Name = "nombresV";
            this.nombresV.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 558);
            this.Controls.Add(this.dtgvVendedores);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigosV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresV;
    }
}