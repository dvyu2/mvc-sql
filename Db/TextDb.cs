using System;
using System.Collections.Generic;
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
                //TextDbObject dbo = TextDbObject[0];
            }
        }

        public static void ReadFile(StreamReader r)
        {
            string line;
            List<TextDbObject> strings = new List<TextDbObject>();

            while ((line = r.ReadLine()) != null)
            {
                string[] splitline;
                splitline = line.Split(',');
                //Console.WriteLine(splitline[0]);

                try
                {
                    int id = Int32.Parse(splitline[0]);
                    strings.Add(new TextDbObject(id, splitline[1], splitline[2], splitline[3], splitline[4]));
                }
                catch
                {
                    Console.WriteLine("warn: ReadFile(StreamReader) - Numbers Only Permitted! - '" + line[0] + "' received");
                }
            }
    }

        public override string Get(int id)
        {

            return "GetTexDb: '" + id.ToString() + "'";
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