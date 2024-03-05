using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireDB
{
    /// <summary>
    /// Класс <c>Account</c> - аккаунт игрока
    /// </summary>
    public class Account //аккаунт
    {
        /// <summary>
        /// <value>ID аккаунта</value>
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// <value>никнейм аккаунта</value>
        /// </summary>
        public string name { get; set; } //никнейм
        /// <summary>
        /// <value>статистика аккаунта (очки и достижения)</value>
        /// </summary>
        public string statistics { get; set; } //статистика
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Account() { }
        /// <summary>
        /// Регистрация аккаунта. Создает новый экземпляр класса <c>Account</c> и сохраняет его в базу при помощи <see cref="Database.SaveAccount(Account)"/>
        /// </summary>
        public void Registration()
        {
            //регистрация
        }
        /// <summary>
        /// Проверяет существует ли аккаунт в базе при помощи <see cref="Database.GetAccount(int)"/>
        /// </summary>
        public void Auth()
        {
            //авторизация
        }
        /// <summary>
        /// Восстанавливает аккаунт. 
        /// </summary>
        public void Recovery()
        {
            //восстановление
        }
    }
}
