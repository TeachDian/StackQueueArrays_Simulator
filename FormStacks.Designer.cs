namespace StackQueueArrays
{
    partial class FormStacks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.LBAC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.btnPeek);
            this.panel1.Controls.Add(this.btnPop);
            this.panel1.Controls.Add(this.btnPush);
            this.panel1.Controls.Add(this.LBAC);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 466);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(382, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = ">";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(719, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 33);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Teal;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(396, 336);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(322, 60);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.BackColor = System.Drawing.Color.Teal;
            this.btnPeek.FlatAppearance.BorderSize = 0;
            this.btnPeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeek.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPeek.Location = new System.Drawing.Point(396, 270);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(322, 60);
            this.btnPeek.TabIndex = 5;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = false;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.Color.Teal;
            this.btnPop.FlatAppearance.BorderSize = 0;
            this.btnPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPop.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPop.Location = new System.Drawing.Point(396, 204);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(322, 60);
            this.btnPop.TabIndex = 4;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.Teal;
            this.btnPush.FlatAppearance.BorderSize = 0;
            this.btnPush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPush.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPush.Location = new System.Drawing.Point(396, 138);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(322, 60);
            this.btnPush.TabIndex = 3;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // LBAC
            // 
            this.LBAC.AutoSize = true;
            this.LBAC.Font = new System.Drawing.Font("Product Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBAC.ForeColor = System.Drawing.Color.Gold;
            this.LBAC.Location = new System.Drawing.Point(415, 41);
            this.LBAC.Name = "LBAC";
            this.LBAC.Size = new System.Drawing.Size(0, 32);
            this.LBAC.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Product Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(396, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Gold;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(43, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 377);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormStacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 466);
            this.Controls.Add(this.panel1);
            this.Name = "FormStacks";
            this.Text = "Stacks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button Clear;
        private Button btnPeek;
        private Button btnPop;
        private Button btnPush;
        private Label LBAC;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
    }
}