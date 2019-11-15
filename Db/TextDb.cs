using System;
using System.Collections.Generic;
using System.IO;

namespace mvc_sql
{
    public class TextDb : Db
    {
       List<TextDbObject> strings = new List<TextDbObject>();

        public TextDb()
            : base()
        {
            using (StreamReader r = File.OpenText("db.tdb"))
            {
                ReadFile(r);
                //TextDbObject dbo = TextDbObject[0];
            }
        }

        public void ReadFile(StreamReader r)
        {
            string line;

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
            TextDbObject textDbObject = strings.Find( (TextDbObject obj) => obj.id == id );

            if(textDbObject != null)
            {
                return textDbObject.ToString();
            }
            else
            {
                return "Object id doesn't exist";
            }
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

        public void WriteFile(string logMessage, TextWriter w)
        {
            w.Write("WriteTextString");
        }

        public override string Del()
        {
            return "DelTexDb";
        }
    }
}