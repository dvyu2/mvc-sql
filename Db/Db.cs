using System;

namespace mvc_sql
{
    public class Db : IDb
    {
        //public Db()
        //{
        //}

        public virtual string Get(int id)
        {
            return "GetDb";
        }

        public virtual string Set()
        {
            return "SetDb";
        }

        public virtual string Del()
        {
            return "DelDb";
        }
    }
}