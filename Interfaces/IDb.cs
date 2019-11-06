using System;

namespace mvc_sql
{
    interface IDb
    {
        string Get(int id);
        string Set();
        string Del();
    }
}