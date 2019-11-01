using System;

//namespace mvc_sql.Interfaces
namespace mvc_sql
{
    interface IDb
    {
        string Get();
        string Set();
        string Del();
    }
}