using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = $"Sistema Operacional {Environment.OSVersion}\n" +
            $"Arquitetura {(Environment.Is64BitOperatingSystem ? "64 bits" : "32 Bits")}\n" +
            $"Processador {System.Environment.GetEnvironmentVariable("Processor_Identifier")}";
            MessageBox.Show(info);
        }

        private void apagarArquivosTemporariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ma se tem certeza?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string tempPactch = Path.GetTempPath();
                DeletarArquivosTemporarios(tempPactch);
            }
        }

        private void DeletarArquivosTemporarios(string tempPactch)
        {
            try
            {
                if(Directory.Exists(tempPactch))
                {
                    DirectoryInfo di = new DirectoryInfo(tempPactch);

                    foreach(FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }

                    foreach(DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete();
                    }
                }
                else
                {
                    MessageBox.Show("A pasta não existe!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void desligarComputadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desligaPc desliga = new desligaPc();
            desliga.ShowDialog();
        }
    }
}
