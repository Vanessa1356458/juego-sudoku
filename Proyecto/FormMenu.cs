using Proyecto;
using System.Drawing.Drawing2D;

namespace Proyecto
{
    public partial class SUDUKO : Form
    {
        public SUDUKO()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            InicializarBotones();
            AgregarTooltips();
        }

        private void AgregarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            foreach (Control c in panel1.Controls)
            {
                if (c is Button btn)
                {
                    toolTip.SetToolTip(btn, "Este es el botón " + btn.Text);
                }
            }
        }

        private void InicializarBotones()
        {
            foreach (Control c in panel1.Controls)
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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReglas form3 = new FormReglas();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FormJuego form3 = new FormJuego();
            form3.Show();
        }

        private void SUDUKO_Load(object sender, EventArgs e)
        {

        }
    }
}
