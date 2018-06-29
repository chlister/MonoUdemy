namespace LogoAnimator
{
    partial class FrmAnimation
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
            this.components = new System.ComponentModel.Container();
            this.picture_Box = new System.Windows.Forms.PictureBox();
            this.startStop_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.OutputBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Box
            // 
            this.picture_Box.Location = new System.Drawing.Point(101, 30);
            this.picture_Box.Name = "picture_Box";
            this.picture_Box.Size = new System.Drawing.Size(278, 218);
            this.picture_Box.TabIndex = 0;
            this.picture_Box.TabStop = false;
            // 
            // startStop_btn
            // 
            this.startStop_btn.Location = new System.Drawing.Point(205, 264);
            this.startStop_btn.Name = "startStop_btn";
            this.startStop_btn.Size = new System.Drawing.Size(75, 23);
            this.startStop_btn.TabIndex = 1;
            this.startStop_btn.Text = "Start / Stop";
            this.startStop_btn.UseVisualStyleBackColor = true;
            this.startStop_btn.Click += new System.EventHandler(this.startStop_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 280;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // OutputBox
            // 
            this.OutputBox.AutoSize = true;
            this.OutputBox.Location = new System.Drawing.Point(220, 317);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(35, 13);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Text = "label1";
            // 
            // FrmAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 364);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.startStop_btn);
            this.Controls.Add(this.picture_Box);
            this.Name = "FrmAnimation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation";
            this.Load += new System.EventHandler(this.FrmAnimation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_Box;
        private System.Windows.Forms.Button startStop_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label OutputBox;
    }
}

