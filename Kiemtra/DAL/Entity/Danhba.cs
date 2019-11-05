using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtra.DAL.Entity
{
    class Danhba
    {
        public string TenNhom { get; set; }
        public string TenGoi { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        

        public static List<Danhba> getDanhBaTheoNhom()
        {
            string path = Application.StartupPath + @"/DATA/danhba.txt";
            List<Danhba> list = new List<Danhba>();
            string[] lines = File.ReadAllLines(path);
            foreach(var i in lines)
            {
                var values = i.Split(new char[] { '#' });
                var db = new Danhba(
                    TenNhom=values[0],
                    TenGoi = values[1],
                    Email = values[2],
                    Sdt = values[3],
                    DiaChi = values[4]
                    );
                list.Add(db);
            }
            return list;
        }
    }
}
