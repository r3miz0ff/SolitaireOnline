using Solitaire.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    /// <summary>
    /// Класс <c>Card</c> - игральная карта
    /// </summary>
    public class Card //карта = масть + достоинство
    {
        /// <value>Масть карты</value>
        public CardSuitEnum suit { get; set; }
        /// <value>Достоинство карты</value>
        public CardValueEnum value { get; set; }
        /// <value>Заблокирована ли карта в <see cref="Pyramid"/>.</value>
        public bool bloked { get; set; } = false; //для Пирамиды

    }
}
