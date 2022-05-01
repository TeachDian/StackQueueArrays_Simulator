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
    public partial class FormStacks : Form
    {
        public FormStacks()
        {
            InitializeComponent();
        }
        Stack<string> stack = new Stack<string>();

        private void Clear_Click(object sender, EventArgs e)
        {  
            listBox1.Items.Clear();
            textBox1.Clear();
            LBAC.ResetText();
            stack.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, textBox1.Text);
            stack.Push(textBox1.Text);
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, textBox1.Text);
            stack.Push(textBox1.Text);
            textBox1.Clear();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                LBAC.Text = "Pop: " + listBox1.Items[0].ToString();
                listBox1.Items.RemoveAt(0);
                stack.Pop();
            }
            else if(stack.Count <= 0)
            {
                LBAC.ResetText();
                MessageBox.Show("There's Nothing to Remove here!"); 
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                LBAC.Text = "Peek: " + listBox1.Items[0].ToString();
                listBox1.Items[0] = stack.Peek();
            }
            else if (stack.Count <= 0)
            {
                LBAC.ResetText();
                MessageBox.Show("There's no Item to View!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                btnPush.Enabled = false;
            else
                btnPush.Enabled = true;
        }
    }
}
