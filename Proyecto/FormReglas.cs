using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormReglas : Form
    {
        public FormReglas()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            InicializarBotones();
        }
        private void InicializarBotones()
        {

            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.DodgerBlue;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            FormJuego form3 = new FormJuego();
            form3.Show();
        }
    }
}
