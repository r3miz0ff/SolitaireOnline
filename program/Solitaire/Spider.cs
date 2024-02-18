using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public class Spider: Solitaire
    {
        public Spider() { }
        void FillField()
        {
            //расположение карт 10 стопками с перевернутой верхней картой (2 колоды).
        }
        void Move()
        {
            //сделать ход
        }

        void MoveCancel()
        {
            //отмена хода
        }
        bool MoveCheck() //проверка, есть ли доступные ходы
        {
            //тут какая-то проверка
            return true;
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
            //cбор карт 4х мастей от короля к тузу дважды (8 стопок, т.к. 2 колоды).
        }

        void CardMatch()
        {
            //Сопоставление карт (карта может быть размещена только на карту большего достоинства или на пустое место, группу карт можно перемещать, только если все карты одной масти в порядке убывания).
        }

        void Refill() //Повторный расклад карт (если все возможные ходы с текущим раскладом сделаны, раздаются новые 10 стопок).
        {
            if (!MoveCheck())
            {
                FillField();
            }
        }
    }
}
