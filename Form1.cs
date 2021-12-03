using NLog;
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
        static int andarAtual = 1;
        static List<String> filaAndaresChamados = new List<String>();
        private static readonly Logger log = LogManager.GetCurrentClassLogger();
        bool modoAutomatico = false;

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

            logger(local, $"{andar} chamado {local}");

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

                    Invoke(new Action(() => {
                        logger(local,$"Indo para o andar numero {nAndar}");
                    }));

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

                    Invoke(new Action(() => { logger(local,$"Andar numero {nAndar} alcancado"); }));
                    filaAndaresChamados.RemoveAt(0);                 
                    Invoke(new Action(() => { lbl_EM.BackColor = Color.White; }));
                    Invoke(new Action(() => { lbl_Status.Text = "Parado"; }));
                    await OpenAndCloseElavatorPort();

                }
            }
        }

        public void logger(String local,String mensagem)
        {

            if (local == "Internamente")
            {
                log.Info(mensagem);

                var logFile = File.ReadAllLines(@"log.log");

                list_Logger.Items.Clear();
                list_Logger.Items.AddRange(logFile);
                int visibleItems = list_Logger.ClientSize.Height / list_Logger.ItemHeight;
                list_Logger.TopIndex = Math.Max(list_Logger.Items.Count - visibleItems + 1, 0);
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

        private void ChangeControl(object sender, EventArgs e)
        {
            var txtControl = (sender as CheckBox).Text;

            if (txtControl == "Automático")
            {
                if (chc_Automatico.Checked)
                    chc_Manual.Checked = false;
                else
                {
                    chc_Manual.Checked = true;
                    ControlExternalNavegationPanel(true);
                    filaAndaresChamados.RemoveRange(1, filaAndaresChamados.Count() - 1);
                    modoAutomatico = false;
                }
            }
            else if (txtControl == "Manual")
            {
                if (chc_Manual.Checked)
                    chc_Automatico.Checked = false;
                else
                {
                    chc_Automatico.Checked = true;
                    modoAutomatico = true;
                    ControlExternalNavegationPanel(false);
                    Task t = Task.Run(() => AutomaticControlAsync());
                }
            }
        }

        public async void AutomaticControlAsync()
        {
            Random rnd = new Random();

            while (modoAutomatico)
            {
                int rndAndar = rnd.Next(1, 5);

                if (rndAndar == andarAtual)
                    continue;

                filaAndaresChamados.Add("Automaticamente;" + rndAndar.ToString());

                await Task.Delay(10000);
            }

        }


    }
}
