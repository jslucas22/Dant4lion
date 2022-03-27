
namespace Dant4lion.ServerSide.View
{
    partial class Configuracoes
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
            this.gbConfiguracoes = new System.Windows.Forms.GroupBox();
            this.ckExibirNotificacaoConectar = new System.Windows.Forms.CheckBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.btnTestarPorta = new System.Windows.Forms.Button();
            this.pnlSeparadorR1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckIgnorarICMP = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfiguracoes
            // 
            this.gbConfiguracoes.Controls.Add(this.ckIgnorarICMP);
            this.gbConfiguracoes.Controls.Add(this.panel1);
            this.gbConfiguracoes.Controls.Add(this.pnlSeparadorR1);
            this.gbConfiguracoes.Controls.Add(this.btnTestarPorta);
            this.gbConfiguracoes.Controls.Add(this.lblPorta);
            this.gbConfiguracoes.Controls.Add(this.txtPorta);
            this.gbConfiguracoes.Controls.Add(this.ckExibirNotificacaoConectar);
            this.gbConfiguracoes.Location = new System.Drawing.Point(12, 12);
            this.gbConfiguracoes.Name = "gbConfiguracoes";
            this.gbConfiguracoes.Size = new System.Drawing.Size(284, 235);
            this.gbConfiguracoes.TabIndex = 0;
            this.gbConfiguracoes.TabStop = false;
            this.gbConfiguracoes.Text = "Configurações";
            // 
            // ckExibirNotificacaoConectar
            // 
            this.ckExibirNotificacaoConectar.AutoSize = true;
            this.ckExibirNotificacaoConectar.Location = new System.Drawing.Point(16, 31);
            this.ckExibirNotificacaoConectar.Name = "ckExibirNotificacaoConectar";
            this.ckExibirNotificacaoConectar.Size = new System.Drawing.Size(181, 17);
            this.ckExibirNotificacaoConectar.TabIndex = 0;
            this.ckExibirNotificacaoConectar.Text = "Exibir notificações ao conectar";
            this.ckExibirNotificacaoConectar.UseVisualStyleBackColor = true;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(88, 72);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(52, 22);
            this.txtPorta.TabIndex = 1;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(13, 77);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(69, 13);
            this.lblPorta.TabIndex = 2;
            this.lblPorta.Text = "Porta (local)";
            // 
            // btnTestarPorta
            // 
            this.btnTestarPorta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestarPorta.Location = new System.Drawing.Point(168, 70);
            this.btnTestarPorta.Name = "btnTestarPorta";
            this.btnTestarPorta.Size = new System.Drawing.Size(98, 26);
            this.btnTestarPorta.TabIndex = 3;
            this.btnTestarPorta.Text = "Testar Porta";
            this.btnTestarPorta.UseVisualStyleBackColor = true;
            // 
            // pnlSeparadorR1
            // 
            this.pnlSeparadorR1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlSeparadorR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.pnlSeparadorR1.Location = new System.Drawing.Point(16, 59);
            this.pnlSeparadorR1.Name = "pnlSeparadorR1";
            this.pnlSeparadorR1.Size = new System.Drawing.Size(250, 2);
            this.pnlSeparadorR1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(17, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 2);
            this.panel1.TabIndex = 5;
            // 
            // ckIgnorarICMP
            // 
            this.ckIgnorarICMP.AutoSize = true;
            this.ckIgnorarICMP.Location = new System.Drawing.Point(16, 125);
            this.ckIgnorarICMP.Name = "ckIgnorarICMP";
            this.ckIgnorarICMP.Size = new System.Drawing.Size(92, 17);
            this.ckIgnorarICMP.TabIndex = 6;
            this.ckIgnorarICMP.Text = "Ignorar ICMP";
            this.ckIgnorarICMP.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = global::Dant4lion.ServerSide.Properties.Resources.save_as_18px;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(198, 253);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 26);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(308, 291);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbConfiguracoes);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.gbConfiguracoes.ResumeLayout(false);
            this.gbConfiguracoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfiguracoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox ckExibirNotificacaoConectar;
        private System.Windows.Forms.Panel pnlSeparadorR1;
        private System.Windows.Forms.Button btnTestarPorta;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckIgnorarICMP;
    }
}