using Solitaire.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public class Card //карта = масть + достоинство
    {
        public CardSuitEnum suit { get; set; }
        CardValueEnum value { get; set; }
        bool bloked { get; set; } = false; //для Пирамиды
    }
}
