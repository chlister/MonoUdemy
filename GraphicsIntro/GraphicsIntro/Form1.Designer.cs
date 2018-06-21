namespace GraphicsIntro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrapTest1 = new System.Windows.Forms.Button();
            this.GrapTest2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(35, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 181);
            this.panel1.TabIndex = 0;
            // 
            // GrapTest1
            // 
            this.GrapTest1.Location = new System.Drawing.Point(57, 217);
            this.GrapTest1.Name = "GrapTest1";
            this.GrapTest1.Size = new System.Drawing.Size(92, 41);
            this.GrapTest1.TabIndex = 1;
            this.GrapTest1.Text = "Perform Graphics Test 1";
            this.GrapTest1.UseVisualStyleBackColor = true;
            this.GrapTest1.Click += new System.EventHandler(this.GrapTest1_Click);
            // 
            // GrapTest2
            // 
            this.GrapTest2.Location = new System.Drawing.Point(156, 217);
            this.GrapTest2.Name = "GrapTest2";
            this.GrapTest2.Size = new System.Drawing.Size(97, 41);
            this.GrapTest2.TabIndex = 2;
            this.GrapTest2.Text = "Perform Graphics Test 2";
            this.GrapTest2.UseVisualStyleBackColor = true;
            this.GrapTest2.Click += new System.EventHandler(this.GrapTest2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(423, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 181);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GrapTest2);
            this.Controls.Add(this.GrapTest1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GrapTest1;
        private System.Windows.Forms.Button GrapTest2;
        private System.Windows.Forms.Panel panel2;
    }
}

