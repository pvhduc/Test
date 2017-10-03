namespace Test
{
    partial class Form1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(71, 52);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(203, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(71, 115);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(203, 20);
            this.txt2.TabIndex = 0;
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(190, 210);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(0, 13);
            this.lbKQ.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cộng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trừ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

