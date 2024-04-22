using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrickGame.Controllers
{
    public class FetchCards
    {
        //
        // Resumo:
        //     Retorna as cartas que os jogadores possuem atualmente
        //
        // Parâmetros:
        //     Id da partida
        //
        // Devoluções:
        //     {Jogador},{Posicao},{Naipe}\n{Jogador},{Posicao},{Naipe} ou null caso houve algum erro
        public static string Handle(int matchId)
        {
            try
            {
                string response = Jogo.ConsultarMao(matchId);
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
