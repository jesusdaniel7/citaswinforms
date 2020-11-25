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
    public partial class Medicos : Form
    {
        string cedula, exequátur, nombre, telefono, email, clinica;
        Datos obj = new Datos();

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Medicos_Load(object sender, EventArgs e)
        {
            LlenarGridMedicos();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                cedula = textBox1.Text;
                exequátur = textBox2.Text;
                nombre = textBox3.Text;
                telefono = textBox4.Text;
                email = textBox5.Text;
                clinica = textBox6.Text;

                obj.GuardarMedicos(cedula, exequátur, nombre, telefono, email, clinica);
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

            LlenarGridMedicos();
        }

        public Medicos()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void LlenarGridMedicos()
        {
            dataGridView1.DataSource = obj.LlenarGridMedicos();
        }
    }
}
