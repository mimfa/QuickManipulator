namespace UIL.Sub
{
    partial class Operand
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValueBox = new System.Windows.Forms.RichTextBox();
            this.LabelBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueBox
            // 
            this.ValueBox.AcceptsTab = true;
            this.ValueBox.AutoWordSelection = true;
            this.ValueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueBox.Location = new System.Drawing.Point(0, 28);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ValueBox.Size = new System.Drawing.Size(150, 122);
            this.ValueBox.TabIndex = 9;
            this.ValueBox.Text = "";
            // 
            // LabelBox
            // 
            this.LabelBox.BackColor = System.Drawing.Color.Transparent;
            this.LabelBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelBox.Location = new System.Drawing.Point(0, 0);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Size = new System.Drawing.Size(150, 28);
            this.LabelBox.TabIndex = 8;
            this.LabelBox.Text = "Operand";
            this.LabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Operand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UIL.Properties.Resources.Light2;
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.LabelBox);
            this.Name = "Operand";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox ValueBox;
        public System.Windows.Forms.Label LabelBox;
    }
}
