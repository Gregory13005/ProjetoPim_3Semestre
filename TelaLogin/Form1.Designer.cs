namespace TelaLogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.iblLogin = new System.Windows.Forms.Label();
            this.iblSenha = new System.Windows.Forms.Label();
            this.iblSair = new System.Windows.Forms.Button();
            this.iblEntrar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(93, 118);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(201, 23);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(93, 171);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(201, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // iblLogin
            // 
            this.iblLogin.AutoSize = true;
            this.iblLogin.Location = new System.Drawing.Point(97, 122);
            this.iblLogin.Name = "iblLogin";
            this.iblLogin.Size = new System.Drawing.Size(40, 15);
            this.iblLogin.TabIndex = 2;
            this.iblLogin.Text = "Login:";
            this.iblLogin.Click += new System.EventHandler(this.iblLogin_Click);
            // 
            // iblSenha
            // 
            this.iblSenha.AutoSize = true;
            this.iblSenha.Location = new System.Drawing.Point(97, 176);
            this.iblSenha.Name = "iblSenha";
            this.iblSenha.Size = new System.Drawing.Size(42, 15);
            this.iblSenha.TabIndex = 3;
            this.iblSenha.Text = "Senha:";
            this.iblSenha.Click += new System.EventHandler(this.iblSenha_Click);
            // 
            // iblSair
            // 
            this.iblSair.Location = new System.Drawing.Point(92, 223);
            this.iblSair.Name = "iblSair";
            this.iblSair.Size = new System.Drawing.Size(75, 23);
            this.iblSair.TabIndex = 4;
            this.iblSair.Text = "Sair";
            this.iblSair.UseVisualStyleBackColor = true;
            this.iblSair.Click += new System.EventHandler(this.iblSair_Click);
            // 
            // iblEntrar
            // 
            this.iblEntrar.Location = new System.Drawing.Point(219, 223);
            this.iblEntrar.Name = "iblEntrar";
            this.iblEntrar.Size = new System.Drawing.Size(75, 23);
            this.iblEntrar.TabIndex = 5;
            this.iblEntrar.Text = "Entrar";
            this.iblEntrar.UseVisualStyleBackColor = true;
            this.iblEntrar.Click += new System.EventHandler(this.iblEntrar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(89, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Lembrar Login?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ajuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.iblEntrar);
            this.Controls.Add(this.iblSair);
            this.Controls.Add(this.iblSenha);
            this.Controls.Add(this.iblLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Trikas Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label iblLogin;
        private Label iblSenha;
        private Button iblSair;
        private Button iblEntrar;
        private CheckBox checkBox1;
        private Button button1;
    }
}