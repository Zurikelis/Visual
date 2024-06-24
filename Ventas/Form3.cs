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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string[] Clientes()
        {
            string[] clientes = { dtgvClientes.CurrentRow.Cells[0].Value.ToString(), dtgvClientes.CurrentRow.Cells[1].Value.ToString()};
            return clientes;
        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            dtgvClientes.Rows.Add("9654", "Emil Carcamo");
            dtgvClientes.Rows.Add("3869", "Elizabet Alcantara");
            dtgvClientes.Rows.Add("2967", "Mario  Rivas");
            dtgvClientes.Rows.Add("1963", "Sofia Lesama");
            dtgvClientes.Rows.Add("0638", "Oscar Aguilar");
            dtgvClientes.Rows.Add("7364", "Numa Turcatti");
            
        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
