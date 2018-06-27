namespace BlackBoardChallenge
{
    partial class FrmBlackBoard
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
            this.BlackBoardPanel = new System.Windows.Forms.Panel();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioYellow = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.radioWhite = new System.Windows.Forms.RadioButton();
            this.radioBlack = new System.Windows.Forms.RadioButton();
            this.eraseButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BlackBoardPanel
            // 
            this.BlackBoardPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BlackBoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlackBoardPanel.Location = new System.Drawing.Point(12, 12);
            this.BlackBoardPanel.Name = "BlackBoardPanel";
            this.BlackBoardPanel.Size = new System.Drawing.Size(570, 426);
            this.BlackBoardPanel.TabIndex = 0;
            this.BlackBoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BlackBoardPanel_Paint);
            this.BlackBoardPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BlackBoardPanel_MouseDown);
            this.BlackBoardPanel.MouseHover += new System.EventHandler(this.BlackBoardPanel_MouseHover);
            this.BlackBoardPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BlackBoardPanel_MouseMove);
            this.BlackBoardPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BlackBoardPanel_MouseUp);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ColorPanel.Controls.Add(this.radioBlack);
            this.ColorPanel.Controls.Add(this.radioWhite);
            this.ColorPanel.Controls.Add(this.radioBlue);
            this.ColorPanel.Controls.Add(this.radioGreen);
            this.ColorPanel.Controls.Add(this.radioYellow);
            this.ColorPanel.Controls.Add(this.radioRed);
            this.ColorPanel.Location = new System.Drawing.Point(588, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(200, 250);
            this.ColorPanel.TabIndex = 1;
            this.ColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorPanel_Paint);
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRed.Location = new System.Drawing.Point(37, 208);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(82, 35);
            this.radioRed.TabIndex = 0;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.CheckedChanged += new System.EventHandler(this.radioRed_CheckedChanged);
            // 
            // radioYellow
            // 
            this.radioYellow.AutoSize = true;
            this.radioYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYellow.Location = new System.Drawing.Point(37, 126);
            this.radioYellow.Name = "radioYellow";
            this.radioYellow.Size = new System.Drawing.Size(112, 35);
            this.radioYellow.TabIndex = 1;
            this.radioYellow.TabStop = true;
            this.radioYellow.Text = "Yellow";
            this.radioYellow.UseVisualStyleBackColor = true;
            this.radioYellow.CheckedChanged += new System.EventHandler(this.radioYellow_CheckedChanged);
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGreen.Location = new System.Drawing.Point(37, 167);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(107, 35);
            this.radioGreen.TabIndex = 2;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.CheckedChanged += new System.EventHandler(this.radioGreen_CheckedChanged);
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBlue.Location = new System.Drawing.Point(39, 85);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(86, 35);
            this.radioBlue.TabIndex = 4;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radioBlue_CheckedChanged);
            // 
            // radioWhite
            // 
            this.radioWhite.AutoSize = true;
            this.radioWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWhite.Location = new System.Drawing.Point(37, 44);
            this.radioWhite.Name = "radioWhite";
            this.radioWhite.Size = new System.Drawing.Size(101, 35);
            this.radioWhite.TabIndex = 5;
            this.radioWhite.TabStop = true;
            this.radioWhite.Text = "White";
            this.radioWhite.UseVisualStyleBackColor = true;
            this.radioWhite.CheckedChanged += new System.EventHandler(this.radioWhite_CheckedChanged);
            // 
            // radioBlack
            // 
            this.radioBlack.AutoSize = true;
            this.radioBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBlack.Location = new System.Drawing.Point(39, 3);
            this.radioBlack.Name = "radioBlack";
            this.radioBlack.Size = new System.Drawing.Size(99, 35);
            this.radioBlack.TabIndex = 6;
            this.radioBlack.TabStop = true;
            this.radioBlack.Text = "Black";
            this.radioBlack.UseVisualStyleBackColor = true;
            this.radioBlack.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(588, 268);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(75, 23);
            this.eraseButton.TabIndex = 2;
            this.eraseButton.Text = "Erase All";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(589, 417);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FrmBlackBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.BlackBoardPanel);
            this.Name = "FrmBlackBoard";
            this.Text = "BlackBoard";
            this.Load += new System.EventHandler(this.FrmBlackBoard_Load);
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BlackBoardPanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.RadioButton radioBlack;
        private System.Windows.Forms.RadioButton radioWhite;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioYellow;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

