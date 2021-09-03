using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace use_winform
{
    class StudentService
    {
        XmlDocument doc;
        XmlElement root;
        string filename;

        //nap document
        public StudentService()
        {
            filename = "thongtin.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement inf = doc.CreateElement("information");
                doc.AppendChild(inf);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        } 
        public List<Student> getAllStudent()
        {
            XmlNodeList node = root.SelectNodes("student");
            List<Student> li = new List<Student>();
            foreach (XmlNode item in node)
            {
                Student s = new Student();
                s.sid = item.Attributes[0].InnerText;
                s.name = item.SelectSingleNode("name").InnerText;
                s.address = item.SelectSingleNode("address").InnerText;
                s.age = item.SelectSingleNode("address").InnerText;
                li.Add(s);
            }
            return li;
        }
    }
}
