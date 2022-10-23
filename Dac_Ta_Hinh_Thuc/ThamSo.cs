using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dac_Ta_Hinh_Thuc
{
    class ThamSo
    {
        public string name;
        public string dataType;
        public string default_value;

        public ThamSo() { }
        public ThamSo(string name, string dataType)
        {
            this.name = name;
            this.dataType = dataType;

            switch(dataType)
            {
                case "float":
                    this.default_value = "0";
                    break;
                case "int":
                    this.default_value = "0";
                    break;
                case "bool":
                    this.default_value = "false";
                    break;
                case "string":
                    this.default_value = "\"\"";
                    break;
                default:
                    this.default_value = "none";
                    break;
            }
        }

        public virtual string InputString(int count)
        {
            return Tab(count) + "Console.WriteLine(" + "\"" + "Nhap " + name + ": \");\n"
                 + Tab(count) + name + " = " + dataType + ".Parse(Console.ReadLine());\n";
        }
        public string OutputString(int count)
        {
            return Tab(count) + "Console.WriteLine(" + "\"" + "Ket qua la: {0} " + "\", " + name + ");\n";
        }
        public virtual string DeclareString(int count)
        {
            return Tab(count) + this.dataType + " " + this.name + " = " + this.default_value + ";\n";
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
