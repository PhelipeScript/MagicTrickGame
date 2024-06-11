using System.Collections.Generic;
using System.Drawing;

namespace MagicTrickGame
{
    public static class CardImages
    {
        static Dictionary<char, Dictionary<PlayerPosition, Bitmap>> images = new Dictionary<char, Dictionary<PlayerPosition, Bitmap>>
        {
            {
                'C', new Dictionary<PlayerPosition, Bitmap>
                {
                    { PlayerPosition.LEFT, Properties.Resources.Copas4 },
                    { PlayerPosition.TOP, Properties.Resources.Copas3 },
                    { PlayerPosition.RIGHT, Properties.Resources.Copas2 },
                    { PlayerPosition.BOTTOM, Properties.Resources.Copas1 }
                }
            },
            {
                'E', new Dictionary<PlayerPosition, Bitmap>
                {
                    { PlayerPosition.LEFT, Properties.Resources.Espadas4 },
                    { PlayerPosition.TOP, Properties.Resources.Espadas3 },
                    { PlayerPosition.RIGHT, Properties.Resources.Espadas2 },
                    { PlayerPosition.BOTTOM, Properties.Resources.Espadas1 }
                }
            },
            {
                'L', new Dictionary<PlayerPosition, Bitmap>
                {
                    { PlayerPosition.LEFT, Properties.Resources.Lua4 },
                    { PlayerPosition.TOP, Properties.Resources.Lua3 },
                    { PlayerPosition.RIGHT, Properties.Resources.Lua2 },
                    { PlayerPosition.BOTTOM, Properties.Resources.Lua1 }
                }
            },
            {
                'O', new Dictionary<PlayerPosition, Bitmap>
                {
                    { PlayerPosition.LEFT, Properties.Resources.Ouros4 },
                    { PlayerPosition.TOP, Properties.Resources.Ouros3 },
                    { PlayerPosition.RIGHT, Properties.Resources.Ouros2 },
                    { PlayerPosition.BOTTOM, Properties.Resources.Ouros1 }
                }
            },
            {
                'P', new Dictionary<PlayerPosition, Bitmap>
                {
                    { PlayerPosition.LEFT, Properties.Resources.Paus4 },
                    { PlayerPosition.TOP, Properties.Resources.Paus3 },
                    { PlayerPosition.RIGHT, Properties.Resources.Paus2 },
                    { PlayerPosition.BOTTOM, Properties.Resources.Paus1 }
                }
            },
            {
                'S', new Dictionary<PlayerPosition, Bitmap>
                {
                    { PlayerPosition.LEFT, Properties.Resources.Estrela4 },
                    { PlayerPosition.TOP, Properties.Resources.Estrela3 },
                    { PlayerPosition.RIGHT, Properties.Resources.Estrela2 },
                    { PlayerPosition.BOTTOM, Properties.Resources.Estrela1 }
                }
            },
            {
                'T', new Dictionary<PlayerPosition, Bitmap>
                {
                    { PlayerPosition.LEFT, Properties.Resources.Triângulo4 },
                    { PlayerPosition.TOP, Properties.Resources.Triângulo3 },
                    { PlayerPosition.RIGHT, Properties.Resources.Triângulo2 },
                    { PlayerPosition.BOTTOM, Properties.Resources.Triângulo1 }
                }
            },
        };

        public static Bitmap Image(char suitLetter, PlayerPosition playerPosition)
        {
            return images[suitLetter][playerPosition]; 
        }
    }
}
