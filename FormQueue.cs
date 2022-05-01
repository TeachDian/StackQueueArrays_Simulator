using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackQueueArrays
{
    public partial class FormQueue : Form
    {
        public FormQueue()
        {
            InitializeComponent();
        }
        Queue<string> queue = new Queue<string>();

        #region miscBtn
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            LBAC.ResetText();
            queue.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
                btnNQ.Enabled = false;
            else
                btnNQ.Enabled = true;
        }

        #endregion miscBtn

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            queue.Enqueue(textBox1.Text);
        }

        private void btnNQ_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);        // (0, textBox1.Text);
            queue.Enqueue(textBox1.Text);
            textBox1.Clear();
        }

        private void btnDQ_Click(object sender, EventArgs e)
        {
            if(queue.Count > 0)
            {
                // you cann change here what ever you waant to put
                LBAC.Text = "First To Enter: " + listBox1.Items[0].ToString();
                listBox1.Items.RemoveAt(0);
                queue.Dequeue();
            }
            else if (queue.Count <= 0)
            {
                LBAC.ResetText();
                MessageBox.Show("There's Nothing in Queue!");
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                LBAC.Text = "First in Queue: " + //listBox1.Items[0].ToString();
                //listBox1.Items[0] =
                queue.Peek();
            }
            else if (queue.Count <= 0)
            {
                LBAC.ResetText();
                MessageBox.Show("There's no Item to View!");
            }
        }
    }
}
