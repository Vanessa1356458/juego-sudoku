using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{

    public partial class FormCarga : Form
    {
        private Panel panelContainer;
        public FormCarga()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;

            panelContainer = new Panel(); 
            panelContainer.Width = 200; 
            panelContainer.Height = 30;
            panelContainer.BackColor = Color.White;
            panelContainer.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(panelContainer);

            lblpanel = new Label();
            lblpanel.Width = 40;
            lblpanel.Height = panelContainer.Height;
            lblpanel.BackColor = Color.Black;
            panelContainer.Controls.Add(lblpanel);

            Timer_Cargan.Interval = 60;
            Timer_Cargan.Tick += Timer_Cargan_Tick;
            Timer_Cargan.Start();

            Timer_Barra.Interval = 135;
            Timer_Barra.Tick += Timer_Barra_Tick;
            Timer_Barra.Start();

        }
        private void FormCarga_Load(object sender, EventArgs e)
        {
            if (panelContainer != null)
            {
                panelContainer.Left = (this.ClientSize.Width - panelContainer.Width) / 2;
                panelContainer.Top = (this.ClientSize.Height - panelContainer.Height) / 2 + 50;

                lblcargando.Left = (this.ClientSize.Width - lblcargando.Width) / 2;
                lblcargando.Top = panelContainer.Top - lblcargando.Height - 10; 
            }
        }
        private void Timer_Cargan_Tick(object? sender, EventArgs e)
        {
            lblcargando.Top -= 2;
            if (panelContainer != null && lblcargando.Top <= (panelContainer.Top - lblcargando.Height - 20))
            {
                Timer_Cargan.Stop();
                timer1.Start();
            }
        }
        private void Timer_Barra_Tick(object? sender, EventArgs e)
        {
            lblpanel.Width += 1;

            if (panelContainer != null && lblpanel.Width >= panelContainer.Width) 
               {
                Timer_Barra.Stop();
                this.Hide();
                SUDUKO formSudoku = new SUDUKO();
                formSudoku.Show();
                formSudoku.FormClosed += (s, args) => this.Close();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblcargando.Top += 2;
            if (panelContainer != null && lblcargando.Top >= (panelContainer.Top - lblcargando.Height - 10))
            {
                Timer_Cargan.Start();
                timer1.Stop();
            }
        }
    }
}
