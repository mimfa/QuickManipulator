using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class Sentence_To_Valid_Attribute_Name : MFL.Manipulate
    {
        public override string Name => "Sentence To Valid Attribute Name";
        public override string[] OperandNames => new string[] { "Middle Sign"};

        public override string Action(MFL.Package package)
        {
            string text = Regex.Replace(package.Content,@"\W+|\s+"," ");
            string[] stra = text.Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < stra.Length; i++)
                stra[i] = stra[i][0].ToString()+ string.Join("",stra[i].Skip(1));
            return string.Join(package.Operands[0],stra);
        }
    }
}
