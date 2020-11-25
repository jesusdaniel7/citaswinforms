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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();

        }

        private void CustomizeDesing()
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panel4.Visible == true)
                panel4.Visible = false;
            if (panel5.Visible == true)
                panel5.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;
            if (panel7.Visible == true)
                panel7.Visible = false;

        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }

            else
                SubMenu.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel5);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel6);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel7);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelhijo.Controls.Add(childForm);
            panelhijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HideSubMenu();
           openChildForm(new Pacientes());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
           openChildForm(new Medicos());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new Clinicas());
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new Proceso());
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new ConsultarPacientes());
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new ConsultarMedicos());
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new ConsultarCitas());
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new Utilitarios());
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
