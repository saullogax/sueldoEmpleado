using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace pjSueldoEmpleado
{
    public partial class Form1 : Form
    {
        static string[] categoria = { "Simple", "Profesional" };
        ArrayList aCategoria = new ArrayList(categoria);
        Sueldo NSueldo = new Sueldo();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenaCategoria();
           
        }
        void llenaCategoria()
        {
            foreach (string p in aCategoria)
            {
                cboCategoria.Items.Add(p);
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            NSueldo.categoria = cboCategoria.Text;
            lblPrecio.Text = NSueldo.asignaSueldo().ToString();
            
            

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            NSueldo.horas = int.Parse(txtHorasT.Text);
            

            this.dgvSaldo.Rows.Add(txtEmpleado.Text, NSueldo.categoria, NSueldo.horas, NSueldo.asignaSueldo(), NSueldo.calculaBruto(), NSueldo.calculaDescuento(), NSueldo.calculaNeto());

            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            cboCategoria.Text = ("Seleccione una categoría");
            txtHorasT.Clear();
            txtEmpleado.Focus();
            lblPrecio.Text = ("00");
            dgvSaldo.Rows.Clear();
        }

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) this.Close();
            
            if (Char.IsControl(e.KeyChar))
            
                e.Handled = false;
            
            else if (Char.IsDigit(e.KeyChar))
            
                e.Handled=false;
            
            else if (Char.IsNumber(e.KeyChar))
            
                e.Handled = false;
            
            else if (Char.IsSymbol(e.KeyChar))
            
                e.Handled = true;
            
            else if (Char.IsPunctuation(e.KeyChar))
            
                e.Handled = true;
            

        }

        private void txtHorasT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) this.Close();

            if (Char.IsControl(e.KeyChar))

                e.Handled = false;

            else if (Char.IsDigit(e.KeyChar))

                e.Handled = false;

            else if (Char.IsLetter(e.KeyChar))

                e.Handled = true;

            else if (Char.IsSymbol(e.KeyChar))

                e.Handled = false;

            else if (Char.IsPunctuation(e.KeyChar))

                e.Handled = true;
        }

        

        

    }
}
