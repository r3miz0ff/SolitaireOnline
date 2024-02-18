using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireDB
{
    public class Database
    {
        string conString = "";
        public Database() { }

        Account GetAccount(int id) //получить запись с данными аккаунта
        {
            return new Account();
        }

        void SaveAccount(Account account)
        {
            //сохранить аккаунт
        }
    }
}
