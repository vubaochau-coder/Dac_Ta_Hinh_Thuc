using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dac_Ta_Hinh_Thuc
{
    class ThamSo_Array : ThamSo
    {
        //public string name;
        //public string dataType;
        public ThamSo arrLength;

        public ThamSo_Array() { }
        public ThamSo_Array(string name, string dataType, ThamSo length)
        {
            this.name = name;
            this.arrLength = length;

            switch(dataType)
            {
                case "R":
                    this.dataType = "float";
                    break;
                case "N":
                    this.dataType = "int";
                    break;
                case "Z":
                    this.dataType = "float";
                    break;
                default:
                    this.dataType = "none_arrType";
                    break;
            }
        }

        //public string InputThamSo(int count)
        //{
        //    string tab = Tab(count);
        //    string nhapArr = "";

        //    string temp0 = arrLength.InputThamSo(count);
        //    string temp1 = Tab(count) + name + " = new " + dataType + "[" + arrLength.name + " + 1];\n";
        //    temp1 += Tab(count) + name + "[0]" + " = 0;\n";
        //    string temp2 = "Console.WriteLine(" + "\"" + "Nhap mang " + name + ": \");\n";
        //    string temp3 = "for(int i = 1; i <= " + arrLength.name + "; i++)\n";
        //    string temp31 = name + "[i] = " + dataType + ".Parse(Console.ReadLine());\n";

        //    nhapArr += temp0 + temp1 + tab +  temp2 + tab + temp3 + Tab(count + 1) + temp31;
        //    return nhapArr;
        //}

        //public string KhaiBaoThamSo(int count)
        //{
        //    string khaiBaoArr = "";
        //    string temp0 = dataType + "[] " + name + " = new " + dataType + "[" + arrLength.name + "];\n";
        //    khaiBaoArr += Tab(count) + temp0;
        //    return khaiBaoArr;
        //}

        public override string InputString(int count)
        {
            string tab = Tab(count);
            string nhapArr = "";

            string temp0 = arrLength.InputString(count);
            string temp1 = Tab(count) + name + " = new " + dataType + "[" + arrLength.name + " + 1];\n";
            temp1 += Tab(count) + name + "[0]" + " = 0;\n";
            string temp2 = "Console.WriteLine(" + "\"" + "Nhap mang " + name + ": \");\n";
            string temp3 = "for(int i = 1; i <= " + arrLength.name + "; i++)\n";
            string temp31 = name + "[i] = " + dataType + ".Parse(Console.ReadLine());\n";

            nhapArr += temp0 + temp1 + tab + temp2 + tab + temp3 + Tab(count + 1) + temp31;
            return nhapArr;
        }
        public override string DeclareString(int count)
        {
            string khaiBaoArr = "";
            string temp0 = dataType + "[] " + name + " = new " + dataType + "[" + arrLength.name + "];\n";
            khaiBaoArr += Tab(count) + temp0;
            return khaiBaoArr;
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
