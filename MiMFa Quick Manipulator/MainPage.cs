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
using System.Threading.Tasks;

namespace UIL
{
    public partial class MainPage : Form
    {
        private CLL.Initialize Kernel = new CLL.Initialize();
        public MainPage()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Package.MAIN = this;
            cb_Action.DisplayMember = "Name";
            cb_Action.Items.Clear();
            foreach (var item in Kernel.Manipulators)
                cb_Action.Items.Add(item);
        }
        private void sb_Apply_Click(object sender, EventArgs e)
        {
            if (cb_Action.SelectedIndex >= 0)
            {
                Task.Run(() =>
                {
                    PB.Value = 5;
                    MFL.Manipulate M = (MFL.Manipulate)cb_Action.SelectedItem;
                    rtb_Text.Text = M.Action(new Package());
                    PB.Value = 100;
                });
            }
            else MessageBox.Show("Please select an action type.");
        }

        #region Forms
        private void cb_Action_SelectedIndexChanged(object sender, EventArgs e)
        {
            p_Operands.Controls.Clear();
            if (sb_Apply.Visible = (cb_Action.SelectedIndex > -1))
            {
                MFL.Manipulate M = (MFL.Manipulate)cb_Action.SelectedItem;
                tlp_Content.Visible = M.ContentPanel;
                if (M.OperandNames.Length > 0)
                {
                    p_Operands.Visible = M.OperandNames.Length > 0;
                    int width = (p_Operands.Width - 5) / M.OperandNames.Length;
                    for (int i = M.OperandNames.Length-1; i >= 0 ; i--)
                    {
                        Sub.Operand op = new Sub.Operand();
                        op.LabelBox.Text = M.OperandNames[i];
                        op.Width = width;
                        op.Dock = DockStyle.Left;
                        try { op.ValueBox.Text = M.OperandValues[i]; } catch { }
                        try {
                            switch (M.OperandTypes[i])
                            {
                                case MFL.OperandType.Text:
                                    op.BackgroundImage = Properties.Resources.Light2;
                                    break;
                                case MFL.OperandType.Character:
                                    op.BackgroundImage = Properties.Resources.Dark2;
                                    break;
                                case MFL.OperandType.Directory:
                                    op.BackgroundImage = Properties.Resources.Yellow2;
                                    op.LabelBox.Cursor = Cursors.Hand;
                                    op.LabelBox.Click += (o, a) => { if (FBD.ShowDialog() == DialogResult.OK) op.ValueBox.Text = FBD.SelectedPath; };
                                    break;
                                case MFL.OperandType.OpenFile:
                                    op.BackgroundImage = Properties.Resources.Red2;
                                    op.LabelBox.Cursor = Cursors.Hand;
                                    op.LabelBox.Click += (o, a) => { if (OFD.ShowDialog() == DialogResult.OK) op.ValueBox.Text = OFD.FileName; };
                                    break;
                                case MFL.OperandType.SaveFile:
                                    op.BackgroundImage = Properties.Resources.Blue2;
                                    op.LabelBox.Cursor = Cursors.Hand;
                                    op.LabelBox.Click += (o, a) => { if (SFD.ShowDialog() == DialogResult.OK) op.ValueBox.Text = SFD.FileName; };
                                    break;
                            }
                        } catch { }
                        op.BringToFront();
                        p_Operands.Controls.Add(op);
                    }
                    p_Operands.Visible = p_Operands.Controls.Count > 0;
                    tlp_Main.Refresh();
                }
            }
            else p_Operands.Visible = false;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
        }
        private void btn_MouseLeave(object sender, EventArgs e)
        {
        }
        private void pb_Open_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK) rtb_Text.LoadFile(OFD.FileName,RichTextBoxStreamType.PlainText);
        }
        private void pb_Save_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK) rtb_Text.SaveFile(SFD.FileName, RichTextBoxStreamType.PlainText);
        }
        private void pb_Copy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtb_Text.Text)) return;
            Clipboard.SetText(rtb_Text.Text);
        }
        private void pb_Paste_Click(object sender, EventArgs e)
        {
            rtb_Text.Text = Clipboard.GetText();
        }
        private void pb_Cut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtb_Text.Text)) return;
            Clipboard.SetText(rtb_Text.Text);
            rtb_Text.Clear();
        }
        private void pb_SelectAll_Click(object sender, EventArgs e)
        {
            rtb_Text.SelectAll();
        }
        #endregion
    }
}
