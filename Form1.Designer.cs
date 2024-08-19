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
            btnTellMachine = new Button();
            label2 = new Label();
            lblTellMachine = new Label();
            panel1 = new Panel();
            rtxtUserMessage = new RichTextBox();
            btnTellMCHN = new Button();
            panel2 = new Panel();
            lblUserSays = new Label();
            lblMachineResults = new Label();
            btnReset = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.DarkOrange;
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
            lblSure.ForeColor = Color.Yellow;
            lblSure.Location = new Point(316, 78);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(99, 20);
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
            // btnTellMachine
            // 
            btnTellMachine.Location = new Point(421, 140);
            btnTellMachine.Name = "btnTellMachine";
            btnTellMachine.Size = new Size(138, 34);
            btnTellMachine.TabIndex = 5;
            btnTellMachine.Text = "Tell the machine";
            btnTellMachine.UseVisualStyleBackColor = true;
            btnTellMachine.Visible = false;
            btnTellMachine.Click += button2_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(575, 78);
            label2.Name = "label2";
            label2.Size = new Size(213, 96);
            label2.TabIndex = 6;
            label2.Text = "lbl";
            label2.Visible = false;
            // 
            // lblTellMachine
            // 
            lblTellMachine.AutoSize = true;
            lblTellMachine.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTellMachine.ForeColor = Color.DarkOrange;
            lblTellMachine.Location = new Point(13, 9);
            lblTellMachine.Name = "lblTellMachine";
            lblTellMachine.Size = new Size(203, 15);
            lblTellMachine.TabIndex = 7;
            lblTellMachine.Text = "Tell the Machine in your own words";
            lblTellMachine.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(rtxtUserMessage);
            panel1.Controls.Add(btnTellMCHN);
            panel1.Controls.Add(lblTellMachine);
            panel1.Location = new Point(34, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 140);
            panel1.TabIndex = 8;
            // 
            // rtxtUserMessage
            // 
            rtxtUserMessage.Location = new Point(13, 30);
            rtxtUserMessage.Name = "rtxtUserMessage";
            rtxtUserMessage.Size = new Size(363, 66);
            rtxtUserMessage.TabIndex = 10;
            rtxtUserMessage.Text = "";
            rtxtUserMessage.Visible = false;
            // 
            // btnTellMCHN
            // 
            btnTellMCHN.Location = new Point(238, 99);
            btnTellMCHN.Name = "btnTellMCHN";
            btnTellMCHN.Size = new Size(138, 34);
            btnTellMCHN.TabIndex = 9;
            btnTellMCHN.Text = "Say your piece";
            btnTellMCHN.UseVisualStyleBackColor = true;
            btnTellMCHN.Visible = false;
            btnTellMCHN.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUserSays);
            panel2.Controls.Add(lblMachineResults);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(422, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 232);
            panel2.TabIndex = 10;
            panel2.Visible = false;
            // 
            // lblUserSays
            // 
            lblUserSays.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserSays.ForeColor = Color.Silver;
            lblUserSays.Location = new Point(13, 30);
            lblUserSays.Name = "lblUserSays";
            lblUserSays.Size = new Size(169, 158);
            lblUserSays.TabIndex = 12;
            lblUserSays.Text = "lbl";
            // 
            // lblMachineResults
            // 
            lblMachineResults.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMachineResults.ForeColor = Color.Yellow;
            lblMachineResults.Location = new Point(198, 30);
            lblMachineResults.Name = "lblMachineResults";
            lblMachineResults.Size = new Size(138, 156);
            lblMachineResults.TabIndex = 11;
            lblMachineResults.Text = "lbl";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(198, 189);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(138, 34);
            btnReset.TabIndex = 9;
            btnReset.Text = "Play again";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(13, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "Results:";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btnTellMachine);
            Controls.Add(checkedListBox1);
            Controls.Add(lblSure);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = SystemColors.MenuText;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private Label lblSure;
        private CheckedListBox checkedListBox1;
        private Button btnTellMachine;
        private Label label2;
        private Label lblTellMachine;
        private Panel panel1;
        private Button btnTellMCHN;
        private Panel panel2;
        private Button btnReset;
        private Label label4;
        private RichTextBox rtxtUserMessage;
        private Label lblUserSays;
        private Label lblMachineResults;
    }
}
