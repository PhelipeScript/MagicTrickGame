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
    public static class CheckTurn
    {
        /// <summary>
        ///     Exibe todas informações do momento do jogo (i.e. de quem é a vez, cartas apostadas, cartas jogadas naquele turno)
        ///     Status da partida -> J(jogando) | F(finalizada) | E(empate)
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns>
        ///     null caso houve algum erro, senão:
        ///     {Status da Partida},{Id do jogador da vez},{numero da rodada},{status da rodada}\n
        ///     {A}:{Id do jogador que apostou},{naipe},{valor},{numero da rodada},{index da carta}\n
        ///     {C}:{Id do jogador que jogou essa carta},{naipe},{valor},{index da carta}
        /// </returns>
        public static string Handle(int matchId)
        {
            try
            {
                string response = Jogo.VerificarVez2(matchId);
                if (response.Substring(0, 4) == "ERRO")
                {
                    MessageBox.Show($"Ocorreu um erro:\n {response.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                response = response.Replace("\r", "");
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
