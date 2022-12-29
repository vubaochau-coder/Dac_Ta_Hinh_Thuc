using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dac_Ta_Hinh_Thuc
{
    class XuLy
    {
        private string inputStr;
        private string firstStr;
        public string preStr;
        private string postStr;

        public string nameFunc;

        private bool laBaiToanDieuKien = false;
        public bool laType2;

        const string PRE = "pre";
        const string POST = "post";

        private List<ThamSo> listInput = new List<ThamSo>();
        private ThamSo resuilt;
        private List<Post_Type1> listPost = new List<Post_Type1>();
        private ThamSo_Array thamSo_Array;
        private Post_Type2 post_Type2;

        public XuLy(string _inputStr)
        {
            _inputStr = _inputStr.Replace(" ", "");
            _inputStr = _inputStr.Replace("\n", "");
            _inputStr = _inputStr.Replace("\t", "");
            this.inputStr = _inputStr;

            if (_inputStr.Contains("{"))
            {
                laType2 = true;
            }
            else
                laType2 = false;
            TachChuoi();
        }
        public void TachChuoi()
        {
            int indexPre, indexPost;
            indexPre = inputStr.IndexOf(PRE);
            indexPost = inputStr.IndexOf(POST);

            firstStr = inputStr.Substring(0, indexPre);
            postStr = inputStr.Substring(indexPost);
            preStr = inputStr.Substring(indexPre, indexPost - indexPre);

            XuLyFirstStr();
            XuLyPreStr();
            XuLyPostStr();
        }

        //Nhom function xu ly
        public void XuLyFirstStr()
        {
            int index = firstStr.IndexOf("(");
            nameFunc = firstStr.Substring(0, index);
            
            string danhSachBienDauVao = firstStr.Substring(index);

            string bienKetQua = danhSachBienDauVao.Substring(danhSachBienDauVao.IndexOf(")") + 1);
            string danhSachBienDauVao_boNgoac = danhSachBienDauVao.Substring(1, danhSachBienDauVao.IndexOf(")") - 1);

            switch (bienKetQua.Substring(bienKetQua.IndexOf(":") + 1))
            {
                case "R":
                    resuilt = new ThamSo(bienKetQua.Substring(0, bienKetQua.IndexOf(":")), "float");
                    break;
                case "N":
                    resuilt = new ThamSo(bienKetQua.Substring(0, bienKetQua.IndexOf(":")), "int");
                    break;
                case "B":
                    resuilt = new ThamSo(bienKetQua.Substring(0, bienKetQua.IndexOf(":")), "bool");
                    break;
                case "Z":
                    resuilt = new ThamSo(bienKetQua.Substring(0, bienKetQua.IndexOf(":")), "float");
                    break;
                case "char*":
                    resuilt = new ThamSo(bienKetQua.Substring(0, bienKetQua.IndexOf(":")), "string");
                    break;
                default:
                    resuilt = new ThamSo(bienKetQua.Substring(0, bienKetQua.IndexOf(":")), bienKetQua.Substring(bienKetQua.IndexOf(":") + 1));
                    break;
            }

            string[] arr = danhSachBienDauVao_boNgoac.Split(',');

            if (laType2 && arr.Length == 2)
            {
                string arrName = "";
                string arrLength = "";
                string arrType = "";
                ThamSo a;

                switch(arr[0].Contains("*"))
                {
                    case true:
                        arrName += arr[0].Substring(0, arr[0].IndexOf(":"));
                        arrType += arr[0].Substring(arr[0].IndexOf(":") + 1);
                        arrType = arrType.Replace("*", "");

                        arrLength += arr[1].Substring(0, arr[1].IndexOf(":"));
                        a = new ThamSo(arrLength, "int");
                        thamSo_Array = new ThamSo_Array(arrName, arrType, a);
                        break;
                    case false:
                        arrName += arr[1].Substring(0, arr[1].IndexOf(":"));
                        arrType += arr[1].Substring(arr[1].IndexOf(":") + 1);
                        arrType = arrType.Replace("*", "");

                        arrLength += arr[0].Substring(0, arr[0].IndexOf(":"));
                        a = new ThamSo(arrLength, "int");
                        thamSo_Array = new ThamSo_Array(arrName, arrType, a);
                        break;
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    string tenBien = arr[i].Substring(0, arr[i].IndexOf(":"));
                    string kieuDuLieu = arr[i].Substring(arr[i].IndexOf(":") + 1);

                    ThamSo a;
                    switch (kieuDuLieu)
                    {
                        case "R":
                            a = new ThamSo(tenBien, "float");
                            listInput.Add(a);
                            break;
                        case "N":
                            a = new ThamSo(tenBien, "int");
                            listInput.Add(a);
                            break;
                        case "B":
                            a = new ThamSo(tenBien, "bool");
                            listInput.Add(a);
                            break;
                        case "Z":
                            a = new ThamSo(tenBien, "float");
                            listInput.Add(a);
                            break;
                        case "char*":
                            a = new ThamSo(tenBien, "string");
                            listInput.Add(a);
                            break;
                        default:
                            a = new ThamSo("error", "error");
                            listInput.Add(a);
                            break;
                    }
                }
            }
        }
        public void XuLyPreStr()
        {
            if (preStr.Length > 3)
            {
                preStr = preStr.Remove(0, 3);
                ChuanHoaChuoi(ref preStr);
            }
            else
            {
                preStr = preStr = "\0";
            }
        }
        public void XuLyPostStr()
        {
            postStr = postStr.Remove(0, 4);
            postStr = postStr.Replace("&&", "&");
            postStr = postStr.Replace("FALSE", "false");
            postStr = postStr.Replace("TRUE", "true");

            if (laType2 == true)
            {
                XuLy_Type2();
            }
            else
            {
                if (postStr.Contains("&"))
                {
                    laBaiToanDieuKien = true;

                    postStr = postStr.Replace("||", "|");

                    string[] _tempArrPost = postStr.Split('|');

                    foreach (string i in _tempArrPost)
                    {
                        string ii = i.Replace("(", "");
                        while (ii.Contains("("))
                            ii = ii.Replace("(", "");

                        ii = ii.Replace(")", "");
                        while (ii.Contains(")"))
                            ii = ii.Replace(")", "");

                        string[] tempArr2 = ii.Split('&');
                        List<string> _listPara = new List<string>();
                        string mainPara = "";

                        for (int j = 0; j < tempArr2.Length; j++)
                        {
                            if (tempArr2[j].Contains(resuilt.name))
                            {
                                mainPara = tempArr2[j];
                            }
                            else
                            {
                                _listPara.Add(tempArr2[j]);
                            }
                        }

                        Post_Type1 doiTuongPost = new Post_Type1(mainPara, _listPara);
                        listPost.Add(doiTuongPost);
                    }
                }
                else
                {
                    laBaiToanDieuKien = false;

                    postStr = postStr.Replace("(", "");
                    postStr = postStr.Replace(")", "");

                    Post_Type1 doiTuongPost = new Post_Type1(postStr, new List<string>());
                    listPost.Add(doiTuongPost);
                }
            }
        }

        //Nhom function String_Output
        public string HamKiemTra(int count)
        {
            string xuat = Tab(count) + "static bool KiemTra_" + nameFunc + "(";
            if (preStr != "\0")
            {
                if(laType2)
                {
                    xuat += thamSo_Array.dataType + "[] " + thamSo_Array.name + ", ";
                    xuat += "int " + thamSo_Array.arrLength.name;
                    xuat += ")\n" +
                        Tab(count) + "{\n";
                        //+ Tab(count + 1) + "return true;\n" +
                        //Tab(count) + "}\n";
                }
                else
                {
                    foreach (ThamSo i in listInput)
                    {
                        xuat += i.dataType + " " + i.name + ", ";
                    }
                    xuat = xuat.Remove(xuat.Length - 2);
                    xuat += ")\n" +
                        Tab(count) + "{\n";
                        
                }
                xuat += Tab(count + 1) + "if(" + preStr + ")\n" +
                        Tab(count + 2) + "return true;\n " +
                        Tab(count + 1) + "else\n" +
                        Tab(count + 2) + "return false;\n" +
                        Tab(count) + "}\n";
            }
            else
            {
                if (laType2 == true)
                {
                    xuat += thamSo_Array.dataType + "[] " + thamSo_Array.name + ", ";
                    xuat += "int " + thamSo_Array.arrLength.name;

                    xuat += ")\n" +
                        Tab(count) + "{\n" +
                        Tab(count + 1) + "return true;\n" +
                        Tab(count) + "}\n";
                }
                else
                {
                    foreach (ThamSo i in listInput)
                    {
                        xuat += i.dataType + " " + i.name + ", ";
                    }
                    xuat = xuat.Remove(xuat.Length - 2);
                    xuat += ")\n" +
                        Tab(count) + "{\n" +
                        Tab(count + 1) + "return true;\n" +
                        Tab(count) + "}\n";
                }
            }
            return xuat;
        }
        public string HamNhap(int count)
        {
            string nhap = Tab(count) + "static void Nhap_" + nameFunc + "(";
            if (laType2)
            {
                nhap += "ref " + thamSo_Array.dataType + "[] " + thamSo_Array.name + ", ";
                nhap += "ref int " + thamSo_Array.arrLength.name;

                nhap += ")\n" +
                    Tab(count) + "{\n";

                nhap += thamSo_Array.InputString(count + 1);

                nhap += Tab(count) + "}\n";
            }
            else
            {
                foreach (ThamSo i in listInput)
                {
                    nhap += "ref " + i.dataType + " " + i.name + ", ";
                }
                nhap = nhap.Remove(nhap.Length - 2);
                nhap += ")\n" +
                    Tab(count) + "{\n";
                foreach (ThamSo i in listInput)
                {
                    nhap += i.InputString(count + 1);
                }
                nhap += Tab(count) + "}\n";
            }
            return nhap;
        }
        public string HamXuLy(int count)
        {
            string xuly = Tab(count) + "static void " + nameFunc + "(";

            if (laType2 == true)
            {
                xuly += thamSo_Array.dataType + "[] " + thamSo_Array.name + ", ";
                xuly += "int " + thamSo_Array.arrLength.name + ", ";
                xuly += "ref " + resuilt.dataType + " " + resuilt.name + ")\n";

                xuly += Tab(count) + "{\n";
                xuly += post_Type2.Show(count + 1);
                xuly += Tab(count + 1) + resuilt.name + " = " + "check_" + post_Type2.danhSachVongLap[0].bienDem + ";\n";
            }
            else
            {
                foreach (ThamSo i in listInput)
                {
                    xuly += i.dataType + " " + i.name + ", ";
                }
                xuly += "ref " + resuilt.dataType + " " + resuilt.name + ")\n" +
                    Tab(count) + "{\n";

                if (laBaiToanDieuKien)
                {
                    foreach (Post_Type1 i in listPost)
                    {
                        //xuly += Tab(count + 1) + "if(";
                        //foreach (string j in i.dieuKien)
                        //{
                        //    xuly += j + " && ";
                        //}
                        //xuly = xuly.Remove(xuly.Length - 4);
                        //xuly += ")\n" +
                        //    Tab(count + 1) + "{\n";
                        //xuly += Tab(count + 2) + i.ketQua + ";\n" +
                        //    Tab(count + 1) + "}\n";
                        xuly += i.Show(count + 1);
                    }
                }
                else
                {
                    foreach (Post_Type1 i in listPost)
                    {
                        string convert = "(" + resuilt.dataType + ")";
                        string[] v = i.ketQua.Split('=');
                        xuly += Tab(count + 1) + v[0] + "=" + convert + v[1] + ";\n";
                    }
                }
            }
            xuly += Tab(count) + "}\n";
            return xuly;
        }
        public string HamXuat(int count)
        {
            string t = "";
            for (int i = 0; i < count; i++)
                t += "\t";

            string xuat = t + "static void Xuat_" + nameFunc + "(" + resuilt.dataType + " " + resuilt.name + ")\n" +
                t + "{\n";
            xuat += resuilt.OutputString(count + 1) + t + "}\n";
            return xuat;
        }
        public string HamMain(int count)
        {
            string main = Tab(count) + "static void Main(string[] args)\n" +
                Tab(count) + "{\n";

            main += resuilt.DeclareString(3);

            if (laType2 == true)
            {
                main += thamSo_Array.arrLength.DeclareString(count + 1);
                main += thamSo_Array.DeclareString(count + 1);

                main += Tab(count + 1) + "Nhap_" + nameFunc + "(";
                main += "ref " + thamSo_Array.name + ", ref " + thamSo_Array.arrLength.name;
                main += ");\n";

                main += Tab(count + 1) + "if(KiemTra_" + nameFunc + "(";
                main += thamSo_Array.name + ", " + thamSo_Array.arrLength.name;
                main += "))\n" +
                    Tab(count + 1) + "{\n" +
                    Tab(count + 2) + nameFunc + "(";
                main += thamSo_Array.name + ", " + thamSo_Array.arrLength.name;
                main += ", ref " + resuilt.name + ");\n";

                main += Tab(count + 2) + "Xuat_" + nameFunc + "(" + resuilt.name + ");\n";
                main += Tab(count + 1) + "}\n" +
                    Tab(count + 1) + "else\n" +
                    Tab(count + 1) + "{\n" +
                    Tab(count + 2) + "Console.WriteLine(\"Error!\");\n" +  
                    Tab(count + 1) + "}\n" +
                    Tab(count + 1) + "Console.ReadLine();\n" +
                    Tab(count) + "}\n";
            }
            else
            {
                foreach (ThamSo thamSo in listInput)
                {
                    main += thamSo.DeclareString(3);
                }

                main += Tab(count + 1) + "Nhap_" + nameFunc + "(";
                foreach (ThamSo thamSo in listInput)
                {
                    main += "ref " + thamSo.name + ", ";
                }
                main = main.Remove(main.Length - 2);
                main += ");\n";
                main += Tab(count + 1) + "if(KiemTra_" + nameFunc + "(";
                foreach (ThamSo thamSo in listInput)
                {
                    main += thamSo.name + ", ";
                }
                main = main.Remove(main.Length - 2);
                main += "))\n" +
                    Tab(count + 1) + "{\n" +
                    Tab(count + 2) + nameFunc + "(";
                foreach (ThamSo thamSo in listInput)
                {
                    main += thamSo.name + ", ";
                }
                main += "ref " + resuilt.name + ");\n";
                main += Tab(count + 2) + "Xuat_" + nameFunc + "(" + resuilt.name + ");\n";
                main += Tab(count + 1) + "}\n" +
                    Tab(count + 1) + "else\n" +
                    Tab(count + 1) + "{\n" +
                    Tab(count + 2) + "Console.WriteLine(\"Error!\");\n" +
                    Tab(count + 1) + "}\n" +
                    Tab(count + 1) + "Console.ReadLine();\n" +
                    Tab(count) + "}\n";
            }
            return main;
        }

        //Nhom function xu ly chuoi
        private bool KiemTraNgoacDau_Cuoi(string t)
        {
            int strLength = t.Length;
            char[] arr = t.ToCharArray();

            if (arr[0] == '(')
            {
                int count = 1;
                for (int dem = 1; dem < strLength; dem++)
                {
                    if (arr[dem] == '(')
                        count++;
                    if (arr[dem] == ')')
                        count--;
                    if (count == 0)
                    {
                        if (dem == strLength - 1)
                            return true;
                        else
                            return false;
                    }
                }
                return false;
            }
            else
                return false;
        }
        private void ChuanHoaChuoi(ref string t)
        {
            while (KiemTraNgoacDau_Cuoi(t))
            {
                t = t.Remove(0, 1);
                t = t.Remove(t.Length - 1);
            }
        }
        private string Tab(int count)
        {
            string t = "";
            for (int i = 0; i < count; i++)
                t += "\t";
            return t;
        }
        //Type 2
        private void XuLy_Type2()
        {
            postStr = postStr.Remove(0, postStr.IndexOf(resuilt.name) + resuilt.name.Length + 1);
            ChuanHoaChuoi(ref postStr);

            postStr = postStr.Replace("..", "|");

            string[] testStrArr = postStr.Split('.');
            List<ThongTinVongLap> thongTinVongLaps = new List<ThongTinVongLap>();

            for (int i = 0; i < testStrArr.Length - 1; i++)
            {
                string loai = testStrArr[i].Substring(0, 2);
                string bienDem = testStrArr[i].Substring(2, 1);
                string phamVi = testStrArr[i].Substring(testStrArr[i].IndexOf("{"));
                phamVi = phamVi.Replace("{", "");
                phamVi = phamVi.Replace("}", "");

                string[] a = phamVi.Split('|');
                string start = a[0];
                string end = a[1];
                ThongTinVongLap thongTin = new ThongTinVongLap(loai, bienDem, start, end);
                thongTinVongLaps.Add(thongTin);
            }

            string phepToan = testStrArr[testStrArr.Length - 1].Replace('(', '[');
            phepToan = phepToan.Replace(')', ']');
            post_Type2 = new Post_Type2(thongTinVongLaps, phepToan);
        }
    }
}
