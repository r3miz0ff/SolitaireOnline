﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    /// <summary>
    /// Класс <c>Spider</c> наследуется от <see cref="Solitaire"/>. Реализует логику игры в "Паука"
    /// </summary>
    /// <para>
    /// В Пауке используется 2 колоды. В данной реализации это говорит о том, что в списке <see cref="Solitaire.deck"/> будет в 2 раза больше карт
    /// </para>
    public class Spider: Solitaire
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Spider() { }
        /// <summary>
        /// Этот метод заполняет игровое поле
        /// </summary>
        /// <remarks>
        /// Заполните <see cref="Solitaire.field"/> картами из <see cref="Solitaire.deck"/>.
        /// В <see cref="Solitaire.field"/> должно быть 10 массивов.
        /// </remarks>
        public void FillField()
        {
            //расположение карт 10 стопками с перевернутой верхней картой (2 колоды).
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
        public bool MoveCheck() //проверка, есть ли доступные ходы
        {
            //тут какая-то проверка
            return true;
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
        /// Сбор карт осуществляется в 8 стопок (т.к. 2 колоды) (каждая соответствует масти) от туза к королю.
        /// </remarks>
        public void CardToFoundation()
        {
            //cбор карт 4х мастей от короля к тузу дважды (8 стопок, т.к. 2 колоды).
        }
        /// <summary>
        /// Этот метод, проверяет возможно ли совершить ход.
        /// </summary>
        /// <remarks>
        /// Карта может быть размещена только на карту большего достоинства или на пустое место, группу карт можно перемещать, только если все карты одной масти в порядке убывания
        /// </remarks>
        /// <returns>
        /// Истина, если ход возможен. Ложь в противном случае.
        /// </returns>
        public bool CardMatch()
        {
            return true;
            //Сопоставление карт (карта может быть размещена только на карту большего достоинства или на пустое место, группу карт можно перемещать, только если все карты одной масти в порядке убывания).
        }
        /// <summary>
        /// Этот метод используется для повторного расклада карт.
        /// Если все возможнные ходы с текущим раскладом сделаны, раздаются новые 10 стопок.
        /// </summary>
        public void Refill() //Повторный расклад карт (если все возможные ходы с текущим раскладом сделаны, раздаются новые 10 стопок).
        {
            if (!MoveCheck())
            {
                FillField();
            }
        }
    }
}
