namespace Proyecto
{
    partial class FormJuego
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
            buttonSalir = new Button();
            dgvSudoku = new DataGridView();
            cmbNivel = new ComboBox();
            btnIniciar = new Button();
            btnSolucion = new Button();
            lblIntentos = new Label();
            lblTiempo = new Label();
            lblGanadas = new Label();
            lblPerdidas = new Label();
            lblErrores = new Label();
            btnTema = new Button();
            btnpausar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSudoku).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(784, 541);
            buttonSalir.Margin = new Padding(3, 4, 3, 4);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(117, 43);
            buttonSalir.TabIndex = 7;
            buttonSalir.Text = "SALIR";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // dgvSudoku
            // 
            dgvSudoku.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSudoku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSudoku.Location = new Point(71, 34);
            dgvSudoku.Name = "dgvSudoku";
            dgvSudoku.RowHeadersWidth = 51;
            dgvSudoku.Size = new Size(525, 508);
            dgvSudoku.TabIndex = 8;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(638, 46);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(151, 28);
            cmbNivel.TabIndex = 9;
            cmbNivel.SelectedIndexChanged += cmbNivel_SelectedIndexChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(784, 352);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(115, 45);
            btnIniciar.TabIndex = 10;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSolucion
            // 
            btnSolucion.Location = new Point(784, 476);
            btnSolucion.Name = "btnSolucion";
            btnSolucion.Size = new Size(117, 46);
            btnSolucion.TabIndex = 11;
            btnSolucion.Text = "Solución";
            btnSolucion.UseVisualStyleBackColor = true;
            btnSolucion.Click += btnSolucion_Click;
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntentos.Location = new Point(638, 160);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(73, 22);
            lblIntentos.TabIndex = 13;
            lblIntentos.Text = "Intentos";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempo.Location = new Point(638, 213);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(67, 23);
            lblTiempo.TabIndex = 14;
            lblTiempo.Text = "Tiempo";
            // 
            // lblGanadas
            // 
            lblGanadas.AutoSize = true;
            lblGanadas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGanadas.Location = new Point(638, 267);
            lblGanadas.Name = "lblGanadas";
            lblGanadas.Size = new Size(76, 23);
            lblGanadas.TabIndex = 15;
            lblGanadas.Text = "Ganadas";
            // 
            // lblPerdidas
            // 
            lblPerdidas.AutoSize = true;
            lblPerdidas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerdidas.Location = new Point(638, 325);
            lblPerdidas.Name = "lblPerdidas";
            lblPerdidas.Size = new Size(74, 23);
            lblPerdidas.TabIndex = 16;
            lblPerdidas.Text = "Perdidas";
            // 
            // lblErrores
            // 
            lblErrores.AutoSize = true;
            lblErrores.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrores.Location = new Point(641, 374);
            lblErrores.Name = "lblErrores";
            lblErrores.Size = new Size(63, 23);
            lblErrores.TabIndex = 17;
            lblErrores.Text = "Errores";
            // 
            // btnTema
            // 
            btnTema.Location = new Point(784, 295);
            btnTema.Name = "btnTema";
            btnTema.Size = new Size(114, 44);
            btnTema.TabIndex = 18;
            btnTema.Text = "Tema";
            btnTema.UseVisualStyleBackColor = true;
            btnTema.Click += btnTema_Click;
            // 
            // btnpausar
            // 
            btnpausar.Location = new Point(784, 414);
            btnpausar.Name = "btnpausar";
            btnpausar.Size = new Size(115, 45);
            btnpausar.TabIndex = 19;
            btnpausar.Text = "Pausar";
            btnpausar.UseVisualStyleBackColor = true;
            btnpausar.Click += btnpausar_Click;
            // 
            // FormJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnpausar);
            Controls.Add(btnTema);
            Controls.Add(lblErrores);
            Controls.Add(lblPerdidas);
            Controls.Add(lblGanadas);
            Controls.Add(lblTiempo);
            Controls.Add(lblIntentos);
            Controls.Add(btnSolucion);
            Controls.Add(btnIniciar);
            Controls.Add(cmbNivel);
            Controls.Add(dgvSudoku);
            Controls.Add(buttonSalir);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormJuego";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvSudoku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSalir;
        private DataGridView dgvSudoku;
        private ComboBox cmbNivel;
        private Button btnIniciar;
        private Button btnSolucion;
        private Label lblIntentos;
        private Label lblTiempo;
        private Label lblGanadas;
        private Label lblPerdidas;
        private Label lblErrores;
        private Button btnTema;
        private Button btnpausar;
    }
}