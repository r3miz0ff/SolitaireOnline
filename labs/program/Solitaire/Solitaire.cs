using Solitaire.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solitaire
{
    /// <summary>
    /// Класс <c>Solitaire</c> - пасьянс
    /// <para>
    /// Реализовывает основную логику игры в пасьянс, общую для всех видов.
    /// </para>
    /// </summary>
    public class Solitaire //основная логика, общая для всех видов
    {
        /// <value>Колода, представляет собой список карт <see cref="Card"/></value>
        public List<Card> deck { get; set; } // колода
        /// <value>Игровое поле, представляет собой список массивов карт <see cref="Card"/></value>
        /// <remarks>Каждый массив представляет собой стопку карт в Клондайке <see cref="Klondike"/> или Пауке <see cref="Spider"/>, или "пирамиду" в Пирамиде <see cref="Pyramid"/></remarks>
        public List<Card[]> field { get; set; } // игровое поле
        /// <value>Время хода. Для подробной информации по работе с таймерами смотрите <see href="https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.timer?view=net-7.0"/></value>
        public Timer timer; // время хода
        /// <value>Очки, начисляемые игроку за собранный пасьянс</value>
        public int score;  // очки
        /// <value>Количество ходов, сделанных игроком</value>
        public int move; // ходы
        /// <summary>
        /// Этот метод сортирует колоды.
        /// </summary>
        /// <remarks>
        /// Используйте Random <see href="https://learn.microsoft.com/ru-ru/dotnet/api/system.random?view=net-8.0"/> для пересортировки <c>deck</c> <see cref="deck"/>
        /// </remarks>
        public void Sort()
        {
            //сортировка колоды
        }
        /// <summary>
        /// Этот метод раздает карты.
        /// </summary>
        /// <remarks>
        /// Используйте Random <see href="https://learn.microsoft.com/ru-ru/dotnet/api/system.random?view=net-8.0"/> для заполнения <c>deck</c> <see cref="deck"/> в случайном порядке
        /// </remarks>
        public void Draw()
        {
            //раздача
        }
        /// <summary>
        /// Этот метод вычисляет очки <see cref="score"/>
        /// </summary>
        /// <remarks>
        /// При подсчете очков должны учитываться количество ходо и время игры
        /// </remarks>
        /// <returns>
        /// Возвращает очки, записанные в <c>score</c> <see cref="score"/>
        /// </returns>
        public int GetScorePoints() //подсчет очков
        {
            return score;
        }

        /// <returns>
        /// Возвращает время игры, записанное в <c>timer</c> <see cref="timer"/>
        /// </returns>
        public Timer GetGameTime() //подсчет времени игры
        {
            return timer;
        }

        /// <returns>
        /// Возвращает количество ходов, записанное в <c>move</c> <see cref="move"/>
        /// </returns>
        public int GetMoveCount() //подсчет количества ходов
        {
            return move;
        }
    }
}
