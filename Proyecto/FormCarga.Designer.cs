namespace Proyecto
{
    partial class FormCarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblcargando = new Label();
            lblpanel = new Label();
            Timer_Cargan = new System.Windows.Forms.Timer(components);
            Timer_Barra = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            lblbienvenido = new Label();
            SuspendLayout();
            // 
            // lblcargando
            // 
            lblcargando.AutoSize = true;
            lblcargando.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcargando.Location = new Point(295, 238);
            lblcargando.Margin = new Padding(2, 0, 2, 0);
            lblcargando.Name = "lblcargando";
            lblcargando.Size = new Size(90, 25);
            lblcargando.TabIndex = 0;
            lblcargando.Text = "Cargando";
            // 
            // lblpanel
            // 
            lblpanel.Location = new Point(124, 345);
            lblpanel.Name = "lblpanel";
            lblpanel.Size = new Size(419, 30);
            lblpanel.TabIndex = 1;
            // 
            // Timer_Cargan
            // 
            Timer_Cargan.Tick += Timer_Cargan_Tick;
            // 
            // Timer_Barra
            // 
            Timer_Barra.Tick += Timer_Barra_Tick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblbienvenido
            // 
            lblbienvenido.AutoSize = true;
            lblbienvenido.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbienvenido.Location = new Point(255, 65);
            lblbienvenido.Name = "lblbienvenido";
            lblbienvenido.Size = new Size(171, 41);
            lblbienvenido.TabIndex = 2;
            lblbienvenido.Text = "Bienvenido";
            // 
            // FormCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 450);
            Controls.Add(lblbienvenido);
            Controls.Add(lblpanel);
            Controls.Add(lblcargando);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarga";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCarga_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcargando;
        private Label lblpanel;
        private System.Windows.Forms.Timer Timer_Cargan;
        private System.Windows.Forms.Timer Timer_Barra;
        private System.Windows.Forms.Timer timer1;
        private Label lblbienvenido;
    }
}