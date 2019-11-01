using System;
using System.IO;

namespace mvc_sql
{
    public class TextDb : Db
    {
        public TextDb()
            : base()
        {
            using (StreamReader r = File.OpenText("log.txt"))
            {
                DumpLog(r);
            }
        }


        public static void DumpLog(StreamReader r)
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
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Log("Test1", w);
                Log("Test2", w);
            }
            return "SetTexDb";
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        public override string Del()
        {
            return "DelTexDb";
        }
    }
}