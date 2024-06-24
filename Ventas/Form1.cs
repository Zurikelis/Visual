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
    public partial class Form1 : Form
    {
        int indice;
        Form2 traspaso;
        Form3 envio;
        Form4 recado;
        int cant;
        int monto;
        int preci;
        double subtotal;
        double total;
        string sub;
        double resta;
        double isv;
        string recolectar;
        int recolectar2;
        float si, sisi;
        float no, nono;
        string impuesto;
        double totaltotal;
        double restimp;
        double pasa;


        public Form1()
        {
            InitializeComponent();
            traspaso= new Form2();
            envio= new Form3();
            recado= new Form4();
        }
        
        void limpiar()
        {
           
            txtCodigoP.Clear();
            txtNombreP.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            btnGuardar.Text = "Guardar";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigoV.Text == "" || txtNombreV.Text == "" || txtCodigoC.Text == "" || txtNombreC.Text == "" || txtCodigoP.Text == "" || txtNombreP.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Antes de guardar rellene todos los campos");
            }
            else
            {
                cant = int.Parse(txtCantidad.Text);
                preci= int.Parse(txtPrecio.Text);
                monto = cant * preci;
                if (recolectar2 == 1)
                {
                    isv= monto*0.15;
                    subtotal += isv;
                    si += 1;
                    totaltotal = monto + isv;
                }
                else
                {
                    isv = 0;
                    no += 1;
                    totaltotal = monto + isv;
                }

                sub = Convert.ToString(monto);
                impuesto = Convert.ToString(isv);
                

                if (btnGuardar.Text == "Editar")
                {
                    restimp = double.Parse(dtgvPrincipal[9, indice].Value.ToString());
                    pasa = double.Parse(dtgvPrincipal[8, indice].Value.ToString());
                    resta = restimp+pasa;

                    total-=resta;
                    cant = int.Parse(txtCantidad.Text);
                    preci = int.Parse(txtPrecio.Text);
                    monto = cant * preci;
                    isv = monto * 0.15;
                    subtotal += isv;
                    if (recolectar2 == 1)
                    {
                        isv = monto * 0.15;
                        subtotal += isv;
                        
                        totaltotal = monto + isv;
                    }
                    else
                    {
                        isv = 0;
                        
                        totaltotal = monto + isv;
                    }



                    lblTotalISV.Text = Convert.ToString("Total Isv: " + subtotal);
                    lblTotal.Text = Convert.ToString(totaltotal);
                }

                
                total += totaltotal;
                lblTotal.Text = Convert.ToString("Total: "+ total);
                lblTotalISV.Text = Convert.ToString("Total Isv: "+subtotal);
                lblContISV.Text = Convert.ToString("Con ISV: "+si);
                lblSinISV.Text = Convert.ToString("Sin ISV: " + no);

                if (btnGuardar.Text == "Editar")
                {
                    dtgvPrincipal[0, indice].Value = txtCodigoV.Text;
                    dtgvPrincipal[1, indice].Value = txtNombreV.Text;
                    dtgvPrincipal[2, indice].Value = txtCodigoC.Text;
                    dtgvPrincipal[3, indice].Value = txtNombreC.Text;
                    dtgvPrincipal[4, indice].Value = txtCodigoP.Text;
                    dtgvPrincipal[5, indice].Value = txtNombreP.Text;
                    dtgvPrincipal[6, indice].Value = txtCantidad.Text;
                    dtgvPrincipal[7, indice].Value = txtPrecio.Text;
                    dtgvPrincipal[8, indice].Value = sub;
                    dtgvPrincipal[9, indice].Value = impuesto;
                    btnGuardar.Text = "Guardar";
                }
                else
                {

                    dtgvPrincipal.Rows.Add(txtCodigoV.Text, txtNombreV.Text, txtCodigoC.Text, txtNombreC.Text, txtCodigoP.Text, txtNombreP.Text, txtCantidad.Text, txtPrecio.Text,sub,impuesto);
                    limpiar();
                }
            }
        }

        private void dtgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dtgvPrincipal.CurrentRow.Index;
            txtCodigoV.Text = dtgvPrincipal.CurrentRow.Cells[0].Value.ToString();
            txtNombreV.Text = dtgvPrincipal.CurrentRow.Cells[1].Value.ToString();
            txtCodigoC.Text = dtgvPrincipal.CurrentRow.Cells[2].Value.ToString();
            txtNombreC.Text = dtgvPrincipal.CurrentRow.Cells[3].Value.ToString();
            txtCodigoP.Text = dtgvPrincipal.CurrentRow.Cells[4].Value.ToString();
            txtNombreP.Text = dtgvPrincipal.CurrentRow.Cells[5].Value.ToString();
            txtCantidad.Text = dtgvPrincipal.CurrentRow.Cells[6].Value.ToString();
            txtPrecio.Text = dtgvPrincipal.CurrentRow.Cells[7].Value.ToString();
            sub = dtgvPrincipal.CurrentRow.Cells[8].Value.ToString();
            impuesto = dtgvPrincipal.CurrentRow.Cells[9].Value.ToString();
            btnGuardar.Text = "Editar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvPrincipal.Rows.Count > 0)
            {
                restimp = double.Parse(dtgvPrincipal.CurrentRow.Cells[9].Value.ToString());
                pasa = double.Parse(dtgvPrincipal[8, indice].Value.ToString());
                resta = restimp + pasa;

                if (restimp > 0)
                {
                    si -= 1;
                    lblContISV.Text = Convert.ToString("Con ISV: " + si);
                }
                else
                {
                    no -= 1;
                    lblSinISV.Text = Convert.ToString("Sin ISV: " + no);
                }

                total -= resta;
                lblTotal.Text = Convert.ToString("Total: " + total);
                subtotal -= restimp;
                lblTotalISV.Text = Convert.ToString("Total Isv: " + subtotal);


                dtgvPrincipal.Rows.RemoveAt(dtgvPrincipal.CurrentRow.Index);
                limpiar();
            }
            else
            {
                MessageBox.Show("La tabla ya no contiene productos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            txtCodigoV.Clear();
            txtNombreV.Clear();
            txtCodigoC.Clear();
            txtNombreC.Clear();
        }

        private void btnBuscarV_Click(object sender, EventArgs e)
        {
            traspaso.ShowDialog();
            txtCodigoV.Text = traspaso.vendedores()[0];
            txtNombreV.Text = traspaso.vendedores()[1];

        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            envio.ShowDialog();
            txtCodigoC.Text = envio.Clientes()[0];
            txtNombreC.Text = envio.Clientes()[1];
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            recado.ShowDialog();
            txtCodigoP.Text = recado.productos()[0];
            txtNombreP.Text = recado.productos()[1];
            txtPrecio.Text = recado.productos()[2];
            recolectar = recado.productos()[3];
            recolectar2 = int.Parse(recolectar);
        }
    }
}
