namespace ScreenshotForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnScreenshot = new System.Windows.Forms.Button();
            this.ScreenPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ImageName = new System.Windows.Forms.TextBox();
            this.ScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnScreenshot
            // 
            this.BtnScreenshot.Location = new System.Drawing.Point(388, 281);
            this.BtnScreenshot.Name = "BtnScreenshot";
            this.BtnScreenshot.Size = new System.Drawing.Size(175, 49);
            this.BtnScreenshot.TabIndex = 0;
            this.BtnScreenshot.Text = "Screenshot";
            this.BtnScreenshot.UseVisualStyleBackColor = true;
            this.BtnScreenshot.Click += new System.EventHandler(this.BtnScreenshot_Click);
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ScreenPanel.Controls.Add(this.panel1);
            this.ScreenPanel.Controls.Add(this.button1);
            this.ScreenPanel.Controls.Add(this.label1);
            this.ScreenPanel.Controls.Add(this.checkBox1);
            this.ScreenPanel.Controls.Add(this.textBox1);
            this.ScreenPanel.Controls.Add(this.comboBox1);
            this.ScreenPanel.Location = new System.Drawing.Point(12, 12);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.Size = new System.Drawing.Size(615, 263);
            this.ScreenPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(78, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Drag";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Move me";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(403, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Tasks";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 23);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(312, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // ImageName
            // 
            this.ImageName.Location = new System.Drawing.Point(78, 295);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(264, 23);
            this.ImageName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 342);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.ScreenPanel);
            this.Controls.Add(this.BtnScreenshot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ScreenPanel.ResumeLayout(false);
            this.ScreenPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnScreenshot;
        private Panel ScreenPanel;
        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel1;
        private TextBox ImageName;
    }
}