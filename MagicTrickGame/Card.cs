using MagicTrickGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTrickGame
{

    public class Card
    {
        public char suitLetter;
        public string suitName;
        public int value;
        public int index;
        public Bitmap img;
        private Dictionary<char, string> suitNamesDict = new Dictionary<char, string>
        {
            { 'C', "Copas" },
            { 'E', "Espadas" },
            { 'L', "Lua" },
            { 'O', "Ouros" },
            { 'P', "Paus" },
            { 'S', "Estrela" },
            { 'T', "Triângulo" },
        };

        public Card(string index, string suitLetter, PlayerPosition playerPosition)
        {
            this.index = Convert.ToInt32(index);
            this.suitLetter = Convert.ToChar(suitLetter);
            this.suitName = this.suitNamesDict[this.suitLetter];
            this.value = -1;
            this.img = CardImages.Image(this.suitLetter, playerPosition);
        }
    }
}