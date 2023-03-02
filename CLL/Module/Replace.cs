using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class Replace : MFL.Manipulate
    {
        public override string Name => "Replace";
        public override string[] OperandNames => new string[] {"Old", "New" };

        public override string Action(MFL.Package package)
        {
            string text = package.Content;
            text = text.Replace(package.Operands[0], package.Operands[1]);
            return text;
        }
    }
}
