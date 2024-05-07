using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrickGame.Controllers
{
    public static class BetCard
    {
        /// <summary>
        ///     Efetua uma aposta jogando uma carta
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="playerPassword"></param>
        /// <param name="cardIndex"></param>
        /// <returns>Valor da carta apostada ou null em caso de erro</returns>
        public static string Handle(int playerId, string playerPassword, int cardIndex)
        {
            try
            {
                string response = Jogo.Apostar(playerId, playerPassword, cardIndex);
                if (response.Length >= 4 && response.Substring(0, 4) == "ERRO")
                {
                    MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return response;
            }
            catch (SqlException)
            {
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro:\n {e}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
