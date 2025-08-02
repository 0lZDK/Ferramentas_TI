namespace Ferramentas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desligarComputadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarArquivosTemporariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desligarComputadorToolStripMenuItem,
            this.apagarArquivosTemporariosToolStripMenuItem,
            this.informaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desligarComputadorToolStripMenuItem
            // 
            this.desligarComputadorToolStripMenuItem.Name = "desligarComputadorToolStripMenuItem";
            this.desligarComputadorToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.desligarComputadorToolStripMenuItem.Text = "&Desligar Computador";
            this.desligarComputadorToolStripMenuItem.Click += new System.EventHandler(this.desligarComputadorToolStripMenuItem_Click);
            // 
            // apagarArquivosTemporariosToolStripMenuItem
            // 
            this.apagarArquivosTemporariosToolStripMenuItem.Name = "apagarArquivosTemporariosToolStripMenuItem";
            this.apagarArquivosTemporariosToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.apagarArquivosTemporariosToolStripMenuItem.Text = "&Apagar Arquivos temporarios";
            this.apagarArquivosTemporariosToolStripMenuItem.Click += new System.EventHandler(this.apagarArquivosTemporariosToolStripMenuItem_Click);
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.informaçõesToolStripMenuItem.Text = "&Informações";
            this.informaçõesToolStripMenuItem.Click += new System.EventHandler(this.informaçõesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desligarComputadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarArquivosTemporariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
    }
}

