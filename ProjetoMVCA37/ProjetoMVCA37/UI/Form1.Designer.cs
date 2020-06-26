namespace ProjetoMVCA37
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
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_nomemaeA37 = new System.Windows.Forms.TextBox();
            this.txt_nomeA37 = new System.Windows.Forms.TextBox();
            this.txt_cpfA37 = new System.Windows.Forms.TextBox();
            this.lbl_mae = new System.Windows.Forms.Label();
            this.lbl_nomecom = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Transparent;
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_enviar.Location = new System.Drawing.Point(55, 244);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(248, 41);
            this.btn_enviar.TabIndex = 23;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txt_nomemaeA37
            // 
            this.txt_nomemaeA37.Location = new System.Drawing.Point(55, 207);
            this.txt_nomemaeA37.Name = "txt_nomemaeA37";
            this.txt_nomemaeA37.Size = new System.Drawing.Size(248, 20);
            this.txt_nomemaeA37.TabIndex = 21;
            // 
            // txt_nomeA37
            // 
            this.txt_nomeA37.Location = new System.Drawing.Point(55, 138);
            this.txt_nomeA37.Name = "txt_nomeA37";
            this.txt_nomeA37.Size = new System.Drawing.Size(248, 20);
            this.txt_nomeA37.TabIndex = 20;
            // 
            // txt_cpfA37
            // 
            this.txt_cpfA37.Location = new System.Drawing.Point(55, 66);
            this.txt_cpfA37.Name = "txt_cpfA37";
            this.txt_cpfA37.Size = new System.Drawing.Size(248, 20);
            this.txt_cpfA37.TabIndex = 19;
            // 
            // lbl_mae
            // 
            this.lbl_mae.AutoSize = true;
            this.lbl_mae.Location = new System.Drawing.Point(60, 176);
            this.lbl_mae.Name = "lbl_mae";
            this.lbl_mae.Size = new System.Drawing.Size(77, 13);
            this.lbl_mae.TabIndex = 18;
            this.lbl_mae.Text = "Nome da Mãe:";
            // 
            // lbl_nomecom
            // 
            this.lbl_nomecom.AutoSize = true;
            this.lbl_nomecom.Location = new System.Drawing.Point(60, 110);
            this.lbl_nomecom.Name = "lbl_nomecom";
            this.lbl_nomecom.Size = new System.Drawing.Size(85, 13);
            this.lbl_nomecom.TabIndex = 17;
            this.lbl_nomecom.Text = "Nome Completo:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(60, 41);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_cpf.TabIndex = 16;
            this.lbl_cpf.Text = "CPF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 341);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_nomemaeA37);
            this.Controls.Add(this.txt_nomeA37);
            this.Controls.Add(this.txt_cpfA37);
            this.Controls.Add(this.lbl_mae);
            this.Controls.Add(this.lbl_nomecom);
            this.Controls.Add(this.lbl_cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_nomemaeA37;
        private System.Windows.Forms.TextBox txt_nomeA37;
        private System.Windows.Forms.TextBox txt_cpfA37;
        private System.Windows.Forms.Label lbl_mae;
        private System.Windows.Forms.Label lbl_nomecom;
        private System.Windows.Forms.Label lbl_cpf;
    }
}

