using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;


namespace Sistemas_Supervisorios___Trabalho_2
{
    static class Elevador
    {
        static private Form1 tela;
        static public int andarAtual = 1;
        static public List<String> filaAndaresChamados = new List<String>(); 

        static public void SelecionarAndar(string andar, string local)
        {

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

        static public async Task MoveElevator()
        {
            while (true)
            {
                while (filaAndaresChamados.Count() > 0)
                {
                    var local = filaAndaresChamados.First().Split(';')[0];
                    var nAndar = int.Parse(filaAndaresChamados.First().Split(';')[1]);


                    Log.Info($"Indo para o andar numero {nAndar}", local);

                    if (nAndar > andarAtual)
                    {

                        tela.lbl_EM.BackColor = Color.Red;

                        tela.lbl_Status.BeginInvoke((Action)(() => tela.lbl_Status.Text = "Subindo"));

                        while (nAndar > andarAtual)
                        {
                            await Task.Delay(2000);
                            andarAtual++;
                            tela.lbl_Internal_Andar_Atual.BeginInvoke((Action)(() => tela.lbl_Internal_Andar_Atual.Text = andarAtual.ToString()));
                        }
                    }
                    else if (nAndar < andarAtual)
                    {
                        tela.lbl_EM.BackColor = Color.Red;
                        tela.lbl_Status.BeginInvoke((Action)(() => tela.lbl_Status.Text = "Descendo"));

                        while (nAndar < andarAtual)
                        {
                            await Task.Delay(2000);
                            andarAtual--;
                            tela.lbl_Status.BeginInvoke((Action)(() => tela.lbl_Internal_Andar_Atual.Text = andarAtual.ToString()));
                        }
                    }

                    Log.Info($"Andar numero {nAndar} alcancado", local);
                    filaAndaresChamados.RemoveAt(0);
                    tela.lbl_EM.BackColor = Color.White;
                    tela.lbl_Status.BeginInvoke((Action)(() => tela.lbl_Status.Text = "Parado"));
                    await OpenAndCloseElavatorPort();

                }
            }
        }

        static private async Task OpenAndCloseElavatorPort()
        {
            tela.lbl_Internal_Andar_Atual.BackColor = Color.Green; 
            await Task.Delay(1000);
            tela.lbl_Internal_Andar_Atual.BackColor = Color.White; 
            await Task.Delay(1000);
            tela.lbl_Internal_Andar_Atual.BackColor = Color.Green; 
            await Task.Delay(1000);
            tela.lbl_Internal_Andar_Atual.BackColor = Color.White;
            await Task.Delay(1000);
        }

        static public void InitializeElavator(Form1 telaForm)
        {
            tela = telaForm;
            tela.lbl_EM.BackColor = Color.White;
            tela.lbl_Status.Text = "Parado";
            tela.chc_Manual.Checked = true;
            tela.chc_Automatico.Checked = false;
            andarAtual = 1;
            tela.lbl_Internal_Andar_Atual.Text = andarAtual.ToString();
            Task t = Task.Run(() => Elevador.MoveElevator());
        }
    }
}
