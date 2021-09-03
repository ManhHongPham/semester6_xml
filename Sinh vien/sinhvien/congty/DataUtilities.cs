using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace congty
{
    class DataUtilities
    {
        XmlDocument doc;
        XmlElement root;
        string fileName;

        public DataUtilities()
        {
            fileName = "Nhanvien.xml";
            doc = new XmlDocument();

            if (!File.Exists(fileName)){

                XmlElement nv = doc.CreateElement("thongtin");
                doc.AppendChild(nv);
                doc.Save(fileName);
            }

            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public List<nhanvien> getAllNhanvien()
        {
            XmlNodeList nodes = root.SelectNodes("nhanvien");
            List<nhanvien> li = new List<nhanvien>();
            
            foreach (XmlNode item in nodes)
            {
                nhanvien s = new nhanvien();
                s.id = item.Attributes[0].InnerText;
                s.name = item.SelectSingleNode("ten").InnerText;
                s.phone = item.SelectSingleNode("dienthoai").InnerText;
                s.salary = item.SelectSingleNode("luong").InnerText;
                s.address = item.SelectSingleNode("thanhpho/tenthanhpho").InnerText;
                s.street = item.SelectSingleNode("thanhpho/pho").InnerText;
                s.district = item.SelectSingleNode("thanhpho/quan").InnerText;
                s.year = item.SelectSingleNode("thamnien").InnerText;
                s.sex = item.SelectSingleNode("gioitinh").InnerText;
                s.position = item.SelectSingleNode("chucvu").InnerText;
                li.Add(s);
            }
            return li;
        }
        public void addNhanvien(nhanvien s)
        {
            XmlElement nv = doc.CreateElement("nhanvien");
            nv.SetAttribute("id", s.id);
            XmlElement name = doc.CreateElement("ten");
            name.InnerText = s.name;

            XmlElement address = doc.CreateElement("thanhpho");

            XmlElement ten = doc.CreateElement("tenthanhpho");
            ten.InnerText = s.address;
            
            XmlElement street = doc.CreateElement("pho");
            street.InnerText = s.street;
            XmlElement district = doc.CreateElement("quan");
            district.InnerText = s.district;

            XmlElement phone = doc.CreateElement("dienthoai");
            phone.InnerText = s.phone;
            
            XmlElement salary = doc.CreateElement("luong");
            salary.InnerText = s.salary;

            XmlElement year = doc.CreateElement("thamnien");
            year.InnerText = s.year;

            XmlElement sex = doc.CreateElement("gioitinh");
            sex.InnerText = s.sex;

            XmlElement position = doc.CreateElement("chucvu");
            position.InnerText = s.position;

            nv.AppendChild(name);
            nv.AppendChild(address);
            
            address.AppendChild(ten);
            address.AppendChild(street);
            address.AppendChild(district);

            nv.AppendChild(phone);
            nv.AppendChild(salary);
            nv.AppendChild(year);
            nv.AppendChild(position);
            nv.AppendChild(sex);

            root.AppendChild(nv);
            doc.Save(fileName);

        }
        public List<nhanvien> FindByCity(string city)
        {
            XmlNodeList students = root.SelectNodes("nhanvien[thanhpho/pho= '" + city + "']");
            List<nhanvien> li = new List<nhanvien>();
            foreach (XmlNode item in students)
            {
                nhanvien s = new nhanvien();
                s.id = item.Attributes[0].InnerText;
                s.name = item.SelectSingleNode("ten").InnerText;
                s.phone = item.SelectSingleNode("dienthoai").InnerText;
                s.salary = item.SelectSingleNode("luong").InnerText;
                s.address = item.SelectSingleNode("thanhpho/tenthanhpho").InnerText;
                s.street = item.SelectSingleNode("thanhpho/pho").InnerText;
                s.district = item.SelectSingleNode("thanhpho/quan").InnerText;
                s.year = item.SelectSingleNode("thamnien").InnerText;
                s.position = item.SelectSingleNode("chucvu").InnerText;
                s.sex = item.SelectSingleNode("gioitinh").InnerText;
                li.Add(s);
            }
            return li;
        }

    }
}
