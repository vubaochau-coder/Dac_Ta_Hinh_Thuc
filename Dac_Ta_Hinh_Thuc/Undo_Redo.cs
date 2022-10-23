using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dac_Ta_Hinh_Thuc
{
    class Undo_Redo
    {
        private string undoStr;
        private string redoStr;

        public Undo_Redo(string undo, string redo)
        {
            undoStr = undo;
            redoStr = redo;
        }
        public Undo_Redo()
        {
            undoStr = "";
            redoStr = "";
        }
        public string Get_Undo()
        {
            return undoStr;
        }
        public string Get_Redo()
        {
            return redoStr;
        }
    }
}
