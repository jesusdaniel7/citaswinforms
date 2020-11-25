using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectofinal1
{
    public partial class Clinicas : Form
    {
        string nombre, direccion;
        Datos obj = new Datos();

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                nombre = textBox1.Text;
                direccion = textBox2.Text;


                obj.GuardarClinica(nombre, direccion);
                MessageBox.Show("Se han guardado los datos");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally {
                textBox1.Text = "";
                textBox2.Text = "";

            }

            LlenarGridClinicas();
        }

        public Clinicas()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clinicas_Load(object sender, EventArgs e)
        {
            LlenarGridClinicas();
        }

        public void LlenarGridClinicas()
        {
            dataGridView1.DataSource = obj.LlenarGridClinicas();
        }
    }
}
