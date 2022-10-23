using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dac_Ta_Hinh_Thuc
{
    class Post_Type1
    {
        public string ketQua;
        public List<string> dieuKien;

        public Post_Type1(string ketQua, List<string> dieuKien)
        {
            this.ketQua = ketQua;
            List<string> newDieuKien = new List<string>();
            foreach(string dk in dieuKien)
            {
                string temp;
                if (!dk.Contains("<") && !dk.Contains(">") && !dk.Contains("!"))
                {
                    temp = dk.Replace("=","==");
                    newDieuKien.Add(temp);
                }
                else
                    newDieuKien.Add(dk);
            }
            this.dieuKien = newDieuKien;
        }

        public string Show(int count)
        {
            string show = "";
            show += Tab(count) + "if(";
            foreach(string dk in dieuKien)
            {
                show += dk + " && ";
            }
            show = show.Remove(show.Length - 4);
            show += ")\n";
            show += Tab(count) + "{\n";
            show += Tab(count + 1) + ketQua + ";\n";
            show += Tab(count) + "}\n";
            return show;
        }
        private string Tab(int count)
        {
            string t = "";
            for (int i = 0; i < count; i++)
                t += "\t";
            return t;
        }
    }
}
