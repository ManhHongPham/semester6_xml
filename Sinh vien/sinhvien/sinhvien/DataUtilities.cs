using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace sinhvien
{
    class DataUtilities
    {
        XmlDocument doc;
        XmlElement root;
        string filename;

        public DataUtilities()
        {
            filename = "Course.xml";
            doc = new XmlDocument();

            if (!File.Exists(filename))
            {
                XmlElement course = doc.CreateElement("course");
                doc.AppendChild(course);
                doc.Save(filename);
            }

            doc.Load(filename);
            root = doc.DocumentElement;
        }

        public List<Student> GetAllStudent()
        {
            XmlNodeList nodes = root.SelectNodes("student");
            List<Student> li = new List<Student>();
            foreach (XmlNode item in nodes)
            {
                Student s = new Student();
                s.Id = item.Attributes[0].InnerText;
                s.Name = item.SelectSingleNode("name").InnerText;
                s.Age = item.SelectSingleNode("age").InnerText;
                s.City = item.SelectSingleNode("city").InnerText;
                li.Add(s);
            }
            return li;
        }

        public void AddStudent(Student s)
        {
            XmlElement st = doc.CreateElement("student");
            st.SetAttribute("id", s.Id);
            XmlElement name = doc.CreateElement("name");
            name.InnerText = s.Name;
            XmlElement age = doc.CreateElement("age");
            age.InnerText = s.Age;
            XmlElement city = doc.CreateElement("city");
            city.InnerText = s.City;

            st.AppendChild(name);
            st.AppendChild(age);
            st.AppendChild(city);

            root.AppendChild(st);
            doc.Save(filename);
        }

        public bool UpdateStudent(Student s)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='" + s.Id + "']");
            if (stfind != null)
            {
                XmlElement st = doc.CreateElement("student");
                st.SetAttribute("id", s.Id);
                XmlElement name = doc.CreateElement("name");
                name.InnerText = s.Name;
                XmlElement age = doc.CreateElement("age");
                age.InnerText = s.Age;
                XmlElement city = doc.CreateElement("city");
                city.InnerText = s.City;

                st.AppendChild(name);
                st.AppendChild(age);
                st.AppendChild(city);

                root.ReplaceChild(st, stfind);
                doc.Save(filename);

                return true;
            }

            return false;
        }

        public bool DeleteStudent(string id)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='" + id + "']");
            if (stfind != null)
            {
                root.RemoveChild(stfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }

        public Student FindByID(string id)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='" + id + "']");
            Student s = null;
            if (stfind != null)
            {
                s = new Student();
                s.Id = stfind.Attributes[0].InnerText;
                s.Name = stfind.SelectSingleNode("name").InnerText;
                s.Age = stfind.SelectSingleNode("age").InnerText;
                s.City = stfind.SelectSingleNode("city").InnerText;
            }
            return s;
        }

        public List<Student> FindByCity(string city)
        {
            XmlNodeList students = root.SelectNodes("student[city= '" + city + "']");
            List<Student> li = new List<Student>();
            foreach (XmlNode item in students)
            {
                Student s = new Student();
                s.Id = item.Attributes[0].InnerText;
                s.Name = item.SelectSingleNode("name").InnerText;
                s.Age = item.SelectSingleNode("age").InnerText;
                s.City = item.SelectSingleNode("city").InnerText;
                li.Add(s);
            }
            return li;
        }
    }
}
