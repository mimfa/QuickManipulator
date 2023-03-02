using MFL;
using MiMFa.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class Copy_Files : MFL.Manipulate
    {
        public override string Name => "Copy Files";
        public override bool ContentPanel => true;
        public override string[] OperandNames => new string[] { "Destination Dir"};
        public override string[] OperandValues => new string[] { "" };
        public override OperandType[] OperandTypes => new OperandType[] { OperandType.Directory};

        public override string Action(MFL.Package package)
        {
            string dir = package.Operands[0].TrimEnd('\\')+"\\";
            List<string> ls = new List<string>();
            if (Directory.Exists(dir))
                foreach (var item in package.Content.Split(new string[] { Environment.NewLine,"\n" }, StringSplitOptions.RemoveEmptyEntries))
                    if (File.Exists(item))
                        try { File.Copy(item, dir + Path.GetFileName(item)); } catch { ls.Add(item); }
                    else ls.Add(item);
            return string.Join(Environment.NewLine,ls);
        }
    }
}
