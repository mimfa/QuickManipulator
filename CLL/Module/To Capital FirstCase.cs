using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class To_Capital_FirstCase : MFL.Manipulate
    {
        public override string Name => "To Capital First Case";
        public override string[] OperandNames => new string[] { "Middle Sign" };

        public override string Action(MFL.Package package)
        {
            string[] stra = package.Content.Split(new string[] { package.Operands[0] }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < stra.Length; i++)
                stra[i] = stra[i][0].ToString() + string.Join("", stra[i].Skip(1));
            return string.Join(package.Operands[0],stra);
        }
    }
}
