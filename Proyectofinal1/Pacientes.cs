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
    public partial class Pacientes : Form
    {
        string cedula, nombre, telefono, email, direccion;
        Datos obj = new Datos();

        private void Pacientes_Load_1(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                cedula = textBox1.Text;
                nombre = textBox2.Text;
                telefono = textBox3.Text;
                email = textBox4.Text;
                direccion = textBox5.Text;

                obj.Guardar(cedula, nombre, telefono, email, direccion);
                MessageBox.Show("Se han guardado los datos");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }

            LlenarGrid();
        }

        public Pacientes()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void LlenarGrid()
        {
            dataGridView1.DataSource = obj.LlenarGrid();
        }
    }
}
