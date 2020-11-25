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
    public partial class Proceso : Form
    {
        string fecha, hora, idclinic, idpac, idmedic, causa;
        int id;
        Datos obj = new Datos();

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        //Actualizar
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            label9.Visible = true;
            panel2.Visible = true;

            try
            {
                fecha = textBox1.Text;
                hora = textBox2.Text;
               // idclinic = comboBox1.Text;
               // idpac = comboBox2.Text;
                idmedic = comboBox3.Text;
                //  causa = textBox3.Text;
                id = int.Parse(textBox4.Text);

                obj.Actualizar(fecha, hora, idmedic, id);
                MessageBox.Show("Se han actualizado los datos");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

            LlenarGridProceso();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pacientes_Load_1(object sender, EventArgs e)
        {
            LlenarGridProceso();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fecha = textBox1.Text;
                hora = textBox2.Text;
                idclinic = comboBox1.Text;
                idpac = comboBox2.Text;
                idmedic = comboBox3.Text;
                causa = textBox3.Text;

                obj.GuardarProceso(fecha, hora, idclinic, idpac, idmedic, causa);
                MessageBox.Show("Se han guardado los datos");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

            LlenarGridProceso();
        }


        public Proceso()
        {
            InitializeComponent();
            obj.SeleccionarCombo(comboBox1);
            obj.SeleccionarCombo2(comboBox2);
            obj.SeleccionarCombo3(comboBox3);

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void LlenarGridProceso()
        {
            dataGridView1.DataSource = obj.LlenarGridProceso();
        }
    }
}
