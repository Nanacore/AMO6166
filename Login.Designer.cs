﻿
namespace amo6166
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbAcesso = new MetroFramework.Controls.MetroLabel();
            this.mtShow = new MetroFramework.Controls.MetroToggle();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbSenha = new MetroFramework.Controls.MetroLabel();
            this.lbNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btLogin = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.tbSim = new MetroFramework.Controls.MetroRadioButton();
            this.rbMoon = new MetroFramework.Controls.MetroRadioButton();
            this.rbSummer = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbAcesso
            // 
            this.lbAcesso.AutoSize = true;
            this.lbAcesso.BackColor = System.Drawing.Color.Black;
            this.lbAcesso.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(32)))), ((int)(((byte)(250)))));
            this.lbAcesso.Location = new System.Drawing.Point(4, 383);
            this.lbAcesso.Name = "lbAcesso";
            this.lbAcesso.Size = new System.Drawing.Size(170, 19);
            this.lbAcesso.Style = MetroFramework.MetroColorStyle.Purple;
            this.lbAcesso.TabIndex = 40;
            this.lbAcesso.Text = "Acessando como: Anônimo";
            this.lbAcesso.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbAcesso.UseStyleColors = true;
            this.lbAcesso.TextChanged += new System.EventHandler(this.lbAcesso_TextChanged);
            // 
            // mtShow
            // 
            this.mtShow.AutoSize = true;
            this.mtShow.Location = new System.Drawing.Point(480, 157);
            this.mtShow.Name = "mtShow";
            this.mtShow.Size = new System.Drawing.Size(80, 19);
            this.mtShow.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtShow.TabIndex = 37;
            this.mtShow.Tag = "";
            this.mtShow.Text = "Off";
            this.mtShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtShow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtShow.UseSelectable = true;
            this.mtShow.UseStyleColors = true;
            this.mtShow.CheckedChanged += new System.EventHandler(this.mtShow_CheckedChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.tbSenha.Location = new System.Drawing.Point(152, 155);
            this.tbSenha.MaxLength = 30;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '♥';
            this.tbSenha.Size = new System.Drawing.Size(322, 23);
            this.tbSenha.TabIndex = 36;
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyPress);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(152, 113);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(408, 23);
            this.tbNome.TabIndex = 35;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            this.tbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNome_KeyPress);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Black;
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSenha.Location = new System.Drawing.Point(70, 157);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(47, 19);
            this.lbSenha.TabIndex = 34;
            this.lbSenha.Text = "Senha:";
            this.lbSenha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbSenha.Click += new System.EventHandler(this.lbSenha_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Black;
            this.lbNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNome.Location = new System.Drawing.Point(70, 113);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 19);
            this.lbNome.TabIndex = 33;
            this.lbNome.Text = "Nome:";
            this.lbNome.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Location = new System.Drawing.Point(72, 199);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "I love you:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(174, 250);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(327, 40);
            this.btLogin.Style = MetroFramework.MetroColorStyle.Purple;
            this.btLogin.TabIndex = 38;
            this.btLogin.Text = "Entrar";
            this.btLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btLogin.UseSelectable = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(174, 296);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(327, 40);
            this.btCancel.Style = MetroFramework.MetroColorStyle.Purple;
            this.btCancel.TabIndex = 39;
            this.btCancel.Text = "Cancelar";
            this.btCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbSim
            // 
            this.tbSim.AutoSize = true;
            this.tbSim.Location = new System.Drawing.Point(236, -545);
            this.tbSim.Name = "tbSim";
            this.tbSim.Size = new System.Drawing.Size(43, 15);
            this.tbSim.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbSim.TabIndex = 41;
            this.tbSim.Text = "Sim";
            this.tbSim.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSim.UseSelectable = true;
            // 
            // rbMoon
            // 
            this.rbMoon.AutoSize = true;
            this.rbMoon.Location = new System.Drawing.Point(174, 203);
            this.rbMoon.Name = "rbMoon";
            this.rbMoon.Size = new System.Drawing.Size(140, 15);
            this.rbMoon.Style = MetroFramework.MetroColorStyle.Red;
            this.rbMoon.TabIndex = 44;
            this.rbMoon.Text = "to the moon and back";
            this.rbMoon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbMoon.UseSelectable = true;
            this.rbMoon.CheckedChanged += new System.EventHandler(this.rbMoon_CheckedChanged);
            this.rbMoon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbMoon_KeyPress);
            // 
            // rbSummer
            // 
            this.rbSummer.AutoSize = true;
            this.rbSummer.Location = new System.Drawing.Point(349, 203);
            this.rbSummer.Name = "rbSummer";
            this.rbSummer.Size = new System.Drawing.Size(152, 15);
            this.rbSummer.Style = MetroFramework.MetroColorStyle.Blue;
            this.rbSummer.TabIndex = 45;
            this.rbSummer.Text = "to the summer and back";
            this.rbSummer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbSummer.UseSelectable = true;
            this.rbSummer.CheckedChanged += new System.EventHandler(this.rbSummer_CheckedChanged);
            this.rbSummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbSummer_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Black;
            this.metroLabel3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel3.Location = new System.Drawing.Point(445, 383);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(193, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "Desenvolvido por: AMO6166 ©";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 411);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.rbSummer);
            this.Controls.Add(this.rbMoon);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbSim);
            this.Controls.Add(this.lbAcesso);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.mtShow);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.96D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "AMO6166™";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbAcesso;
        private MetroFramework.Controls.MetroToggle mtShow;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbNome;
        private MetroFramework.Controls.MetroLabel lbSenha;
        private MetroFramework.Controls.MetroLabel lbNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btLogin;
        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroRadioButton tbSim;
        private MetroFramework.Controls.MetroRadioButton rbMoon;
        private MetroFramework.Controls.MetroRadioButton rbSummer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}