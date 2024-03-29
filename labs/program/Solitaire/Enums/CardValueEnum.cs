﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Enums
{
    /// <summary>
    /// Тип перечисления, предназначенный для записи достоинства карты.
    /// <example>
    /// Например, туз:
    /// <code>
    /// var card = new Card();
    /// card.suit = CardValueEnum.Ace
    /// </code>
    /// </example>
    /// </summary>
    public enum CardValueEnum //достоинство карты
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}
