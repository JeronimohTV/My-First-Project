namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            lblSure = new Label();
            checkedListBox1 = new CheckedListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 46);
            button1.Name = "button1";
            button1.Size = new Size(155, 79);
            button1.TabIndex = 0;
            button1.Text = "Say What Button?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(212, 77);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Are You Sure?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblSure
            // 
            lblSure.Location = new Point(316, 78);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(164, 20);
            lblSure.TabIndex = 3;
            lblSure.Text = "Fuck You Again";
            lblSure.Visible = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Really?", "That's not necessary", "Take it easy" });
            checkedListBox1.Location = new Point(421, 76);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(138, 58);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(421, 140);
            button2.Name = "button2";
            button2.Size = new Size(138, 34);
            button2.TabIndex = 5;
            button2.Text = "Tell the machine";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(checkedListBox1);
            Controls.Add(lblSure);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = SystemColors.MenuText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private Label lblSure;
        private CheckedListBox checkedListBox1;
        private Button button2;
    }
}
