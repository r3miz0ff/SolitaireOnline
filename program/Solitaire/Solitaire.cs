using Solitaire.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solitaire
{
    public class Solitaire //основная логика, общая для всех видов
    {
        List<Card> deck { get; set; } // колода
        List<Card[]> field { get; set; } // игровое поле
        Timer timer; // время хода
        int score;  // очки
        int move; // ходы
        void Sort()
        {
            //сортировка колоды
        }

        void Draw()
        {
            //раздача (случайное заполнение deck)
        }
        void GetScorePoints()
        {
            //подсчет очков
        }
        
        void GetGameTime()
        {
            //подсчет времени игры
        }

        void GetMoveCount()
        {
            //подсчет количества ходов
        }
    }

    public class Card //карта = масть + достоинство
    {
        public CardSuitEnum suit { get; set;}
        CardValueEnum value { get; set; }
        bool bloked { get; set; } = false; //для Пирамиды
    }
}
