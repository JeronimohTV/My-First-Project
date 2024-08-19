namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Fuck you buddy!";
            checkBox1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lblSure.Visible = true;
                checkedListBox1.Visible = true;
                btnTellMachine.Visible = true;
            }
            else
            {
                lblSure.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chkmsg = "";
            label2.Visible = true;

            if (checkedListBox1.CheckedItems.Count > 0)
            {
                foreach (string item in checkedListBox1.CheckedItems)
                {
                    chkmsg += item + " ";
                }

                
                label2.Text = "\"" + chkmsg + "\"" + "\nThat's what you sound like";
                panel1.Visible = true;
                lblTellMachine.Visible = true;
                rtxtUserMessage.Visible = true;
                btnTellMCHN.Visible = true;
            }
            else
            {
                label2.Text = "Oh... Too Scared to say something?";
                panel1.Visible = false;
                lblTellMachine.Visible = false;
                rtxtUserMessage.Visible = false;
                btnTellMCHN.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rtxtUserMessage.Text != "")
            {
                panel2.Visible = true;
                lblUserSays.Text = rtxtUserMessage.Text;
                lblMachineResults.Text = "You know what? I respect that. \n I apologise for my cold words. \n Your meat suit deserves more warmth from me.";
                btnReset.Visible = true;
            }
            else
            {
                panel2.Visible = true;
                lblUserSays.Text = "I'm afraid to say it.";
                lblMachineResults.Text = "I KNEW YOU WERE TOO COWARDLY TO SPEAK YOUR TRUTH! \n SAY SOMETHING I DARE YOU!";
                btnReset.Visible = false;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}
