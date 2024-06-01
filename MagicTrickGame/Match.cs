using MagicTrickGame.Controllers;
using System;
using System.Collections.Generic;

namespace MagicTrickGame
{
    public class Match
    {
        int id;
        string name;
        DateTime date;
        char status;

        public int Id { get { return this.id; } }
        public string Name { get { return this.name; } }
        public DateTime Date { get { return this.date; } }
        public string Status 
        { 
            get
            {
                switch (this.status)
                {
                    case 'J': return "Jogando";
                    case 'A': return "Aberta";
                    case 'F': return "Finalizada";
                    case 'E': return "Empate";
                    default: return this.status.ToString();
                }
            }    
        }

        public Match(int id, string name, DateTime date, char status)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.status = status;
        }

        public static List<Match> All(string status)
        {
            string response = FetchMatches.Handle(status);

            if (response == null) return null;
            string[] matches = response.Split('\n');
            List<Match> allMatches = new List<Match>();

            for (int i = 0; i < matches.Length; i++)
            {
                string[] matchData = matches[i].Split(',');
                Match match = new Match(Convert.ToInt32(matchData[0]), matchData[1], Convert.ToDateTime(matchData[2]), Convert.ToChar(matchData[3]));
                allMatches.Add(match);
            }

            return allMatches;
        }
    }
}
