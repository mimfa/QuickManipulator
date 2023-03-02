using MiMFa.Exclusive.ProgramingTechnology.DataBase;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFL;

namespace CLL.Module
{
    public class SQLite_Database_To_SQLite_Database : MFL.Manipulate
    {
        public override string Name => "SQLite Database To SQLite Database";
        public override bool ContentPanel => false;
        public override string[] OperandNames => new string[] { "Source Address", "Destination Address", "Table Name" };
        public override OperandType[] OperandTypes => new OperandType[] { OperandType.OpenFile, OperandType.SaveFile, OperandType.Text };

        public override string Action(MFL.Package package)
        {
            SQLiteDataBase msqls = new SQLiteDataBase(package.Operands[0]);
            SQLiteDataBase msqld = new SQLiteDataBase(package.Operands[1]);
            //var st = msqls.Select(package.Operand3);
            //for (int i = 0; i < st.Rows.Count; i++)
            //{
            //    st.Rows[i]["Value"] = (st.Rows[i]["Value"] + "").Replace("(گ | ش)", "").Replace("(ج | ش)", "");
            //    msqls.SetValue(package.Operand3, st.Rows[i]["Sign"] + "", st.Rows[i]["Value"] + "");
            //}
            msqld.Insert(package.Operands[2], msqls.Select(package.Operands[2]));
            return "";
        }
    }
}
