using System;

namespace mvc_sql
{
    /*public class TextDbObject
    {
        public int id;
        public string name;
        public string group;
        public string faculty;
        public string university;

        public void Account(int id, string name, string group, string faculty, string university)
        {
            this.name = name;
            this.name = name;
            this.group = group;
            this.faculty = faculty;
            this.university = university;
        }
    }*/

    public class TextDbObject
    {
        public int id { get; set; }

        public string name { get; set; }

        public string group { get; set; }

        public string faculty { get; set; }

        public string university { get; set; }

        public TextDbObject(int id, string name, string group, string faculty, string university)
        {
            this.id = id;
            this.name = name;
            this.group = group;
            this.faculty = faculty;
            this.university = university;
        }

        public override string ToString()
        {
            return "id = "+ id+" name: "+ name;
        }
    }
}
