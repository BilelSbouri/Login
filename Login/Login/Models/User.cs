using SQLite;
using System;



namespace Login.Model
{

   public class User
    {
        [PrimaryKey, Column("User_ID") ,AutoIncrement]
        public int ID { get; set; }

        public string Username { get; set; }
        
        public string Password { get; set; }

     



    }

}
