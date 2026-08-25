namespace Proyecto
{
    partial class SUDUKO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUDUKO));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonReglas = new Button();
            buttonContinuar = new Button();
            buttonSalir = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 152);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 52);
            label1.Name = "label1";
            label1.Size = new Size(253, 66);
            label1.TabIndex = 1;
            label1.Text = "SUDOKU";
            // 
            // buttonReglas
            // 
            buttonReglas.Location = new Point(97, 459);
            buttonReglas.Margin = new Padding(3, 4, 3, 4);
            buttonReglas.Name = "buttonReglas";
            buttonReglas.Size = new Size(135, 60);
            buttonReglas.TabIndex = 2;
            buttonReglas.Text = "REGLAS DEL JUEGO";
            buttonReglas.UseVisualStyleBackColor = true;
            buttonReglas.Click += button1_Click;
            // 
            // buttonContinuar
            // 
            buttonContinuar.Location = new Point(265, 459);
            buttonContinuar.Margin = new Padding(3, 4, 3, 4);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(135, 60);
            buttonContinuar.TabIndex = 3;
            buttonContinuar.Text = "INICIAR JUEGO";
            buttonContinuar.UseVisualStyleBackColor = true;
            buttonContinuar.Click += button2_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(438, 459);
            buttonSalir.Margin = new Padding(3, 4, 3, 4);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(135, 60);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "SALIR";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSalir);
            panel1.Controls.Add(buttonContinuar);
            panel1.Controls.Add(buttonReglas);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(32, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 568);
            panel1.TabIndex = 6;
            // 
            // SUDUKO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 625);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SUDUKO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SUDUKO";
            Load += SUDUKO_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonReglas;
        private Button buttonContinuar;
        private Button buttonSalir;
        private Panel panel1;
    }
}
