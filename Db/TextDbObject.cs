﻿using System;

namespace mvc_sql
{
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
            return "Get: Id: '" + id +
            "', Name: '" + name +
            "', Group: '" + group +
            "', Faculty: '" + faculty +
            "', University: '" + university +
            "'";
        }
    }
}
