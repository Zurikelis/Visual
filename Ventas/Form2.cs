using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string[] vendedores()
        {
            string[] Vendedores = { dtgvVendedores.CurrentRow.Cells[0].Value.ToString(), dtgvVendedores.CurrentRow.Cells[1].Value.ToString() };
            return Vendedores;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dtgvVendedores.Rows.Add("8638", "Madgalena Diaz");
            dtgvVendedores.Rows.Add("9674", "Cristian Nuñez");
            dtgvVendedores.Rows.Add("7529", "Leonardo Zalazar");
            dtgvVendedores.Rows.Add("4296", "Andrea Osorto");
            dtgvVendedores.Rows.Add("3974", "Jose Moncada");
            dtgvVendedores.Rows.Add("8638", "Anyi Hernandez");

        }

        private void dtgvVendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
