namespace StackQueueArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openMainForm(Form MainForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = MainForm;
            MainForm.TopLevel = false;
            MainForm.FormBorderStyle = FormBorderStyle.None;
            MainForm.Dock = DockStyle.Fill;
            panelMainForm.Controls.Add(MainForm);
            panelMainForm.Tag = MainForm;
            MainForm.BringToFront();
            MainForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openMainForm(new FormArrays());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openMainForm(new FormStacks());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openMainForm(new FormQueue());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("         Meow~~");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("         Woof!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.facebook.com/johnphilip.sabinet");
        }
    }
}