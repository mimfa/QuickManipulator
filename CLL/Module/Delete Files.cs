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
    public class Delete_Files : Copy_Files
    {
        public override string Name => "Delete Files";
        public override string[] OperandNames => new string[] { };
        public override string[] OperandValues => new string[] { };
        public override OperandType[] OperandTypes => new OperandType[] {};

        public override string Action(MFL.Package package)
        {
            List<string> ls = new List<string>();
            foreach (var item in package.Content.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries))
                if (File.Exists(item))
                    try { File.Delete(item); } catch { ls.Add(item); }
                else ls.Add(item);
            return string.Join(Environment.NewLine,ls);
        }
    }
}
