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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string[] productos()
        {
            string[] preduc = { dtgvProductos.CurrentRow.Cells[0].Value.ToString(), dtgvProductos.CurrentRow.Cells[1].Value.ToString(), dtgvProductos.CurrentRow.Cells[2].Value.ToString(), dtgvProductos.CurrentRow.Cells[3].Value.ToString() };
            return preduc;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dtgvProductos.Rows.Add("H963", "Mochila", "840","1");
            dtgvProductos.Rows.Add("K839", "Libreta", "65","0");
            dtgvProductos.Rows.Add("L642", "Resma hojas Blancas", "350", "1");
            dtgvProductos.Rows.Add("M074", "Lapiz Carbon Caja", "72", "1");
            dtgvProductos.Rows.Add("M045", "Lapiz titan Caja", "90","0");
            dtgvProductos.Rows.Add("S397", "Cartulina Iris Paquete", "295", "1");
            dtgvProductos.Rows.Add("D637", "Juego de Reglas", "60", "1");
            dtgvProductos.Rows.Add("C865", "Cinta Rollo", "250","0");
            dtgvProductos.Rows.Add("W864", "MasKing tape Caja", "780","0");
            dtgvProductos.Rows.Add("Z487", "Marcadores Caja", "270", "1");
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
