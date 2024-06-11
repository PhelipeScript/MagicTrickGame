using MagicTrickServer;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MagicTrickGame.Controllers
{
    public static class FetchPlayers
    {
        /// <summary>
        ///     Lista de jogadores de uma determinada partida, trazendo a quantidade atual de rodadas vencidas do round especificado e a pontuação na partida
        /// </summary>
        /// <param name="matchId"></param>
        /// <param name="round"></param>
        /// <returns>{Id do Jogador},{nome},{pontuação partida},{qtd rodadas vencidas} ou null caso der algum erro</returns>
        public static string Handle(int matchId, int round)
        {
            try
            {
                string response = Jogo.ListarJogadores2(matchId, round);
                if (response.Length > 0 && response.Substring(0, 4) == "ERRO")
                {
                    return null;
                }

                response = response.Replace("\r", "");
                if (response.Length == 0) return response;
                return response.Substring(0, response.Length - 1);
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

        /// <summary>
        ///     Lista de jogadores de uma determinada partida, trazendo a quantidade atual de rodadas vencidas do último round e a pontuação na partida
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns>{Id do Jogador},{nome},{pontuação partida},{qtd rodadas vencidas} ou null caso der algum erro</returns>
        public static string Handle(int matchId)
        {
            try
            {
                string response = Jogo.ListarJogadores2(matchId);
                if (response.Length > 0 && response.Substring(0, 4) == "ERRO")
                {
                    return null;
                }

                response = response.Replace("\r", "");
                if (response.Length == 0) return response;
                return response.Substring(0, response.Length - 1);
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
