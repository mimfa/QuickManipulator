using MiMFa.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class Replace_Text_Between : MFL.Manipulate
    {
        public override string Name => "Replace Text Between";
        public override string[] OperandNames => new string[] { "From This", "To This", "Replace With" };

        public override string Action(MFL.Package package)
        {
            return Regex.Replace(package.Content, package.Operands[0]+".*"+ package.Operands[1], package.Operands[2],RegexOptions.IgnoreCase);
        }
    }
}
