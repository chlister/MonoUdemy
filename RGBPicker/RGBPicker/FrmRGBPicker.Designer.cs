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
            this.numHue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSaturation = new System.Windows.Forms.NumericUpDown();
            this.buttonCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRedUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaturation)).BeginInit();
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
            // numHue
            // 
            this.numHue.Location = new System.Drawing.Point(281, 33);
            this.numHue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHue.Name = "numHue";
            this.numHue.Size = new System.Drawing.Size(62, 20);
            this.numHue.TabIndex = 8;
            this.numHue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHue.ValueChanged += new System.EventHandler(this.numHue_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(281, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alpha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(278, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saturation";
            // 
            // numSaturation
            // 
            this.numSaturation.Location = new System.Drawing.Point(281, 84);
            this.numSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSaturation.Name = "numSaturation";
            this.numSaturation.Size = new System.Drawing.Size(62, 20);
            this.numSaturation.TabIndex = 11;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(284, 144);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(59, 23);
            this.buttonCopy.TabIndex = 12;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 200);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.numSaturation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numHue);
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
            ((System.ComponentModel.ISupportInitialize)(this.numHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaturation)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numHue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSaturation;
        private System.Windows.Forms.Button buttonCopy;
    }
}

