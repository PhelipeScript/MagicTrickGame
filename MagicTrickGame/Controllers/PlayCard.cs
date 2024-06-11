using MagicTrickServer;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MagicTrickGame.Controllers
{
    public static class PlayCard
    {
        /// <summary>
        ///     Efetua uma jogada jogando uma carta
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="playerPassword"></param>
        /// <param name="cardIndex"></param>
        /// <returns>Valor da carta jogada ou null em caso de erro</returns>
        public static string Handle(int playerId, string playerPassword, int cardIndex)
        {
            try
            {
                string response = Jogo.Jogar(playerId, playerPassword, cardIndex);
                if (response.Length >= 4 && response.Substring(0, 4) == "ERRO")
                {
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
