namespace SController
{
    partial class MainForm
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
            this.pBox = new System.Windows.Forms.PictureBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pBoxPrecise = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPrecise)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(12, 12);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(350, 350);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseMove);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(32, 441);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(43, 20);
            this.textBoxX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(12, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(32, 468);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(43, 20);
            this.textBoxY.TabIndex = 3;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(67, 23);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 5;
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(35, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(67, 49);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "BaudRate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pBoxPrecise
            // 
            this.pBoxPrecise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxPrecise.Location = new System.Drawing.Point(387, 12);
            this.pBoxPrecise.Name = "pBoxPrecise";
            this.pBoxPrecise.Size = new System.Drawing.Size(350, 350);
            this.pBoxPrecise.TabIndex = 10;
            this.pBoxPrecise.TabStop = false;
            this.pBoxPrecise.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoxPrecise_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.portComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.baudRateComboBox);
            this.panel1.Location = new System.Drawing.Point(537, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 11;
            // 
            // cmdLog
            // 
            this.cmdLog.Location = new System.Drawing.Point(259, 368);
            this.cmdLog.Multiline = true;
            this.cmdLog.Name = "cmdLog";
            this.cmdLog.Size = new System.Drawing.Size(221, 61);
            this.cmdLog.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 556);
            this.Controls.Add(this.cmdLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBoxPrecise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.pBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPrecise)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pBoxPrecise;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cmdLog;
    }
}

