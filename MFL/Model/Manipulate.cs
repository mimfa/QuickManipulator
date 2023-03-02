using System;
namespace MFL
{
    public class Manipulate
    {
        public virtual string Name => "";
        public virtual bool ContentPanel => true;
        public virtual string[] OperandNames => new string[]{  };
        public virtual string[] OperandValues => new string[] { "", "", "", "" };
        public virtual OperandType[] OperandTypes => new OperandType[] { OperandType.Text, OperandType.Text, OperandType.Text, OperandType.Text };

        public virtual string Action(Package package)
        {
            string str = package.Content;
            return str;
        }
    }
}
