using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireDB
{
    /// <summary>
    /// Класс <c>Database</c> - работа с базой данных
    /// </summary>
    public class Database
    {
        /// <summary>
        /// <value>Строка подключения к базе данных</value>
        /// </summary>
        public string conString = "";
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Database() { }

        /// <summary>
        /// Получает из базы запись с данными аккаунта
        /// </summary>
        /// <param name="id"> ID аккаунта, который необходимо получить</param>
        /// <returns> Возвращает экземпляр класса <see cref="Account"/> (пустой, если аккаунт не найден)</returns>
        public Account GetAccount(int id) //получить запись с данными аккаунта
        {
            return new Account();
        }

        /// <summary>
        /// Сохраняет аккаунт в базу
        /// </summary>
        /// <param name="account">Экземпляр класса <see cref="Account"/>, который необходимо сохранить</param>
        public void SaveAccount(Account account)
        {
            //сохранить аккаунт
        }
    }
}
