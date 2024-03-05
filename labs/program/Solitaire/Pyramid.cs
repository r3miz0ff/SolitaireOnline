using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    /// <summary>
    /// Класс <c>Pyramid</c> наследуется от <see cref="Solitaire"/>. Реализует логику игры в "Пирамиду"
    /// </summary>
    public class Pyramid: Solitaire //Пирамида
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Pyramid() { }
        /// <summary>
        /// Этот метод заполняет игровое поле
        /// </summary>
        /// <remarks>
        /// Заполните <see cref="Solitaire.field"/> картами из <see cref="Solitaire.deck"/>.
        /// В <see cref="Solitaire.field"/> должно быть 7 массивов. В первом - 1 карта, во втором - 2 и т.д.
        /// Необходимо учитывать, что в пасьянсе карты располагаются не стопками, а рядами, блокируя друг друга
        /// </remarks>
        public void FillField()
        {
            //расположение карт «пирамидой»
        }
        /// <summary>
        /// Этот метод реализует ход игрока в пасьянсе.
        /// Если <see cref="CardMatch"/> вернул истину, то выбранные карты удаляются из <see cref="Solitaire.field"/>
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
        /// Этот метод, проверяет возможно ли совершить ход.
        /// </summary>
        /// <remarks>
        /// Cумма достоинств карт должна быть равна 13
        /// </remarks>
        /// <returns>
        /// Истина, если ход возможен. Ложь в противном случае.
        /// </returns>
        public void CardMatch()
        {
            //сопоставление карт (сумма достоинств карт должна быть равна 13).
        }
        /// <summary>
        /// Этот метод устанавливает свойство <see cref="Card.bloked"/> = true.
        /// </summary>
        /// <remarks>
        /// Используется, если карту сверху перекрывает другая карта
        /// </remarks>
        public void CardBlock()
        {
            //блокировка карты
        }
    }
}
