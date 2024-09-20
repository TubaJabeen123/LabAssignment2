namespace lab3
{
    partial class task1
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
            this.inoutTextBox1 = new System.Windows.Forms.RichTextBox();
            this.outputTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inoutTextBox1
            // 
            this.inoutTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inoutTextBox1.Location = new System.Drawing.Point(54, 55);
            this.inoutTextBox1.Name = "inoutTextBox1";
            this.inoutTextBox1.Size = new System.Drawing.Size(312, 96);
            this.inoutTextBox1.TabIndex = 0;
            this.inoutTextBox1.Text = "";
            this.inoutTextBox1.TextChanged += new System.EventHandler(this.inoutTextBox1_TextChanged);
            // 
            // outputTextBox2
            // 
            this.outputTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox2.Location = new System.Drawing.Point(54, 193);
            this.outputTextBox2.Name = "outputTextBox2";
            this.outputTextBox2.Size = new System.Drawing.Size(312, 96);
            this.outputTextBox2.TabIndex = 1;
            this.outputTextBox2.Text = "";
            this.outputTextBox2.TextChanged += new System.EventHandler(this.outputTextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(196, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "show Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputTextBox2);
            this.Controls.Add(this.inoutTextBox1);
            this.Name = "task1";
            this.Text = "task1";
            this.Load += new System.EventHandler(this.task1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inoutTextBox1;
        private System.Windows.Forms.RichTextBox outputTextBox2;
        private System.Windows.Forms.Button button1;
    }
}