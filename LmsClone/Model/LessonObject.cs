using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace LmsClone.Model
{
    public class LessonObject
    {
        private string idclass;
        private string id;
        private string name;
        private string description;
        private string detail;

        public string Idclass { get => idclass; set => idclass = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Detail { get => detail; set => detail = value; }

    }
}