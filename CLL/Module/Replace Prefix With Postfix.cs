using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class Replace_Prefix_With_Postfix : MFL.Manipulate
    {
        public override string Name => "Replace Prefix With Postfix";
        public override string[] OperandNames => new string[] { "Middle Sign", "End Sign", "New Middle Sign" };

        public override string Action(MFL.Package package)
        {
            string ms = string.IsNullOrEmpty(package.Operands[0]) ? "" : package.Operands[0];
            string es = string.IsNullOrEmpty(package.Operands[1]) ? "" : package.Operands[1];
            string nms = string.IsNullOrEmpty(package.Operands[2]) ? "" : package.Operands[2];
            string[] texts = package.Content.Split(new string[]{es},StringSplitOptions.None);
            string result = "";
            for (int i = 0; i < texts.Length; i++)
            {
                string[] stra = texts[i].Split(new string[] { ms }, StringSplitOptions.None);
                result += string.Join(nms, stra.Reverse());
            }
            return result;
        }
    }
}
