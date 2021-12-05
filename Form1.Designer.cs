
namespace Sistemas_Supervisorios___Trabalho_2
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
            this.btn_Ext_Andar1 = new System.Windows.Forms.Button();
            this.btn_Ext_Andar2 = new System.Windows.Forms.Button();
            this.btn_Ext_Andar3 = new System.Windows.Forms.Button();
            this.btn_Ext_Andar4 = new System.Windows.Forms.Button();
            this.btn_Ext_Andar5 = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_EM = new System.Windows.Forms.Label();
            this.chc_Manual = new System.Windows.Forms.CheckBox();
            this.chc_Automatico = new System.Windows.Forms.CheckBox();
            this.btn_Int_Andar1 = new System.Windows.Forms.Button();
            this.btn_Int_Andar2 = new System.Windows.Forms.Button();
            this.btn_Int_Andar3 = new System.Windows.Forms.Button();
            this.btn_Int_Andar4 = new System.Windows.Forms.Button();
            this.btn_Int_Andar5 = new System.Windows.Forms.Button();
            this.lbl_Internal_Andar_Atual = new System.Windows.Forms.Label();
            this.list_Logger = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ext_Andar1
            // 
            this.btn_Ext_Andar1.Location = new System.Drawing.Point(283, 191);
            this.btn_Ext_Andar1.Name = "btn_Ext_Andar1";
            this.btn_Ext_Andar1.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar1.TabIndex = 2;
            this.btn_Ext_Andar1.Text = "1º Andar";
            this.btn_Ext_Andar1.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar1.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Ext_Andar2
            // 
            this.btn_Ext_Andar2.Location = new System.Drawing.Point(374, 191);
            this.btn_Ext_Andar2.Name = "btn_Ext_Andar2";
            this.btn_Ext_Andar2.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar2.TabIndex = 3;
            this.btn_Ext_Andar2.Text = "2º Andar";
            this.btn_Ext_Andar2.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar2.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Ext_Andar3
            // 
            this.btn_Ext_Andar3.Location = new System.Drawing.Point(283, 162);
            this.btn_Ext_Andar3.Name = "btn_Ext_Andar3";
            this.btn_Ext_Andar3.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar3.TabIndex = 0;
            this.btn_Ext_Andar3.Text = "3º Andar";
            this.btn_Ext_Andar3.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar3.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Ext_Andar4
            // 
            this.btn_Ext_Andar4.Location = new System.Drawing.Point(374, 162);
            this.btn_Ext_Andar4.Name = "btn_Ext_Andar4";
            this.btn_Ext_Andar4.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar4.TabIndex = 1;
            this.btn_Ext_Andar4.Text = "4º Andar";
            this.btn_Ext_Andar4.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar4.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Ext_Andar5
            // 
            this.btn_Ext_Andar5.Location = new System.Drawing.Point(374, 133);
            this.btn_Ext_Andar5.Name = "btn_Ext_Andar5";
            this.btn_Ext_Andar5.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar5.TabIndex = 4;
            this.btn_Ext_Andar5.Text = "5º Andar";
            this.btn_Ext_Andar5.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar5.Click += new System.EventHandler(this.ControlPanel);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Status.Location = new System.Drawing.Point(300, 137);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(41, 13);
            this.lbl_Status.TabIndex = 10;
            this.lbl_Status.Text = "Parado";
            // 
            // lbl_EM
            // 
            this.lbl_EM.AutoSize = true;
            this.lbl_EM.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_EM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EM.Location = new System.Drawing.Point(32, 157);
            this.lbl_EM.Name = "lbl_EM";
            this.lbl_EM.Size = new System.Drawing.Size(28, 17);
            this.lbl_EM.TabIndex = 11;
            this.lbl_EM.Text = "EM";
            // 
            // chc_Manual
            // 
            this.chc_Manual.AutoSize = true;
            this.chc_Manual.BackColor = System.Drawing.SystemColors.Control;
            this.chc_Manual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chc_Manual.Location = new System.Drawing.Point(294, 70);
            this.chc_Manual.Name = "chc_Manual";
            this.chc_Manual.Size = new System.Drawing.Size(61, 17);
            this.chc_Manual.TabIndex = 12;
            this.chc_Manual.Text = "Manual";
            this.chc_Manual.UseVisualStyleBackColor = false;
            this.chc_Manual.CheckedChanged += new System.EventHandler(this.ChangeControl);
            // 
            // chc_Automatico
            // 
            this.chc_Automatico.AutoSize = true;
            this.chc_Automatico.BackColor = System.Drawing.SystemColors.Control;
            this.chc_Automatico.Location = new System.Drawing.Point(371, 70);
            this.chc_Automatico.Name = "chc_Automatico";
            this.chc_Automatico.Size = new System.Drawing.Size(79, 17);
            this.chc_Automatico.TabIndex = 13;
            this.chc_Automatico.Text = "Automático";
            this.chc_Automatico.UseVisualStyleBackColor = false;
            this.chc_Automatico.CheckedChanged += new System.EventHandler(this.ChangeControl);
            // 
            // btn_Int_Andar1
            // 
            this.btn_Int_Andar1.Location = new System.Drawing.Point(79, 224);
            this.btn_Int_Andar1.Name = "btn_Int_Andar1";
            this.btn_Int_Andar1.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar1.TabIndex = 14;
            this.btn_Int_Andar1.Text = "1º Andar";
            this.btn_Int_Andar1.UseVisualStyleBackColor = true;
            this.btn_Int_Andar1.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Int_Andar2
            // 
            this.btn_Int_Andar2.Location = new System.Drawing.Point(79, 189);
            this.btn_Int_Andar2.Name = "btn_Int_Andar2";
            this.btn_Int_Andar2.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar2.TabIndex = 15;
            this.btn_Int_Andar2.Text = "2º Andar";
            this.btn_Int_Andar2.UseVisualStyleBackColor = true;
            this.btn_Int_Andar2.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Int_Andar3
            // 
            this.btn_Int_Andar3.Location = new System.Drawing.Point(79, 154);
            this.btn_Int_Andar3.Name = "btn_Int_Andar3";
            this.btn_Int_Andar3.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar3.TabIndex = 16;
            this.btn_Int_Andar3.Text = "3º Andar";
            this.btn_Int_Andar3.UseVisualStyleBackColor = true;
            this.btn_Int_Andar3.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Int_Andar4
            // 
            this.btn_Int_Andar4.Location = new System.Drawing.Point(79, 119);
            this.btn_Int_Andar4.Name = "btn_Int_Andar4";
            this.btn_Int_Andar4.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar4.TabIndex = 17;
            this.btn_Int_Andar4.Text = "4º Andar";
            this.btn_Int_Andar4.UseVisualStyleBackColor = true;
            this.btn_Int_Andar4.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Int_Andar5
            // 
            this.btn_Int_Andar5.Location = new System.Drawing.Point(79, 84);
            this.btn_Int_Andar5.Name = "btn_Int_Andar5";
            this.btn_Int_Andar5.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar5.TabIndex = 18;
            this.btn_Int_Andar5.Text = "5º Andar";
            this.btn_Int_Andar5.UseVisualStyleBackColor = true;
            this.btn_Int_Andar5.Click += new System.EventHandler(this.ControlPanel);
            // 
            // lbl_Internal_Andar_Atual
            // 
            this.lbl_Internal_Andar_Atual.AutoSize = true;
            this.lbl_Internal_Andar_Atual.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Internal_Andar_Atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Internal_Andar_Atual.Location = new System.Drawing.Point(100, 47);
            this.lbl_Internal_Andar_Atual.Name = "lbl_Internal_Andar_Atual";
            this.lbl_Internal_Andar_Atual.Size = new System.Drawing.Size(33, 25);
            this.lbl_Internal_Andar_Atual.TabIndex = 19;
            this.lbl_Internal_Andar_Atual.Text = "---";
            this.lbl_Internal_Andar_Atual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_Logger
            // 
            this.list_Logger.FormattingEnabled = true;
            this.list_Logger.Location = new System.Drawing.Point(12, 290);
            this.list_Logger.Name = "list_Logger";
            this.list_Logger.Size = new System.Drawing.Size(473, 95);
            this.list_Logger.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Painel de Navegação Interno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Modo de operação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Painéis de Navegação Externo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Logger - Painel de Navegação Interno";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 248);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(254, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 214);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(496, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Logger);
            this.Controls.Add(this.lbl_Internal_Andar_Atual);
            this.Controls.Add(this.btn_Int_Andar5);
            this.Controls.Add(this.btn_Int_Andar4);
            this.Controls.Add(this.btn_Int_Andar3);
            this.Controls.Add(this.btn_Int_Andar2);
            this.Controls.Add(this.btn_Int_Andar1);
            this.Controls.Add(this.chc_Automatico);
            this.Controls.Add(this.chc_Manual);
            this.Controls.Add(this.lbl_EM);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Ext_Andar5);
            this.Controls.Add(this.btn_Ext_Andar2);
            this.Controls.Add(this.btn_Ext_Andar1);
            this.Controls.Add(this.btn_Ext_Andar4);
            this.Controls.Add(this.btn_Ext_Andar3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Ext_Andar3;
        public System.Windows.Forms.Button btn_Ext_Andar4;
        public System.Windows.Forms.Button btn_Ext_Andar1;
        public System.Windows.Forms.Button btn_Ext_Andar2;
        public System.Windows.Forms.Button btn_Ext_Andar5;
        public System.Windows.Forms.Label lbl_Status;
        public System.Windows.Forms.Label lbl_EM;
        public System.Windows.Forms.CheckBox chc_Manual;
        public System.Windows.Forms.CheckBox chc_Automatico;
        public System.Windows.Forms.Button btn_Int_Andar1;
        public System.Windows.Forms.Button btn_Int_Andar2;
        public System.Windows.Forms.Button btn_Int_Andar3;
        public System.Windows.Forms.Button btn_Int_Andar4;
        public System.Windows.Forms.Button btn_Int_Andar5;
        public System.Windows.Forms.Label lbl_Internal_Andar_Atual;
        public System.Windows.Forms.ListBox list_Logger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

