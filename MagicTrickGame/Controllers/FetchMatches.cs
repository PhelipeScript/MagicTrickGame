using MagicTrickServer;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace MagicTrickGame.Controllers
{
    public class FetchMatches
    {
        //
        // Resumo:
        //     Retorna a lista de partidas do tipo solicitado
        //
        // Parâmetros:
        //   status:
        //     Envie um caracter: (T)odas, (A)bertas, (J)ogando, (F)inalizadas
        //
        // Devoluções:
        //     Id, nome, data de criação e status


        /// <summary>
        ///     Retorna a lista de partidas do tipo solicitado: (T)odas, (A)bertas, (J)ogando, (F)inalizadas, (E)mpatadas
        /// </summary>
        /// <param name="status"></param>
        /// <returns>
        ///     A lista de partidas do tipo solicitado separadas por '\n' ou null caso nenhuma partida for encontrada ou ocorrer algum erro.
        /// </returns>
        public static string Handle(string status)
        {
            if (status != "T" && status != "A" && status != "J" && status != "F" && status != "E")
                status = "T";

            try
            {
                string response = Jogo.ListarPartidas(status);

                if (response.Length <= 0)
                {
                    MessageBox.Show($"Nenhuma partida encontrada", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

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
