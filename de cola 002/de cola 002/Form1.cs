
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_cola_002
{
    public partial class Form1 : Form
    {
        public decola c = new decola();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (c.Llena()) MessageBox.Show("la cola ya esta llena ");
            else
            {
                c.Insertar(x);
                listBox1.Items.Add(x);

            }
            textBox1.Clear();
            textBox1.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (c.Llena()) MessageBox.Show("la pila esta llena ");
            else
            {
                c.Insertar(x);
                listBox1.Items.Insert(0,x);

            }

            textBox1.Clear();
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string x;
            if (c.Vacia()) MessageBox.Show("la cola ya esta vacia ");
            else
            {
               x= c.Eliminar();
                listBox1.Items.Remove(x);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string x;
            if (c.Vacia()) MessageBox.Show("la cola esta vacia ");
            else {
                x = c.Eliminar();
                listBox1.Items.RemoveAt(c.ultimo);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
