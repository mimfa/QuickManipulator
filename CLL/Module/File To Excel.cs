using MFL;
using MiMFa.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class File_To_Excel : MFL.Manipulate
    {
        public override string Name => "File to Excel";
        public override bool ContentPanel => false;
        public override string[] OperandNames => new string[] {"Source File", "Destination File", "Delimited", "Trim Chars" };
        public override string[] OperandValues => new string[] { "", "", "\t", "\'\"" };
        public override OperandType[] OperandTypes => new OperandType[] { OperandType.OpenFile, OperandType.SaveFile, OperandType.Text, OperandType.Character };

        public override string Action(MFL.Package package)
        {
            ConvertService.ToExcelFile(package.Operands[0], package.Operands[1],new string[] { package.Operands[2] }, package.Operands[3].ToCharArray());
            return "";
        }
    }
}
