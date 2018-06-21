namespace RGBPicker
{
    partial class RGB
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
            this.numRedUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numGreenUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBlueUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRedUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 156);
            this.panel1.TabIndex = 0;
            // 
            // numRedUD
            // 
            this.numRedUD.Location = new System.Drawing.Point(32, 174);
            this.numRedUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRedUD.Name = "numRedUD";
            this.numRedUD.Size = new System.Drawing.Size(55, 20);
            this.numRedUD.TabIndex = 1;
            this.numRedUD.ValueChanged += new System.EventHandler(this.numRedUD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(93, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "G";
            // 
            // numGreenUD
            // 
            this.numGreenUD.Location = new System.Drawing.Point(115, 174);
            this.numGreenUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreenUD.Name = "numGreenUD";
            this.numGreenUD.Size = new System.Drawing.Size(55, 20);
            this.numGreenUD.TabIndex = 5;
            this.numGreenUD.ValueChanged += new System.EventHandler(this.numGreenUD_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(176, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // numBlueUD
            // 
            this.numBlueUD.Location = new System.Drawing.Point(198, 174);
            this.numBlueUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlueUD.Name = "numBlueUD";
            this.numBlueUD.Size = new System.Drawing.Size(55, 20);
            this.numBlueUD.TabIndex = 7;
            this.numBlueUD.ValueChanged += new System.EventHandler(this.numBlueUD_ValueChanged);
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 200);
            this.Controls.Add(this.numBlueUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numGreenUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRedUD);
            this.Controls.Add(this.panel1);
            this.Name = "RGB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRedUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numRedUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGreenUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBlueUD;
    }
}

