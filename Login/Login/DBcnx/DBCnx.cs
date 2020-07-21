
using Login.Model;
using SQLite;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CRMapp.Data
{
    public class DBCnx
    {
        
       readonly SQLiteAsyncConnection _database;

        public DBCnx(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>();
           
        }

        //User Database Methodes
        #region
        public Task<List<User>> GetUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
           
           return _database.InsertAsync(user);
            
        }

    
        public bool GetUserByNameAsync(string username ,string pwd)
        {
            var sql = "SELECT * FROM User WHERE Username  ='" + username + "' AND Password ='" + pwd + "'";
            var res =_database.ExecuteAsync(sql);
            int test = res.Result;
            if(test.Equals(0))
            {
                return false;

            }
            else
            {
                return true;
            }
          

           
          
        }

        /*
        public bool Checkinformation(string username, string pwd)
        {
            var sql = "SELECT * FROM User WHERE Username  ='" + username + "' AND Password '" + pwd + "'";

            _database.ExecuteAsync(sql);
          Lis
        }
        */
        #endregion
    }

}

