namespace Ferramentas
{
    partial class desligaPc
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEscolhaH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesligaMin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDesligarAgora = new System.Windows.Forms.Button();
            this.btnCancelDesliga = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEscolhaH);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o horario que deseja Desligar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnEscolhaH
            // 
            this.btnEscolhaH.Location = new System.Drawing.Point(74, 54);
            this.btnEscolhaH.Name = "btnEscolhaH";
            this.btnEscolhaH.Size = new System.Drawing.Size(75, 23);
            this.btnEscolhaH.TabIndex = 1;
            this.btnEscolhaH.Text = "Agendar";
            this.btnEscolhaH.UseVisualStyleBackColor = true;
            this.btnEscolhaH.Click += new System.EventHandler(this.btnEscolhaH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnDesligaMin);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desligar Daqui";
            // 
            // btnDesligaMin
            // 
            this.btnDesligaMin.Location = new System.Drawing.Point(74, 62);
            this.btnDesligaMin.Name = "btnDesligaMin";
            this.btnDesligaMin.Size = new System.Drawing.Size(75, 23);
            this.btnDesligaMin.TabIndex = 1;
            this.btnDesligaMin.Text = "Agendar";
            this.btnDesligaMin.UseVisualStyleBackColor = true;
            this.btnDesligaMin.Click += new System.EventHandler(this.btnDesligaMin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite em Minutos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelDesliga);
            this.groupBox3.Controls.Add(this.btnDesligarAgora);
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desligar Daqui";
            // 
            // btnDesligarAgora
            // 
            this.btnDesligarAgora.Location = new System.Drawing.Point(74, 19);
            this.btnDesligarAgora.Name = "btnDesligarAgora";
            this.btnDesligarAgora.Size = new System.Drawing.Size(75, 23);
            this.btnDesligarAgora.TabIndex = 1;
            this.btnDesligarAgora.Text = "Desligar";
            this.btnDesligarAgora.UseVisualStyleBackColor = true;
            // 
            // btnCancelDesliga
            // 
            this.btnCancelDesliga.Location = new System.Drawing.Point(58, 48);
            this.btnCancelDesliga.Name = "btnCancelDesliga";
            this.btnCancelDesliga.Size = new System.Drawing.Size(104, 23);
            this.btnCancelDesliga.TabIndex = 2;
            this.btnCancelDesliga.Text = "Cancela Desligar";
            this.btnCancelDesliga.UseVisualStyleBackColor = true;
            this.btnCancelDesliga.Click += new System.EventHandler(this.btnCancelDesliga_Click);
            // 
            // desligaPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "desligaPc";
            this.Text = "desligaPc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEscolhaH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDesligaMin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelDesliga;
        private System.Windows.Forms.Button btnDesligarAgora;
    }
}