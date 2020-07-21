using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login.DBcnx.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
