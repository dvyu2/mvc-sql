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

        public static TextDb createClass()
        {
            return new TextDb();
        }

        public static void ReadFile(StreamReader r)
        {
            //string line;
            //while ((line = r.ReadLine()) != null)
            string[] line;
            //public List<TextDbObject> Strings = new List<TextDbObject> { new TextDbObject(1,"2","3","4","5") };
            //public List<TextDbObject> Strings = new List<TextDbObject> { new TextDbObject() };
            //public List<TextDbObject> strings = new List<TextDbObject>();

            while ((line = r.ReadLine().Split(',')) != null)
            {
                //Console.WriteLine(line);
                //Console.WriteLine(line[0]);
                int id;
                try
                {
                    id = Int32.Parse(line[0]);
                    //strings.Add(new TextDbObject(line[0], line[1], line[2], line[3], line[4]));
                }
                catch
                {
                    Console.WriteLine("Number Only Permitted! - '" + line[0] + "' received");
                }
                finally
                {
                    //Console.WriteLine("TryFinal!");
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