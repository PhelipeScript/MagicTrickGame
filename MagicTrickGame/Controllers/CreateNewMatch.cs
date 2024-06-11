using MagicTrickServer;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace MagicTrickGame.Controllers
{
    public class CreateNewMatch
    {
        const string groupName = "atenas";

        /// <summary>
        ///     Cria uma nova partida
        /// </summary>
        /// <param name="matchName"></param>
        /// <param name="matchPassword"></param>
        /// <returns>
        ///     id da partida criada ou null caso ocorra algum erro.
        /// </returns>
        public static string Handle(string matchName, string matchPassword)
        {
            try
            {
                string response = Jogo.CriarPartida(matchName, matchPassword, groupName);
                if (response.Length > 4 && response.Substring(0, 4) == "ERRO")
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
