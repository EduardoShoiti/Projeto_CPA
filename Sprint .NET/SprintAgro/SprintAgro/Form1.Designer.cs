namespace SprintAgro
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCultivo = new TextBox();
            txtEstacaoAno = new TextBox();
            txtFertilizante = new TextBox();
            txtClima = new TextBox();
            btnCadastrar = new Button();
            btnPesquisar = new Button();
            label5 = new Label();
            lblid = new Label();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Cultivo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "EstacaoAno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Fertilizante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Clima:";
            // 
            // txtCultivo
            // 
            txtCultivo.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtCultivo.Location = new Point(96, 38);
            txtCultivo.MaxLength = 100;
            txtCultivo.Name = "txtCultivo";
            txtCultivo.Size = new Size(314, 26);
            txtCultivo.TabIndex = 4;
            // 
            // txtEstacaoAno
            // 
            txtEstacaoAno.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtEstacaoAno.Location = new Point(96, 80);
            txtEstacaoAno.MaxLength = 100;
            txtEstacaoAno.Name = "txtEstacaoAno";
            txtEstacaoAno.Size = new Size(314, 26);
            txtEstacaoAno.TabIndex = 5;
            // 
            // txtFertilizante
            // 
            txtFertilizante.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtFertilizante.Location = new Point(96, 132);
            txtFertilizante.MaxLength = 100;
            txtFertilizante.Name = "txtFertilizante";
            txtFertilizante.Size = new Size(314, 26);
            txtFertilizante.TabIndex = 6;
            // 
            // txtClima
            // 
            txtClima.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtClima.Location = new Point(96, 183);
            txtClima.MaxLength = 100;
            txtClima.Name = "txtClima";
            txtClima.Size = new Size(314, 26);
            txtClima.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.ForestGreen;
            btnCadastrar.ForeColor = Color.Honeydew;
            btnCadastrar.Location = new Point(0, 244);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(116, 34);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.ForestGreen;
            btnPesquisar.ForeColor = Color.Honeydew;
            btnPesquisar.Location = new Point(122, 244);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(111, 34);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "Cultivo id:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(79, 9);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 15);
            lblid.TabIndex = 11;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.ForestGreen;
            btnAtualizar.ForeColor = Color.Honeydew;
            btnAtualizar.Location = new Point(239, 244);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(111, 34);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.ForestGreen;
            btnDeletar.ForeColor = Color.Honeydew;
            btnDeletar.Location = new Point(356, 244);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(111, 34);
            btnDeletar.TabIndex = 13;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(481, 299);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(lblid);
            Controls.Add(label5);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtClima);
            Controls.Add(txtFertilizante);
            Controls.Add(txtEstacaoAno);
            Controls.Add(txtCultivo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Agro - CPA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCultivo;
        private TextBox txtEstacaoAno;
        private TextBox txtFertilizante;
        private TextBox txtClima;
        private Button btnCadastrar;
        private Button btnPesquisar;
        private Label label5;
        private Label lblid;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}
