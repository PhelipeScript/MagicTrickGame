using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTrickGame
{
    public class Strategy
    {
        public static void Handle(Player player, string turnData, List<Historic> historics)
        {
            if (turnData == null || player.status == PlayerStatus.Wait) return;
            if (player.status == PlayerStatus.Bet)
            {
                int betIndex = 8;
                Card betCard;

                do
                {
                    betCard = player.cards.Find(c => c.index == betIndex);
                    if (betCard == null) return;

                    betIndex--;
                } while(betCard.value != -1);

                player.BetCard(Convert.ToInt32(player.id), player.password, betCard.index);
            } 
            else if (turnData.Contains("C:")) // alguém jogou um carta
            {
                bool wantsToWin = player.bet != null ? player.score < player.bet.CardValue : true;
                List<Card> cardsPlayed = new List<Card>();

                foreach (string line in turnData.Split('\n'))
                {
                    string[] data = line.Split(',');
                    if (line.Contains("A:"))
                    {
                        historics.Add(new Historic(Convert.ToInt32(data[3]), data[1], Convert.ToInt32(data[2]), data[4]));
                    } 
                    else if (line.Contains("C:"))
                    {
                        cardsPlayed.Add(new Card(data[3], data[1], player.playerPosition));
                    }
                }

                List<Card> playerCardsLeft = player.cards.FindAll(card => card.value == -1 && card.suitLetter == cardsPlayed[0].suitLetter);
                historics.RemoveAll(historic => historic.card.suitLetter != cardsPlayed[0].suitLetter);

                if (playerCardsLeft.Count == 1)
                {
                    player.PlayCard(Convert.ToInt32(player.id), player.password, playerCardsLeft[0].index);
                } 
                else if (wantsToWin)
                {
                    if (playerCardsLeft.Count == 0)
                    {
                        if (player.cards.Exists(card => card.value == -1 && card.suitLetter == 'C') && cardsPlayed.Exists(card => card.suitLetter == 'C') == false)
                        {
                            Card heartCard = player.cards.Find(card => card.value == -1 && card.suitLetter == 'C');
                            player.PlayCard(Convert.ToInt32(player.id), player.password, heartCard.index);
                        }
                        else
                        {
                            Card lowestCard = player.cards.Find(card => card.value == -1);
                            if (lowestCard != null)
                            {
                                player.PlayCard(Convert.ToInt32(player.id), player.password, lowestCard.index);
                            }
                        }
                    } 
                    else
                    {
                        if (playerCardsLeft.Exists(card => card.suitLetter == 'C') == false && cardsPlayed.Exists(card => card.suitLetter == 'C'))
                        {
                            player.PlayCard(Convert.ToInt32(player.id), player.password, playerCardsLeft[0].index);
                        }
                        else
                        {
                            int highestValuePlayed = 0;
                            foreach (Card card in cardsPlayed)
                            {
                                if (card.value > highestValuePlayed)
                                {
                                    highestValuePlayed = card.value;
                                }
                            }

                            List<int> highestValuesInHistoric = new List<int>();
                            foreach (Historic historic in historics)
                            {
                                if (historic.card.value > highestValuePlayed)
                                {
                                    highestValuesInHistoric.Add(historic.card.value);
                                }
                            }

                            if (highestValuePlayed + highestValuesInHistoric.Count == 7) 
                            {
                                player.PlayCard(Convert.ToInt32(player.id), player.password, playerCardsLeft[0].index);
                            } 
                            else 
                            { // da pra melhorar esse else
                                player.PlayCard(Convert.ToInt32(player.id), player.password, playerCardsLeft[playerCardsLeft.Count - 1].index);
                            }
                        }
                    }
                }
                else
                {
                    if (playerCardsLeft.Count == 0)
                    {
                        if (player.cards.Exists(card => card.value == -1 && card.suitLetter != 'C'))
                        {
                            List<Card> playerCards = player.cards.FindAll(card => card.value == -1 && card.suitLetter != 'C');
                            player.PlayCard(Convert.ToInt32(player.id), player.password, playerCards[playerCards.Count-1].index);
                        }
                        else
                        {
                            Card lowestHeartCard = player.cards.Find(card => card.value == -1);
                            player.PlayCard(Convert.ToInt32(player.id), player.password, lowestHeartCard.index);
                        }
                    }
                    else
                    {
                        if (playerCardsLeft.Exists(card => card.suitLetter == 'C') == false && cardsPlayed.Exists(card => card.suitLetter == 'C'))
                        {
                            player.PlayCard(Convert.ToInt32(player.id), player.password, playerCardsLeft[playerCardsLeft.Count-1].index);
                        }
                        else
                        {
                            int highestValuePlayed = 0;
                            foreach (Card card in cardsPlayed)
                            {
                                if (card.value > highestValuePlayed)
                                {
                                    highestValuePlayed = card.value;
                                }
                            }

                            List<int> highestValuesInHistoric = new List<int>();
                            foreach (Historic historic in historics)
                            {
                                if (historic.card.value > highestValuePlayed)
                                {
                                    highestValuesInHistoric.Add(historic.card.value);
                                }
                            }

                            if (highestValuePlayed + highestValuesInHistoric.Count == 7)
                            {
                                player.PlayCard(Convert.ToInt32(player.id), player.password, playerCardsLeft[playerCardsLeft.Count-1].index);
                            }
                            else
                            { 
                                player.PlayCard(Convert.ToInt32(player.id), player.password, playerCardsLeft[0].index);
                            }
                        }
                    }
                }
            }
            else // ninguém jogou um carta ainda
            {
                bool wantsToWin = player.bet != null ? player.score < player.bet.CardValue : true;
                List<Card> cardsLeft = player.cards.FindAll(card => card.value == -1);

                if (wantsToWin)
                {
                    player.PlayCard(Convert.ToInt32(player.id), player.password, cardsLeft[cardsLeft.Count-1].index);
                }
                else
                {
                    player.PlayCard(Convert.ToInt32(player.id), player.password, cardsLeft[0].index);
                }
            }
        }
    }
}
