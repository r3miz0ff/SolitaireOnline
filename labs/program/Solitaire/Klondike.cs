using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    /// <summary>
    /// Класс <c>Klondike</c> наследуется от <see cref="Solitaire"/>. Реализует логику игры в "Клондайк"
    /// </summary>
    public class Klondike: Solitaire //Клондайк
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Klondike() { }
        /// <summary>
        /// Этот метод заполняет игровое поле
        /// </summary>
        /// <remarks>
        /// Заполните <see cref="Solitaire.field"/> картами из <see cref="Solitaire.deck"/>.
        /// В <see cref="Solitaire.field"/> должно быть 7 массивов. В первом - 1 карта, во втором - 2 и т.д.
        /// </remarks>
        public void FillField()
        {
            //расположение карт 7 стопками с перевернутой верхней картой (в первой стопке только 1 карта, во второй – 2 и т.д.).
        }
        /// <summary>
        /// Этот метод реализует ход игрока в пасьянсе.
        /// Если <see cref="CardMatch"/> вернул истину, то карта перемещается из одного массива в <see cref="Solitaire.field"/> в другой.
        /// </summary>
        public void Move()
        {
            //сделать ход
        }
        /// <summary>
        /// Метод, обратный методу <see cref="Move"/>
        /// </summary>
        public void MoveCancel()
        {
            //отмена хода
        }
        /// <summary>
        /// Этот метод, проверяет есть ли доступные ходы. Если нет - игра завершается
        /// </summary>
        /// <returns>
        /// Истина, если ход есть. Ложь в противном случае
        /// </returns>
        public bool MoveCheck()
        {
            return true;
            //проверка, есть ли доступные ходы
        }
        /// <summary>
        /// Этот метод, автоматически решает пасьянс.
        /// </summary>
        /// <remarks>
        /// Решение должно выполняться пошагово.
        /// </remarks>
        public void Solve()
        {
            //автоматическое решение пасьянса
        }
        /// <summary>
        /// Этот метод, предлагает какой ход можно сделать
        /// </summary>
        public void Hint()
        {
            //подсказка
        }
        /// <summary>
        /// Этот метод, отвечает за сбор карт, т.е. перемещение их в массивы в <see cref="Solitaire.field"/> , отвечающие за стопки, в которые собираются карты.
        /// </summary>
        /// <remarks>
        /// Сбор карт осуществляется в 4 стопки (каждая соответствует масти) от туза к королю.
        /// </remarks>
        public void CardToFoundation()
        {
            //cбор карт 4х мастей от туза к королю.
        }
        /// <summary>
        /// Этот метод, проверяет возможно ли совершить ход.
        /// </summary>
        /// <remarks>
        /// Карта может быть размещена только на карту большего достоинства и другого цвета или на пустое место, группы карт перемещаются аналогично
        /// </remarks>
        /// <returns>
        /// Истина, если ход возможен. Ложь в противном случае.
        /// </returns>
        public bool CardMatch()
        {
            return true;
            //Сопоставление карт (карта может быть размещена только на карту большего достоинства и другого цвета или на пустое место, группы карт перемещаются аналогично).
        }
    }
}
