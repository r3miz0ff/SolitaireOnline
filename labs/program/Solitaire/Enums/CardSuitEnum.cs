using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Enums
{
    /// <summary>
    /// Тип перечисления, предназначенный для записи масти карты.
    /// <example>
    /// Например, карта с мастью - "Черва":
    /// <code>
    /// var card = new Card();
    /// card.suit = CardSuitEnum.Heart 
    /// </code>
    /// </example>
    /// </summary>
    public enum CardSuitEnum //масть карты
    {
        Spade,
        Heart,
        Club,
        Diamond
    }
}
