using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrickGame.Controllers
{
    public class FetchHistoric
    {
        public static string Handle(int matchId, int round)
        {
            string response = Jogo.ExibirJogadas2(matchId, round);
            if (response == "") return null;
            if (response.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            response = response.Replace("\r", "");
            return response.Substring(0, response.Length - 1);
        }
    }
}
