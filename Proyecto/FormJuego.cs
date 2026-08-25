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
    public partial class FormJuego : Form
    {
        private int[,] solucionActual = new int[9, 9];
        private Random random = new Random();
        private int intentos = 5;
        private int partidasGanadas = 0;
        private int partidasPerdidas = 0;
        private int errores = 0;
        private System.Windows.Forms.Timer timerJuego = new System.Windows.Forms.Timer();
        private int tiempoRestante;
        private bool solucionMostrada = false;
        public FormJuego()
        {
            InitializeComponent();
            InicializarInterfaz();
            ActualizarPantalla();

            this.BackColor = Color.LightBlue;
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.Font = new Font("Open Sans", 14, FontStyle.Regular);
                    c.ForeColor = Color.Navy;
                }
            }
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
        private void InicializarInterfaz()
        {
            dgvSudoku.RowHeadersVisible = false;
            dgvSudoku.ColumnHeadersVisible = false;
            dgvSudoku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvSudoku.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvSudoku.AllowUserToResizeRows = false;
            dgvSudoku.AllowUserToResizeColumns = false;
            dgvSudoku.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSudoku.DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold);
            dgvSudoku.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvSudoku.GridColor = Color.Black;
            dgvSudoku.ScrollBars = ScrollBars.None;

            CrearCuadriculaSudoku();
            cmbNivel.Items.AddRange(new string[] { "Fácil", "Medio", "Superior" });
            cmbNivel.SelectedIndex = -1;

            timerJuego.Tick += TimerJuego_Tick;
            timerJuego.Interval = 1000;

            int tamanoCelda = 50;
            dgvSudoku.Width = 9 * tamanoCelda + 4;
            dgvSudoku.Height = 9 * tamanoCelda + 4;
            dgvSudoku.RowTemplate.Height = tamanoCelda;
            dgvSudoku.Columns[0].Width = tamanoCelda;

            for (int i = 0; i < dgvSudoku.Columns.Count; i++)
            {
                dgvSudoku.Columns[i].Width = tamanoCelda;
            }

            ActualizarPantalla();
        }
        private void CrearCuadriculaSudoku()
        {
            dgvSudoku.Columns.Clear();
            dgvSudoku.Rows.Clear();

            int tamanoCelda = 50;

            for (int i = 0; i < 9; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Width = tamanoCelda;
                dgvSudoku.Columns.Add(col);

                if ((i + 1) % 3 == 0 && i < 8)
                {
                    col.DividerWidth = 2;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                dgvSudoku.Rows.Add();
                dgvSudoku.Rows[i].Height = tamanoCelda;

                if ((i + 1) % 3 == 0 && i < 8)
                {
                    dgvSudoku.Rows[i].DividerHeight = 2;
                }

                dgvSudoku.EditingControlShowing += (s, e) =>
                {
                    if (e.Control is TextBox tb)
                    {
                        tb.MaxLength = 1;
                        tb.KeyPress -= Tb_KeyPress;
                        tb.KeyPress += Tb_KeyPress;
                    }
                };

                for (int j = 0; j < 9; j++)
                {
                    if (((i / 3) + (j / 3)) % 2 == 0)
                    {
                        dgvSudoku[j, i].Style.BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? Color.LightGray : Color.White;
                    }

                }
            }
        }
        private void Tb_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == '0' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ActualizarPantalla()
        {
            lblIntentos.Text = $"Intentos restantes: {intentos}";
            lblGanadas.Text = $"Ganadas: {partidasGanadas}";
            lblPerdidas.Text = $"Perdidas: {partidasPerdidas}";
            lblTiempo.Text = $"Tiempo: {tiempoRestante} s";
            lblErrores.Text = $"Errores: {errores}";

        }
        private bool Ganadas()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (dgvSudoku[j, i].Value == null || dgvSudoku[j, i].Value.ToString() == "")
                        return false;

                    if (int.TryParse(dgvSudoku[j, i].Value.ToString(), out int valorCelda))
                    {
                        if (valorCelda != solucionActual[i, j])
                            return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un nivel para iniciar el juego.");
                return;
            }

            if (timerJuego.Enabled)
            {
                timerJuego.Stop();
            }

            ReiniciarColoresCeldas();
            GenerarTableroCompleto();
            PrepararTableroParaJuego();
            tiempoRestante = ObtenerTiempoPorNivel();
            intentos = 5;
            errores = 0;
            solucionMostrada = false;
            ActualizarPantalla();
            timerJuego.Start();


            dgvSudoku.CellValueChanged -= DgvSudoku_CellValueChanged;
            dgvSudoku.CellValueChanged += DgvSudoku_CellValueChanged;
        }
        private void ReiniciarColoresCeldas()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var celda = dgvSudoku[j, i];

                    Color colorResaltado = temaOscuro ? colorResaltadoOscuro : colorResaltadoClaro;
                    Color colorNormal = temaOscuro ? colorNormalOscuro : colorNormalClaro;
                    celda.Style.BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? colorResaltado : colorNormal;

                    celda.Style.ForeColor = Color.Black; 

                    celda.ReadOnly = false;
                }
            }
        }
        private int ObtenerTiempoPorNivel()
        {
            return cmbNivel.SelectedIndex switch
            {
                0 => 300,
                1 => 180,
                2 => 120,
                _ => 300
            };
        }
        private void TimerJuego_Tick(object? sender, EventArgs e)
        {
            tiempoRestante--;
            if (tiempoRestante <= 0)
            {
                timerJuego.Stop();
            }
            lblTiempo.Text = $"Tiempo: {tiempoRestante} segundos";


            if (sender == null) throw new ArgumentNullException(nameof(sender));

            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                ActualizarPantalla();
            }
            else
            {
                timerJuego.Stop();
                MessageBox.Show("Se acabó el tiempo. Has perdido.");
                partidasPerdidas++;
                ActualizarPantalla();
            }
        }
        private void GenerarTableroCompleto()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    solucionActual[i, j] = 0;
                }
            }

            LlenarPrimeraFilaAleatoriamente();
            ResolverSudoku(solucionActual, 0, 0);
            MostrarTableroResuelto();
        }
        private void LlenarPrimeraFilaAleatoriamente()
        {
            List<int> numeros = Enumerable.Range(1, 9).OrderBy(x => random.Next()).ToList();
            for (int j = 0; j < 9; j++)
            {
                solucionActual[0, j] = numeros[j];
            }
        }
        private void MostrarTableroResuelto()
        {
            Color colorResaltado = temaOscuro ? colorResaltadoOscuro : colorResaltadoClaro;
            Color colorNormal = temaOscuro ? colorNormalOscuro : colorNormalClaro;

            bool juegoGanado = Ganadas(); 

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var celda = dgvSudoku[j, i];

                    celda.Value = solucionActual[i, j];

                    celda.ReadOnly = true;

                    celda.Style.BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? colorResaltado : colorNormal;

                    if (solucionActual[i, j] == 0)
                    {
                        celda.Style.ForeColor = Color.Blue;
                    }
                    else
                    {
                        celda.Style.ForeColor = temaOscuro ? Color.Black : Color.Black;
                    }
                }
            }   
            ActualizarPantalla();
        }
        private void PrepararTableroParaJuego()
        {
            ReiniciarColoresCeldas();
            int celdasOcultas = cmbNivel.SelectedIndex switch
            {
                0 => 20,
                1 => 40,
                2 => 50,
                _ => 30
            };

            for (int k = 0; k < celdasOcultas; k++)
            {
                int fila, columna;
                do
                {
                    fila = random.Next(0, 9);
                    columna = random.Next(0, 9);
                } while (dgvSudoku[columna, fila].Value == null);

                dgvSudoku[columna, fila].Value = null;
                dgvSudoku[columna, fila].Style.ForeColor = temaOscuro ? Color.LightGray : Color.Blue;
                ActualizarColorCelda(fila, columna);
                dgvSudoku[columna, fila].ReadOnly = false;
            }
        }
        private void DgvSudoku_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= dgvSudoku.RowCount || e.ColumnIndex >= dgvSudoku.ColumnCount) return;

            var celda = dgvSudoku[e.ColumnIndex, e.RowIndex];

            if (int.TryParse(celda.Value?.ToString(), out int valor))
            {
                if (valor == solucionActual[e.RowIndex, e.ColumnIndex])
                {
                    celda.Style.ForeColor = Color.Green;
                }
                else
                {
                    celda.Style.ForeColor = Color.Red;
                    errores++;
                    intentos--;
                    lblErrores.Text = $"Errores: {errores}";
                    lblIntentos.Text = $"Intentos restantes: {intentos}";

                    if (intentos == 0)
                    {
                        timerJuego.Stop();
                        partidasPerdidas++;
                        MessageBox.Show("Has perdido. No te quedan intentos.");
                        ActualizarPantalla();
                        return;
                    }
                }
            }
            else
            {
                celda.Value = null;
            }

            ActualizarColorCelda(e.RowIndex, e.ColumnIndex);

            if (celda.Style.ForeColor == Color.Red || celda.Style.ForeColor == Color.Green)
            {
                return;
            }

            if (temaOscuro && celda.Value != null)
            {
                celda.Style.ForeColor = Color.Black;
            }

            if (!solucionMostrada) return;

            if (Ganadas())
            {
                timerJuego.Stop();
                partidasGanadas++;
                MessageBox.Show("¡Felicidades! Has ganado.");
                ActualizarPantalla();
            }
        }
        private void ActualizarColorCelda(int fila, int columna)
        {
            Color colorResaltado = temaOscuro ? colorResaltadoOscuro : colorResaltadoClaro;
            Color colorNormal = temaOscuro ? colorNormalOscuro : colorNormalClaro;

            var celda = dgvSudoku[columna, fila];

            if (celda.Style.ForeColor == Color.Green || celda.Style.ForeColor == Color.Red)
            {
                return;
            }

            celda.Style.BackColor = ((fila / 3) + (columna / 3)) % 2 == 0 ? colorResaltado : colorNormal;

            celda.Style.ForeColor = temaOscuro ? Color.Black : Color.Black;
        }
        private bool ResolverSudoku(int[,] tablero, int fila, int columna)
        {
            if (fila == 9) return true;
            if (columna == 9) return ResolverSudoku(tablero, fila + 1, 0);
            if (tablero[fila, columna] != 0) return ResolverSudoku(tablero, fila, columna + 1);

            for (int num = 1; num <= 9; num++)
            {
                if (EsValido(tablero, fila, columna, num))
                {
                    tablero[fila, columna] = num;
                    if (ResolverSudoku(tablero, fila, columna + 1)) return true;
                    tablero[fila, columna] = 0;
                }
            }
            return false;
        }
        private bool EsValido(int[,] tablero, int fila, int columna, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (tablero[fila, i] == num || tablero[i, columna] == num) return false;
                if (tablero[(fila / 3) * 3 + i / 3, (columna / 3) * 3 + i % 3] == num) return false;
            }
            return true;
        }
        private void btnSolucion_Click(object sender, EventArgs e)
        {
            solucionMostrada = true;
            MostrarTableroResuelto();
            timerJuego.Stop();
            partidasPerdidas++;
            ActualizarPantalla();
        }
        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool temaOscuro = false;

        private Color colorResaltadoClaro = Color.LightGray;

        private Color colorNormalClaro = Color.White;

        private Color colorResaltadoOscuro = Color.DimGray;

        private Color colorNormalOscuro = Color.LightGray;
        private void btnTema_Click(object sender, EventArgs e)
        {
            temaOscuro = !temaOscuro;

            this.BackColor = temaOscuro ? Color.Black : Color.LightBlue;

            foreach (Control c in this.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.ForeColor = temaOscuro ? Color.White : Color.Navy;
                }
                else if (c is Button btn)
                {
                    btn.BackColor = temaOscuro ? Color.Gray : Color.Black;
                    btn.ForeColor = temaOscuro ? Color.Black : Color.White;
                }
            }

            ReiniciarColoresCeldas();
            foreach (DataGridViewRow row in dgvSudoku.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        cell.Style.ForeColor = Color.Black; 
                    }
                }
            }
        }
        private void CambiarTema(bool temaOscuro)
        {
            temaOscuro = !temaOscuro;

            if (temaOscuro)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                foreach (Control c in this.Controls)
                {
                    if (c is Label lbl)
                    {
                        lbl.ForeColor = Color.White;
                    }
                    else if (c is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(45, 45, 48);
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.DimGray;
                    }
                }

                foreach (DataGridViewRow row in dgvSudoku.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.FromArgb(50, 50, 50);
                        cell.Style.ForeColor = Color.White;
                    }
                }
                dgvSudoku.GridColor = Color.DimGray;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                foreach (Control c in this.Controls)
                {
                    if (c is Label lbl)
                    {
                        lbl.ForeColor = Color.Navy;
                    }
                    else if (c is Button btn)
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                        btn.FlatAppearance.BorderColor = Color.DodgerBlue;
                    }
                }

                foreach (DataGridViewRow row in dgvSudoku.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                        cell.Style.ForeColor = Color.Black;
                    }
                }
                dgvSudoku.GridColor = Color.Black;
            }
        }
        
        private bool enPausa = false;
        private void btnpausar_Click(object sender, EventArgs e)
        {
            if (enPausa)
            {
                timerJuego.Start();
                btnpausar.Text = "Pausa";
                enPausa = false;
            }
            else
            {
                timerJuego.Stop();
                btnpausar.Text = "Reanudar";
                enPausa = true;
            }
        }
    }
}
