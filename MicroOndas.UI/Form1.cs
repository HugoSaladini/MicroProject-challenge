using MicroOndas.Domain.Services;
using System;
using System.Windows.Forms;

namespace MicroOndas.UI
{
    public partial class Form1 : Form
    {
        private AquecimentoService _servico;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                int tempo = string.IsNullOrWhiteSpace(txtTempo.Text) ? 0 : int.Parse(txtTempo.Text);
                int? potencia = null;
                if (!string.IsNullOrWhiteSpace(txtPotencia.Text))
                {
                    potencia = int.Parse(txtPotencia.Text);
                }

                _servico = new AquecimentoService(tempo, potencia);
                _servico.Iniciar();

                lblStatus.Text = _servico.GerarStringAquecimento();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar aquecimento: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _servico = new AquecimentoService(30); // tempo padrão 30s
            _servico.Iniciar();

            lblStatus.Text = _servico.GerarStringAquecimento();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (_servico != null)
            {
                _servico.PausarOuCancelar();
                lblStatus.Text = $"Estado atual: {_servico.Estado}";
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

        }

        private void btnRapido_Click(object sender, EventArgs e)
        {

        }
    }
}
