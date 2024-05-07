﻿using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrickGame.Controllers
{
    public static class FetchCards
    {
        /// <summary>
        ///     Retorna as cartas que os jogadores possuem atualmente
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns>{Jogador},{Posicao},{Naipe}\n{Jogador},{Posicao},{Naipe} ou null caso houve algum erro</returns>
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
