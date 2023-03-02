using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class Sort : MFL.Manipulate
    {
        public override string Name => "Sort";
        public override string[] OperandNames => new string[] { "Delimited" };

        public override string Action(MFL.Package package)
        {
            string op1 = package.Operands[0];
            List<string> ls = package.Content.Split(new string[] { op1 },StringSplitOptions.None).ToList();
            ls.Sort();
            return string.Join(op1, ls);
        }
    }
}
