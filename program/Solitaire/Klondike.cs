using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public class Klondike: Solitaire //Клондайк
    {
        public Klondike() { }
        void FillField()
        {
            //расположение карт 7 стопками с перевернутой верхней картой (в первой стопке только 1 карта, во второй – 2 и т.д.).
        }
        void Move()
        {
            //сделать ход
        }

        void MoveCancel()
        {
            //отмена хода
        }
        void MoveCheck()
        {
            //проверка, есть ли доступные ходы
        }
        void Solve()
        {
            //автоматическое решение пасьянса
        }
        void Hint()
        {
            //подсказка
        }
        void CardToFoundation()
        {
            //cбор карт 4х мастей от туза к королю.
        }

        void CardMatch()
        {
            //Сопоставление карт (карта может быть размещена только на карту большего достоинства и другого цвета или на пустое место, группы карт перемещаются аналогично).
        }
    }
}
