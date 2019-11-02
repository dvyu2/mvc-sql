using System;
using System.IO;

namespace mvc_sql
{
    public class TextDb : Db
    {
        public TextDb()
            : base()
        {
            using (StreamReader r = File.OpenText("db.tdb"))
            {
                ReadFile(r);
                //DbRecords.Add();
                //AuthorList.Add("Mahesh Chand");
            }
        }


        public static void ReadFile(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public override string Get()
        {

            return "GetTexDb";
        }

        public override string Set()
        {
            using (StreamWriter w = File.AppendText("db.tdb"))
            {
                WriteFile("Test1", w);
                WriteFile("Test2", w);
            }
            return "SetTexDb";
        }

        public static void WriteFile(string logMessage, TextWriter w)
        {
            w.Write("WriteTextString");
        }

        public override string Del()
        {
            return "DelTexDb";
        }
    }
}