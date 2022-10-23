using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dac_Ta_Hinh_Thuc
{
    class Post_Type2
    {
        public List<ThongTinVongLap> danhSachVongLap;
        string phepToan;

        public Post_Type2(List<ThongTinVongLap> danhSachVongLap, string phepToan)
        {
            this.danhSachVongLap = new List<ThongTinVongLap>();
            this.danhSachVongLap = danhSachVongLap;
            this.phepToan = phepToan;
        }

        public string Show(int count)
        {
            string show = "";
            int dem = count;
            string check = "";
            foreach (ThongTinVongLap thongTin in danhSachVongLap)
            {
                check += Tab(count + danhSachVongLap.Count) + "check_" + thongTin.bienDem + " = (" + phepToan + ");\n";
            }

            //show += danhSachVongLap[danhSachVongLap.Count - 1].Show(check, count + 1);
            //if (danhSachVongLap.Count >= 2)
            //{
            for (int i = danhSachVongLap.Count - 1; i >= 0; i--)
            {
                int length = show.Length;
                if (i == danhSachVongLap.Count - 1)
                {
                    show += danhSachVongLap[i].Show(check, count + i);
                }
                else
                {
                    show += danhSachVongLap[i].Show(show, count + i);     
                }
                show = show.Remove(0, length);
            }
            //}

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
