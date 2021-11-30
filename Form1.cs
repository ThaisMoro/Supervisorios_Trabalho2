using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Supervisorios___Trabalho_2
{
    public partial class Form1 : Form
    {
        int andarAtual = 1;
        static List<String> filaAndaresChamados = new List<String>();     
        static CancellationTokenSource src = new CancellationTokenSource();
        CancellationToken ct = src.Token;

        public Form1()
        {                
            InitializeComponent();
            ResetInternalNavegationPanel();
            Task t = Task.Run(() => MoveElevator());    
        }

        private void ControlPanel(object sender, EventArgs e)
        {
            var andar = (sender as Button).Text;

            var local = ((sender as Button).Name).Contains("Int")?"Internamente":"Externamente";
            
            switch (andar)
            {
                case "1º Andar":
                    filaAndaresChamados.Add(local + ";1");
                    break;
                case "2º Andar":
                    filaAndaresChamados.Add(local + ";2");
                    break;
                case "3º Andar":
                    filaAndaresChamados.Add(local + ";3");
                    break;
                case "4º Andar":
                    filaAndaresChamados.Add(local + ";4");
                    break;
                case "5º Andar":
                    filaAndaresChamados.Add(local + ";5");
                    break;
            }
        }

        public async Task MoveElevator()
        {
            while (true)
            {
                while (filaAndaresChamados.Count() > 0)
                {
                    var local = filaAndaresChamados.First().Split(';')[0];
                    var nAndar = int.Parse(filaAndaresChamados.First().Split(';')[1]);

                    if (nAndar > andarAtual)
                    {                        
                        Invoke(new Action(() => { lbl_EM.BackColor = Color.Red; }));
                        Invoke(new Action(() => { lbl_Status.Text = "Subindo"; }));

                        while (nAndar > andarAtual)
                        {
                            await Task.Delay(2000);
                            andarAtual++;
                            Invoke(new Action(() => { lbl_Internal_Andar_Atual.Text = andarAtual.ToString(); }));                            

                        }
                    }
                    else if (nAndar < andarAtual)
                    {
                        Invoke(new Action(() => { lbl_EM.BackColor = Color.Red; }));
                        Invoke(new Action(() => { lbl_Status.Text = "Descendo"; }));

                        while (nAndar < andarAtual)
                        {
                            await Task.Delay(2000);
                            andarAtual--;
                            Invoke(new Action(() => { lbl_Internal_Andar_Atual.Text = andarAtual.ToString(); }));
                        }
                    }

                    filaAndaresChamados.RemoveAt(0);                 
                    Invoke(new Action(() => { lbl_EM.BackColor = Color.White; }));
                    Invoke(new Action(() => { lbl_Status.Text = "Parado"; }));
                    await OpenAndCloseElavatorPort();

                }
            }
        }

        public async Task OpenAndCloseElavatorPort()
        {
            Invoke(new Action(() => { lbl_Internal_Andar_Atual.BackColor = Color.Green; }));
            await Task.Delay(1000);
            Invoke(new Action(() => { lbl_Internal_Andar_Atual.BackColor = Color.White; }));
            await Task.Delay(1000);
            Invoke(new Action(() => { lbl_Internal_Andar_Atual.BackColor = Color.Green; }));
            await Task.Delay(1000);
            Invoke(new Action(() => { lbl_Internal_Andar_Atual.BackColor = Color.White; }));
            await Task.Delay(1000);
        }
 

        public void ResetInternalNavegationPanel()
        {            
            lbl_EM.BackColor = Color.White;
            lbl_Status.Text = "Parado";
            chc_Manual.Checked = true;
            chc_Automatico.Checked = false;            
            andarAtual = 1;
            lbl_Internal_Andar_Atual.Text = andarAtual.ToString();
        }

        public void ControlExternalNavegationPanel(bool enable)
        {
            Button[] botoes = { btn_Ext_Andar1, btn_Ext_Andar2, btn_Ext_Andar3, btn_Ext_Andar4, btn_Ext_Andar5 };
            foreach(var botao in botoes)
            {
                botao.Enabled = enable;
            }
        }




    }
}
