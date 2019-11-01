using System;
//namespace mvc_sql.Db
namespace mvc_sql
{
    public class TextDb : Db
    {
        public TextDb()
            : base()
        {
        }

        public override string Get()
        {
            return "GetTexDb";
        }

        public override string Set()
        {
            return "SetTexDb";
        }

        public override string Del()
        {
            return "DelTexDb";
        }
    }
}