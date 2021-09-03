using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace demo_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
            Console.ReadKey();
        }

        static void WriteFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("lophoc");
           
            XmlElement sinhvien = doc.CreateElement("sinhvien");
            sinhvien.SetAttribute("masv", "sv01");

            XmlElement hoten = doc.CreateElement("hoten");
            //nguyen van a is child of hoten
            XmlText tHoTen = doc.CreateTextNode("nguyen van a");
            hoten.AppendChild(tHoTen);

            XmlElement tuoi = doc.CreateElement("tuoi");
            tuoi.InnerText = "20";
           
            XmlElement gioitinh = doc.CreateElement("gioitinh");
            gioitinh.InnerText = "nam";
            XmlElement diachi = doc.CreateElement("diachi");
            diachi.InnerText = "haiduong";

            //create relationship
            doc.AppendChild(root);
            root.AppendChild(sinhvien);
            sinhvien.AppendChild(hoten);
            sinhvien.AppendChild(tuoi);
            sinhvien.AppendChild(gioitinh);
            sinhvien.AppendChild(diachi);

            //save
            doc.Save("lophoc.xml");
            doc.Save(Console.Out);
            Console.WriteLine("daxong");
            Console.ReadKey();
        }
        static void ReadFile_v1()
        {
            //đọc file
            XmlDocument doc = new XmlDocument();
            doc.Load("Cuahang.xml");
            Console.WriteLine("chuong trinh doc file xml");

            //đọc từ gốc
            XmlElement root = doc.DocumentElement;

            //lấy tên gốc
            XmlNodeList li = root.SelectNodes("sanpham");

            int i = 0;
            foreach (XmlNode item in li)
            {
                Console.WriteLine("phần tử thứ" + i + "=");
                //Console.WriteLine(item.SelectSingleNode("masp").InnerText);
                Console.WriteLine("ma sp:" + item.Attributes[0].InnerText);
                Console.WriteLine(item.SelectSingleNode("tensp").InnerText);
                Console.WriteLine(item.SelectSingleNode("soluong").InnerText);
                Console.WriteLine(item.SelectSingleNode("giatien").InnerText);
                i++;
            }
        }
        static void ReadFile_v2()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Cuahang.xml");
            //đọc từ gốc
            XmlElement root = doc.DocumentElement;
            PrintNode(root);
        }

        static void PrintNode(XmlNode node)
        {
            Console.WriteLine("name=[" + node.Name + "], type=[" + node.NodeType + "], value=[" + node.Value+"]");
            XmlNodeList li = node.ChildNodes;
            if (li.Count > 0)
            {
                Console.WriteLine("cac con cua node: " + node.Name + "la");
                foreach(XmlNode item in li)
                {
                    PrintNode(item);
                }
                Console.WriteLine("ket thuc cua node: " + node.Name);
            }
        }
    }
}
