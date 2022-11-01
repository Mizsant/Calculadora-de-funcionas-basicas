using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea3
{
    public partial class Calculadora : Form
    {
        Operaciones Obj = new Operaciones();
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sumar1_Click(object sender, EventArgs e)
        {
            if (!Obj.Numerico(textBox1.Text) || !Obj.Numerico(textBox2.Text))
            {
                textBox3.Text = "INGRESE UN VALORE VALIDO";
            }
            else
            {
                int suma = Obj.suma(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox3.Text = suma.ToString();
            }
        }

        private void restar2_Click(object sender, EventArgs e)
        {
            if (!Obj.Numerico(textBox1.Text) || !Obj.Numerico(textBox2.Text))
            {
                textBox3.Text = "INGRESE UN VALORE VALIDO";
            }
            else
            {
                int resta = Obj.resta(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox3.Text = resta.ToString();
            }
        }

        private void multiplicar3_Click(object sender, EventArgs e)
        {
            if (!Obj.Numerico(textBox1.Text) || !Obj.Numerico(textBox2.Text))
            {
                textBox3.Text = "INGRESE UN VALORE VALIDO";
            }
            else
            {
                int multiplicar = Obj.multiplicar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox3.Text = multiplicar.ToString();
            }
        }

        private void dividir4_Click(object sender, EventArgs e)
        {
            if (!Obj.Numerico(textBox1.Text) || !Obj.Numerico(textBox2.Text))
            {
                textBox3.Text = "INGRESE UN VALORE VALIDO";
            }
            else
            {
                float divicion = Obj.divicion(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox3.Text = divicion.ToString();
            }
        }
    }
}
