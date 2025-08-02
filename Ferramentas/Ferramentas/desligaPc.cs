using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public partial class desligaPc : Form
    {
        public desligaPc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEscolhaH_Click(object sender, EventArgs e)
        {
            DateTime horariodesligamento = dateTimePicker1.Value;

            DateTime agora = DateTime.Now;

            TimeSpan tempoRestante = horariodesligamento - agora;

            int temporestanteSegundos = (int)tempoRestante.TotalSeconds;

            Process.Start(new ProcessStartInfo("Shutdown",$"/s /t {temporestanteSegundos}")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
            });
            MessageBox.Show($"Seu pc vai de berço as {horariodesligamento}");
        }

        private void btnDesligaMin_Click(object sender, EventArgs e)
        {
            DateTime MinutosDesligar =  Convert.ToDateTime(textBox1.Text);
        }

        private void btnCancelDesliga_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("Shutdown /a")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
            });
        }
    }
}
