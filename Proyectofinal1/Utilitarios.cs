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
    public partial class Utilitarios : Form
    {
        public Utilitarios()
        {
            InitializeComponent();
        }

        //Arreglando el combobox para la conversion de moneda
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Dolar EEUU":
                string[] arrayData1 = new string[2];
                arrayData1[0] = "Euro";
                arrayData1[1] = "Peso Dominicano";
                comboBox2.DataSource = arrayData1;
                break;

                case "Euro":
                string[] arrayData2 = new string[2];
                arrayData2[0] = "Dolar";
                arrayData2[1] = "Peso Dominicano";
                comboBox2.DataSource = arrayData2;
                break;

                case "Peso Dominicano":
                string[] arrayData3 = new string[2];
                arrayData3[0] = "Euro";
                arrayData3[1] = "Dolar";
                comboBox2.DataSource = arrayData3;
                break;
            }

            
        }

        private void Utilitarios_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            switch (comboBox1.Text)
            {
                case "Dolar EEUU":
                    switch (comboBox2.Text)
                    {
                        case "Euro":
                            int Euro = int.Parse(textBox1.Text);
                            double convertEuro = (Euro * 0.91);
                            string convertEuro1 = Convert.ToString(convertEuro);
                            label3.Text = convertEuro1;
                            break;
                        case "Peso Dominicano":
                            int peso = int.Parse(textBox1.Text);
                            double convertPeso = (peso * 52.74);
                            string convertPeso1 = Convert.ToString(convertPeso);
                            label3.Text = convertPeso1;
                            break;
                    }
                    break;
                case "Euro":
                    switch (comboBox2.Text)
                    {
                        case "Dolar EEUU":
                            int dolar = int.Parse(textBox1.Text);
                            double convertdolar = (dolar * 1.10);
                            string convertdolar1 = Convert.ToString(convertdolar);
                            label3.Text = convertdolar1;
                            break;
                        case "Peso Dominicano":
                            int peso = int.Parse(textBox1.Text);
                            double convertPeso = (peso * 58.10);
                            string convertPeso1 = Convert.ToString(convertPeso);
                            label3.Text = convertPeso1;
                            break;
                    }
                    break;
                case "Peso Dominicano":
                    switch (comboBox2.Text)
                    {
                        case "Dolar EEUU":
                            int dolar = int.Parse(textBox1.Text);
                            double convertdolar = (dolar * 0.019);
                            string convertdolar1 = Convert.ToString(convertdolar);
                            label3.Text = convertdolar1;
                            break;
                        case "Euro":
                            int euro = int.Parse(textBox1.Text);
                            double converteuro = (euro * 0.017);
                            string converteuro1 = Convert.ToString(converteuro);
                            label3.Text = converteuro1;
                            break;
                    }

                    break;

            }
        }
    }
}
