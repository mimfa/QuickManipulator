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
    public class Move_Files : Copy_Files
    {
        public override string Name => "Move Files";

        public override string Action(MFL.Package package)
        {
            string dir = package.Operands[0].TrimEnd('\\')+"\\";
            List<string> ls = new List<string>();
            if (Directory.Exists(dir))
                foreach (var item in package.Content.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries))
                    if (File.Exists(item))
                        try { File.Move(item, dir + Path.GetFileName(item)); } catch { ls.Add(item); }
                    else ls.Add(item);
            return string.Join(Environment.NewLine,ls);
        }
    }
}
