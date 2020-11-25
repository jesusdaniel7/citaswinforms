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
    public partial class ConsultarCitas : Form
    {
        string nombre, exequatur;
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
            nombre = textBox1.Text;
            dataGridView1.DataSource = obj.LlenarGridBuscarCit(nombre);
            textBox1.Text = "";


        }
        public ConsultarCitas()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultarPacientes_Load(object sender, EventArgs e)
        {
          LlenarGridProceso();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            exequatur = textBox2.Text;
            dataGridView1.DataSource = obj.LlenarGridBuscarCitExe(exequatur);
            textBox2.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LlenarGridProceso();
        }

        public void LlenarGridProceso()
        {
            dataGridView1.DataSource = obj.LlenarGridProceso();
        }

    }
}
