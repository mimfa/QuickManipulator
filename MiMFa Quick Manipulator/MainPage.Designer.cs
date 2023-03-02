namespace UIL
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.sb_Apply = new System.Windows.Forms.Button();
            this.cb_Action = new System.Windows.Forms.ComboBox();
            this.tlp_Content = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_Text = new System.Windows.Forms.RichTextBox();
            this.tlp_Button = new System.Windows.Forms.TableLayoutPanel();
            this.pb_Save = new System.Windows.Forms.PictureBox();
            this.pb_Copy = new System.Windows.Forms.PictureBox();
            this.pb_Paste = new System.Windows.Forms.PictureBox();
            this.pb_Cut = new System.Windows.Forms.PictureBox();
            this.pb_SelectAll = new System.Windows.Forms.PictureBox();
            this.pb_Open = new System.Windows.Forms.PictureBox();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.p_Operands = new System.Windows.Forms.Panel();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.tlp_Main.SuspendLayout();
            this.tlp_Content.SuspendLayout();
            this.tlp_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Paste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Open)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.AutoSize = true;
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.sb_Apply, 0, 2);
            this.tlp_Main.Controls.Add(this.cb_Action, 0, 1);
            this.tlp_Main.Controls.Add(this.tlp_Content, 0, 4);
            this.tlp_Main.Controls.Add(this.PB, 0, 5);
            this.tlp_Main.Controls.Add(this.p_Operands, 0, 1);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 6;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.Size = new System.Drawing.Size(434, 432);
            this.tlp_Main.TabIndex = 0;
            // 
            // sb_Apply
            // 
            this.sb_Apply.AutoSize = true;
            this.sb_Apply.Dock = System.Windows.Forms.DockStyle.Top;
            this.sb_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sb_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sb_Apply.Location = new System.Drawing.Point(3, 112);
            this.sb_Apply.Name = "sb_Apply";
            this.sb_Apply.Padding = new System.Windows.Forms.Padding(5);
            this.sb_Apply.Size = new System.Drawing.Size(428, 39);
            this.sb_Apply.TabIndex = 4;
            this.sb_Apply.Text = "Apply";
            this.sb_Apply.UseVisualStyleBackColor = true;
            this.sb_Apply.Click += new System.EventHandler(this.sb_Apply_Click);
            // 
            // cb_Action
            // 
            this.cb_Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_Action.FormattingEnabled = true;
            this.cb_Action.Location = new System.Drawing.Point(3, 3);
            this.cb_Action.Name = "cb_Action";
            this.cb_Action.Size = new System.Drawing.Size(428, 21);
            this.cb_Action.TabIndex = 1;
            this.cb_Action.SelectedIndexChanged += new System.EventHandler(this.cb_Action_SelectedIndexChanged);
            // 
            // tlp_Content
            // 
            this.tlp_Content.BackColor = System.Drawing.SystemColors.Window;
            this.tlp_Content.ColumnCount = 1;
            this.tlp_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Content.Controls.Add(this.rtb_Text, 0, 1);
            this.tlp_Content.Controls.Add(this.tlp_Button, 0, 0);
            this.tlp_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Content.Location = new System.Drawing.Point(3, 157);
            this.tlp_Content.Name = "tlp_Content";
            this.tlp_Content.RowCount = 2;
            this.tlp_Content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Content.Size = new System.Drawing.Size(428, 261);
            this.tlp_Content.TabIndex = 3;
            // 
            // rtb_Text
            // 
            this.rtb_Text.AcceptsTab = true;
            this.rtb_Text.AutoWordSelection = true;
            this.rtb_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Text.Location = new System.Drawing.Point(3, 33);
            this.rtb_Text.Name = "rtb_Text";
            this.rtb_Text.Size = new System.Drawing.Size(422, 225);
            this.rtb_Text.TabIndex = 6;
            this.rtb_Text.Text = "";
            this.rtb_Text.WordWrap = false;
            // 
            // tlp_Button
            // 
            this.tlp_Button.AutoSize = true;
            this.tlp_Button.ColumnCount = 8;
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Button.Controls.Add(this.pb_Save, 1, 0);
            this.tlp_Button.Controls.Add(this.pb_Copy, 3, 0);
            this.tlp_Button.Controls.Add(this.pb_Paste, 5, 0);
            this.tlp_Button.Controls.Add(this.pb_Cut, 4, 0);
            this.tlp_Button.Controls.Add(this.pb_SelectAll, 6, 0);
            this.tlp_Button.Controls.Add(this.pb_Open, 0, 0);
            this.tlp_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Button.Location = new System.Drawing.Point(3, 3);
            this.tlp_Button.Name = "tlp_Button";
            this.tlp_Button.RowCount = 1;
            this.tlp_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_Button.Size = new System.Drawing.Size(422, 24);
            this.tlp_Button.TabIndex = 1;
            // 
            // pb_Save
            // 
            this.pb_Save.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_Save.Image = global::UIL.Properties.Resources.MiMFa_Save;
            this.pb_Save.Location = new System.Drawing.Point(26, 2);
            this.pb_Save.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Save.Name = "pb_Save";
            this.pb_Save.Size = new System.Drawing.Size(20, 20);
            this.pb_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Save.TabIndex = 2;
            this.pb_Save.TabStop = false;
            this.pb_Save.Click += new System.EventHandler(this.pb_Save_Click);
            // 
            // pb_Copy
            // 
            this.pb_Copy.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_Copy.Image = global::UIL.Properties.Resources.copy;
            this.pb_Copy.Location = new System.Drawing.Point(50, 2);
            this.pb_Copy.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Copy.Name = "pb_Copy";
            this.pb_Copy.Size = new System.Drawing.Size(20, 20);
            this.pb_Copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Copy.TabIndex = 0;
            this.pb_Copy.TabStop = false;
            this.pb_Copy.Click += new System.EventHandler(this.pb_Copy_Click);
            this.pb_Copy.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.pb_Copy.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pb_Paste
            // 
            this.pb_Paste.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_Paste.Image = global::UIL.Properties.Resources.Pasten;
            this.pb_Paste.Location = new System.Drawing.Point(98, 2);
            this.pb_Paste.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Paste.Name = "pb_Paste";
            this.pb_Paste.Size = new System.Drawing.Size(20, 20);
            this.pb_Paste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Paste.TabIndex = 0;
            this.pb_Paste.TabStop = false;
            this.pb_Paste.Click += new System.EventHandler(this.pb_Paste_Click);
            this.pb_Paste.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.pb_Paste.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pb_Cut
            // 
            this.pb_Cut.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_Cut.Image = global::UIL.Properties.Resources.cut;
            this.pb_Cut.Location = new System.Drawing.Point(74, 2);
            this.pb_Cut.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Cut.Name = "pb_Cut";
            this.pb_Cut.Size = new System.Drawing.Size(20, 20);
            this.pb_Cut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cut.TabIndex = 0;
            this.pb_Cut.TabStop = false;
            this.pb_Cut.Click += new System.EventHandler(this.pb_Cut_Click);
            this.pb_Cut.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.pb_Cut.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pb_SelectAll
            // 
            this.pb_SelectAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_SelectAll.Image = global::UIL.Properties.Resources.SelectAll;
            this.pb_SelectAll.Location = new System.Drawing.Point(122, 2);
            this.pb_SelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.pb_SelectAll.Name = "pb_SelectAll";
            this.pb_SelectAll.Size = new System.Drawing.Size(20, 20);
            this.pb_SelectAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_SelectAll.TabIndex = 0;
            this.pb_SelectAll.TabStop = false;
            this.pb_SelectAll.Click += new System.EventHandler(this.pb_SelectAll_Click);
            this.pb_SelectAll.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.pb_SelectAll.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pb_Open
            // 
            this.pb_Open.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_Open.Image = global::UIL.Properties.Resources.MiMFa_Open;
            this.pb_Open.Location = new System.Drawing.Point(2, 2);
            this.pb_Open.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Open.Name = "pb_Open";
            this.pb_Open.Size = new System.Drawing.Size(20, 20);
            this.pb_Open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Open.TabIndex = 1;
            this.pb_Open.TabStop = false;
            this.pb_Open.Click += new System.EventHandler(this.pb_Open_Click);
            // 
            // PB
            // 
            this.PB.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB.Location = new System.Drawing.Point(3, 424);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(428, 5);
            this.PB.TabIndex = 5;
            // 
            // p_Operands
            // 
            this.p_Operands.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Operands.Location = new System.Drawing.Point(3, 30);
            this.p_Operands.Name = "p_Operands";
            this.p_Operands.Size = new System.Drawing.Size(428, 76);
            this.p_Operands.TabIndex = 6;
            this.p_Operands.Visible = false;
            // 
            // OFD
            // 
            this.OFD.RestoreDirectory = true;
            // 
            // SFD
            // 
            this.SFD.RestoreDirectory = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 432);
            this.Controls.Add(this.tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiMFa Quick Manipulator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            this.tlp_Content.ResumeLayout(false);
            this.tlp_Content.PerformLayout();
            this.tlp_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Paste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.TableLayoutPanel tlp_Content;
        private System.Windows.Forms.TableLayoutPanel tlp_Button;
        private System.Windows.Forms.PictureBox pb_Copy;
        private System.Windows.Forms.PictureBox pb_Paste;
        private System.Windows.Forms.PictureBox pb_Cut;
        private System.Windows.Forms.PictureBox pb_SelectAll;
        internal System.Windows.Forms.ComboBox cb_Action;
        internal System.Windows.Forms.RichTextBox rtb_Text;
        private System.Windows.Forms.Button sb_Apply;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.PictureBox pb_Open;
        private System.Windows.Forms.PictureBox pb_Save;
        public System.Windows.Forms.Panel p_Operands;
    }
}