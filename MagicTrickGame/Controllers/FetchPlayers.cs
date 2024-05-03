using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrickGame.Controllers
{
    internal class FetchPlayers
    {
        public static string Handle(int matchId)
        {
            try
            {
                string response = Jogo.ListarJogadores(matchId);
                if (response.Substring(0, 4) == "ERRO")
                {
                    MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                response = response.Replace("\r", "");
                return response.Substring(0, response.Length - 1);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro:\n {e}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
