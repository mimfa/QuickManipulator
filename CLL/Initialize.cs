using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL
{
    public class Initialize
    {
        public MFL.Package Package = new MFL.Package();
        public MFL.ManipulateCollection Manipulators { get; set; } = new MFL.ManipulateCollection();

        public Initialize()
        {
            Manipulators.AddRange(new MFL.Manipulate[]
            {
                new Module.Copy_Files(),
                new Module.Move_Files(),
                new Module.Delete_Files(),
                new Module.To_Lower_Case(),
                new Module.To_Upper_Case(),
                new Module.To_Capital_FirstCase(),
                new Module.Replace(),
                new Module.Replace_Text_Between(),
                new Module.Replace_Prefix_With_Postfix(),
                new Module.Sentence_To_Valid_Attribute_Name(),
                new Module.SQLite_Database_To_SQLite_Database(),
                new Module.File_To_Excel(),
                new Module.Sort(),
                new Module.Reverse(),
                new Module.Distinct()
            });
        }
    }
}
