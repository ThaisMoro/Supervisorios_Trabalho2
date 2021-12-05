using NLog;
using System;
using System.IO;
using System.Linq;

namespace Sistemas_Supervisorios___Trabalho_2
{
    static class Log
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();
        static private Form1 tela;

        static public void InitializeLog(Form1 telaForm1)
        {
            tela = telaForm1;
        }

        static public void Info(String mensagem, String local = "")
        {

            if (local == "Internamente")
            {
                log.Info(mensagem);

                var logFile = File.ReadAllLines(@"log.log");
                int visibleItems = 0;

                tela.list_Logger.BeginInvoke((Action)(() => tela.list_Logger.Items.Clear()));
                tela.list_Logger.BeginInvoke((Action)(() => tela.list_Logger.Items.AddRange(logFile)));
                tela.list_Logger.BeginInvoke((Action)(() => visibleItems = tela.list_Logger.ClientSize.Height / tela.list_Logger.ItemHeight));
                tela.list_Logger.BeginInvoke((Action)(() => tela.list_Logger.TopIndex = Math.Max(tela.list_Logger.Items.Count - visibleItems + 1, 0)));
            }

        }
    }
}
