using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.General;
using MiMFa.Service;

namespace UIL
{
    public class Package : MFL.Package
    {
        public static MainPage MAIN = null;
        public override string[] Operands
        {
            get
            {
                string[] arr = new string[MAIN.p_Operands.Controls.Count];
                for (int i = 0; i < MAIN.p_Operands.Controls.Count; i++)
                    arr[i] = ((Sub.Operand)MAIN.p_Operands.Controls[i]).ValueBox.Text;
                return arr.Reverse().ToArray();
            }
        }
        public override string Content
        {
            get { return MAIN.rtb_Text.Text; }
            set { MAIN.rtb_Text.Text = value; }
        }
    }
}
