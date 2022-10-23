using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dac_Ta_Hinh_Thuc
{
    class ThongTinVongLap
    {
        public string loaiVongLap;
        public string bienDem;
        public string batDau;
        public string ketThuc;

        public ThongTinVongLap(string loaiVongLap, string bienDem, string batDau, string ketThuc)
        {
            this.loaiVongLap = loaiVongLap;
            this.bienDem = bienDem;
            this.batDau = batDau;
            this.ketThuc = ketThuc;
        }
        public string Show(string text, int count)
        {
            string show = "";
            string check = "";
            switch(loaiVongLap)
            {
                case "VM":
                    show += Tab(count) + "bool check_" + bienDem + " = true;\n";
                    check = "true";
                    break;
                case "TT":
                    show += Tab(count) + "bool check_" + bienDem + " = false;\n";
                    check = "false";
                    break;
                default:
                    show += Tab(count) + "bool check_" + bienDem + " = none;\n";
                    check = "none";
                    break;
            }
            show += Tab(count) + "for(int " + bienDem + "="+ batDau + "; " + bienDem + "<=" + ketThuc + " && check_" + bienDem + "==" + check + "; " + bienDem + "++)\n";
            show += Tab(count) + "{\n";
            show += text;
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
