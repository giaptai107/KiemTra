using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtra.DAL.Entity
{
    class Nhom
    {
        public Nhom(string tenNhom)
        {
            TenNhom = tenNhom;

        }
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public static List<Nhom> getfromfile()
        {
            string path = Application.StartupPath + @"/data/nhom.txt";
            List<Nhom> list = new List<Nhom>();
            string[] lines = File.ReadAllLines(path);
            foreach(var temp in lines)
            {
                var nhom = new Nhom(temp);
                list.Add(nhom);
            }
            return list;
        }
        //return null;
    }
}
