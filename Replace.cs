using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using UIL;
using System.Windows.Forms;
using MiMFa_Framework.Exclusive.Effect;
using MiMFa_Framework.General;
using MiMFa_Framework.Service;
public class Replace
{
	public Replace()
	{
        List<string> lsts = MiMFa_StringService.GetAllWordBetween(text, tb_MiddleSign.Text, tb_withThis.Text, true);
        foreach (var item in lsts)
            text = text.Replace(item, "");
	}
}
