using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Supervisorios___Trabalho_2
{
    static class Simulador
    {
        static private Form1 tela;
        static public bool modoAutomatico = false;

        static public void ConfigSimulator(Form1 telaForm1)
        {
            tela = telaForm1;
        }

        static public async void InitializeAutomaticMode()
        {            
            Random rnd = new Random();

            while (modoAutomatico)
            {
                int rndAndar = rnd.Next(1, 5);

                if (rndAndar == Elevador.andarAtual)
                    continue;

                Elevador.filaAndaresChamados.Add("Automaticamente;" + rndAndar.ToString());

                await Task.Delay(10000);
            }

        }

        static public void ControlExternalNavegationPanel(bool enable)
        {
            Button[] botoes = { tela.btn_Ext_Andar1, tela.btn_Ext_Andar2, tela.btn_Ext_Andar3, tela.btn_Ext_Andar4, tela.btn_Ext_Andar5 };
            foreach (var botao in botoes)
            {
                botao.Enabled = enable;
            }
        }
    }
}
