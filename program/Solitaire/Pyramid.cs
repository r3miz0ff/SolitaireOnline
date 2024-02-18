using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public class Pyramid: Solitaire //Пирамида
    {
        public Pyramid() { }
        void FillField()
        {
            //расположение карт «пирамидой»
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

        void CardMatch()
        {
            //сопоставление карт (карта может быть размещена только на карту большего достоинства и другого цвета или на пустое место, группы карт перемещаются аналогично).
        }

        void CardBlock()
        {
            //блокировка карты
        }
    }
}
