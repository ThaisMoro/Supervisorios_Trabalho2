
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
            this.SuspendLayout();
            // 
            // btn_Ext_Andar1
            // 
            this.btn_Ext_Andar1.Location = new System.Drawing.Point(461, 243);
            this.btn_Ext_Andar1.Name = "btn_Ext_Andar1";
            this.btn_Ext_Andar1.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar1.TabIndex = 2;
            this.btn_Ext_Andar1.Text = "1º Andar";
            this.btn_Ext_Andar1.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar1.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Ext_Andar2
            // 
            this.btn_Ext_Andar2.Location = new System.Drawing.Point(552, 243);
            this.btn_Ext_Andar2.Name = "btn_Ext_Andar2";
            this.btn_Ext_Andar2.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar2.TabIndex = 3;
            this.btn_Ext_Andar2.Text = "2º Andar";
            this.btn_Ext_Andar2.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar2.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Ext_Andar3
            // 
            this.btn_Ext_Andar3.Location = new System.Drawing.Point(461, 214);
            this.btn_Ext_Andar3.Name = "btn_Ext_Andar3";
            this.btn_Ext_Andar3.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar3.TabIndex = 0;
            this.btn_Ext_Andar3.Text = "3º Andar";
            this.btn_Ext_Andar3.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar3.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Ext_Andar4
            // 
            this.btn_Ext_Andar4.Location = new System.Drawing.Point(552, 214);
            this.btn_Ext_Andar4.Name = "btn_Ext_Andar4";
            this.btn_Ext_Andar4.Size = new System.Drawing.Size(75, 23);
            this.btn_Ext_Andar4.TabIndex = 1;
            this.btn_Ext_Andar4.Text = "4º Andar";
            this.btn_Ext_Andar4.UseVisualStyleBackColor = true;
            this.btn_Ext_Andar4.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Ext_Andar5
            // 
            this.btn_Ext_Andar5.Location = new System.Drawing.Point(552, 185);
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
            this.lbl_Status.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Status.Location = new System.Drawing.Point(478, 189);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(41, 13);
            this.lbl_Status.TabIndex = 10;
            this.lbl_Status.Text = "Parado";
            // 
            // lbl_EM
            // 
            this.lbl_EM.AutoSize = true;
            this.lbl_EM.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_EM.Location = new System.Drawing.Point(127, 210);
            this.lbl_EM.Name = "lbl_EM";
            this.lbl_EM.Size = new System.Drawing.Size(23, 13);
            this.lbl_EM.TabIndex = 11;
            this.lbl_EM.Text = "EM";
            // 
            // chc_Manual
            // 
            this.chc_Manual.AutoSize = true;
            this.chc_Manual.BackColor = System.Drawing.SystemColors.Control;
            this.chc_Manual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chc_Manual.Location = new System.Drawing.Point(475, 122);
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
            this.chc_Automatico.Location = new System.Drawing.Point(552, 122);
            this.chc_Automatico.Name = "chc_Automatico";
            this.chc_Automatico.Size = new System.Drawing.Size(79, 17);
            this.chc_Automatico.TabIndex = 13;
            this.chc_Automatico.Text = "Automático";
            this.chc_Automatico.UseVisualStyleBackColor = false;
            this.chc_Automatico.CheckedChanged += new System.EventHandler(this.ChangeControl);
            // 
            // btn_Int_Andar1
            // 
            this.btn_Int_Andar1.Location = new System.Drawing.Point(170, 268);
            this.btn_Int_Andar1.Name = "btn_Int_Andar1";
            this.btn_Int_Andar1.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar1.TabIndex = 14;
            this.btn_Int_Andar1.Text = "1º Andar";
            this.btn_Int_Andar1.UseVisualStyleBackColor = true;
            this.btn_Int_Andar1.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Int_Andar2
            // 
            this.btn_Int_Andar2.Location = new System.Drawing.Point(170, 233);
            this.btn_Int_Andar2.Name = "btn_Int_Andar2";
            this.btn_Int_Andar2.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar2.TabIndex = 15;
            this.btn_Int_Andar2.Text = "2º Andar";
            this.btn_Int_Andar2.UseVisualStyleBackColor = true;
            this.btn_Int_Andar2.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Int_Andar3
            // 
            this.btn_Int_Andar3.Location = new System.Drawing.Point(170, 198);
            this.btn_Int_Andar3.Name = "btn_Int_Andar3";
            this.btn_Int_Andar3.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar3.TabIndex = 16;
            this.btn_Int_Andar3.Text = "3º Andar";
            this.btn_Int_Andar3.UseVisualStyleBackColor = true;
            this.btn_Int_Andar3.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Int_Andar4
            // 
            this.btn_Int_Andar4.Location = new System.Drawing.Point(170, 163);
            this.btn_Int_Andar4.Name = "btn_Int_Andar4";
            this.btn_Int_Andar4.Size = new System.Drawing.Size(75, 23);
            this.btn_Int_Andar4.TabIndex = 17;
            this.btn_Int_Andar4.Text = "4º Andar";
            this.btn_Int_Andar4.UseVisualStyleBackColor = true;
            this.btn_Int_Andar4.Click += new System.EventHandler(this.ControlPanel);
            // 
            // btn_Int_Andar5
            // 
            this.btn_Int_Andar5.Location = new System.Drawing.Point(170, 128);
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
            this.lbl_Internal_Andar_Atual.Location = new System.Drawing.Point(189, 112);
            this.lbl_Internal_Andar_Atual.Name = "lbl_Internal_Andar_Atual";
            this.lbl_Internal_Andar_Atual.Size = new System.Drawing.Size(16, 13);
            this.lbl_Internal_Andar_Atual.TabIndex = 19;
            this.lbl_Internal_Andar_Atual.Text = "---";
            // 
            // list_Logger
            // 
            this.list_Logger.FormattingEnabled = true;
            this.list_Logger.Location = new System.Drawing.Point(111, 301);
            this.list_Logger.Name = "list_Logger";
            this.list_Logger.Size = new System.Drawing.Size(519, 95);
            this.list_Logger.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

