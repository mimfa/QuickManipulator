using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL.Module
{
    public class To_Upper_Case : MFL.Manipulate
    {
        public override string Name => "To Upper Case";

        public override string Action(MFL.Package package)
        {
            return package.Content.ToUpper();
        }
    }
}
