using NLog;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Supervisorios___Trabalho_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {                
            InitializeComponent();
            Elevador.InitializeElavator(this);
            Simulador.ConfigSimulator(this);
            Log.InitializeLog(this);
        }

        private void ControlPanel(object sender, EventArgs e)
        {
            var andar = (sender as Button).Text;

            var local = ((sender as Button).Name).Contains("Int")?"Internamente":"Externamente";

            Log.Info($"{andar} chamado {local}", local);

            Elevador.SelecionarAndar(andar, local);
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
                    Simulador.ControlExternalNavegationPanel(true);
                    Elevador.filaAndaresChamados.RemoveRange(1, Elevador.filaAndaresChamados.Count() - 1);
                    Simulador.modoAutomatico = false;
                }
            }
            else if (txtControl == "Manual")
            {
                if (chc_Manual.Checked)
                    chc_Automatico.Checked = false;
                else
                {
                    Log.Info("Modo automatico iniciado");
                    chc_Automatico.Checked = true;
                    Simulador.modoAutomatico = true;
                    Simulador.ControlExternalNavegationPanel(false);
                    Task t = Task.Run(() => Simulador.InitializeAutomaticMode());
                }
            }
        }




    }
}
