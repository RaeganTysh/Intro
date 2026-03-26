
namespace WinFormsApp_Calculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Equalbutton = new System.Windows.Forms.Button();
            this.Dotbutton = new System.Windows.Forms.Button();
            this.Zerobutton = new System.Windows.Forms.Button();
            this.Plusbutton = new System.Windows.Forms.Button();
            this.Threebutton = new System.Windows.Forms.Button();
            this.Twobutton = new System.Windows.Forms.Button();
            this.Onebutton = new System.Windows.Forms.Button();
            this.Minusbutton = new System.Windows.Forms.Button();
            this.Sixbutton = new System.Windows.Forms.Button();
            this.Fivebutton = new System.Windows.Forms.Button();
            this.Fourbutton = new System.Windows.Forms.Button();
            this.Multbutton = new System.Windows.Forms.Button();
            this.Ninebutton = new System.Windows.Forms.Button();
            this.Eightbutton = new System.Windows.Forms.Button();
            this.Sevbutton = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.Divbutton = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(12, 13);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(411, 23);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculationResultText.Location = new System.Drawing.Point(12, 42);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(411, 36);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Please enter an equation and press enter or =";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Controls.Add(this.Equalbutton, 3, 4);
            this.ButtonPanel.Controls.Add(this.Dotbutton, 2, 4);
            this.ButtonPanel.Controls.Add(this.Zerobutton, 1, 4);
            this.ButtonPanel.Controls.Add(this.Plusbutton, 3, 3);
            this.ButtonPanel.Controls.Add(this.Threebutton, 2, 3);
            this.ButtonPanel.Controls.Add(this.Twobutton, 1, 3);
            this.ButtonPanel.Controls.Add(this.Onebutton, 0, 3);
            this.ButtonPanel.Controls.Add(this.Minusbutton, 3, 2);
            this.ButtonPanel.Controls.Add(this.Sixbutton, 2, 2);
            this.ButtonPanel.Controls.Add(this.Fivebutton, 1, 2);
            this.ButtonPanel.Controls.Add(this.Fourbutton, 0, 2);
            this.ButtonPanel.Controls.Add(this.Multbutton, 3, 1);
            this.ButtonPanel.Controls.Add(this.Ninebutton, 2, 1);
            this.ButtonPanel.Controls.Add(this.Eightbutton, 1, 1);
            this.ButtonPanel.Controls.Add(this.Sevbutton, 0, 1);
            this.ButtonPanel.Controls.Add(this.CEbutton, 0, 0);
            this.ButtonPanel.Controls.Add(this.Delbutton, 2, 0);
            this.ButtonPanel.Controls.Add(this.Divbutton, 3, 0);
            this.ButtonPanel.Location = new System.Drawing.Point(12, 81);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 5;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.Size = new System.Drawing.Size(411, 278);
            this.ButtonPanel.TabIndex = 2;
            // 
            // Equalbutton
            // 
            this.Equalbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equalbutton.Location = new System.Drawing.Point(309, 223);
            this.Equalbutton.Name = "Equalbutton";
            this.Equalbutton.Size = new System.Drawing.Size(99, 52);
            this.Equalbutton.TabIndex = 19;
            this.Equalbutton.Text = "=";
            this.Equalbutton.UseVisualStyleBackColor = true;
            this.Equalbutton.Click += new System.EventHandler(this.Equalbutton_Click);
            // 
            // Dotbutton
            // 
            this.Dotbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dotbutton.Location = new System.Drawing.Point(207, 223);
            this.Dotbutton.Name = "Dotbutton";
            this.Dotbutton.Size = new System.Drawing.Size(96, 52);
            this.Dotbutton.TabIndex = 18;
            this.Dotbutton.Text = ".";
            this.Dotbutton.UseVisualStyleBackColor = true;
            this.Dotbutton.Click += new System.EventHandler(this.Dotbutton_Click);
            // 
            // Zerobutton
            // 
            this.Zerobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zerobutton.Location = new System.Drawing.Point(105, 223);
            this.Zerobutton.Name = "Zerobutton";
            this.Zerobutton.Size = new System.Drawing.Size(96, 52);
            this.Zerobutton.TabIndex = 17;
            this.Zerobutton.Text = "0";
            this.Zerobutton.UseVisualStyleBackColor = true;
            this.Zerobutton.Click += new System.EventHandler(this.Zerobutton_Click);
            // 
            // Plusbutton
            // 
            this.Plusbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plusbutton.Location = new System.Drawing.Point(309, 168);
            this.Plusbutton.Name = "Plusbutton";
            this.Plusbutton.Size = new System.Drawing.Size(99, 49);
            this.Plusbutton.TabIndex = 15;
            this.Plusbutton.Text = "+";
            this.Plusbutton.UseVisualStyleBackColor = true;
            this.Plusbutton.Click += new System.EventHandler(this.Plusbutton_Click);
            // 
            // Threebutton
            // 
            this.Threebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Threebutton.Location = new System.Drawing.Point(207, 168);
            this.Threebutton.Name = "Threebutton";
            this.Threebutton.Size = new System.Drawing.Size(96, 49);
            this.Threebutton.TabIndex = 14;
            this.Threebutton.Text = "3";
            this.Threebutton.UseVisualStyleBackColor = true;
            this.Threebutton.Click += new System.EventHandler(this.Threebutton_Click);
            // 
            // Twobutton
            // 
            this.Twobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Twobutton.Location = new System.Drawing.Point(105, 168);
            this.Twobutton.Name = "Twobutton";
            this.Twobutton.Size = new System.Drawing.Size(96, 49);
            this.Twobutton.TabIndex = 13;
            this.Twobutton.Text = "2";
            this.Twobutton.UseVisualStyleBackColor = true;
            this.Twobutton.Click += new System.EventHandler(this.Twobutton_Click);
            // 
            // Onebutton
            // 
            this.Onebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Onebutton.Location = new System.Drawing.Point(3, 168);
            this.Onebutton.Name = "Onebutton";
            this.Onebutton.Size = new System.Drawing.Size(96, 49);
            this.Onebutton.TabIndex = 12;
            this.Onebutton.Text = "1";
            this.Onebutton.UseVisualStyleBackColor = true;
            this.Onebutton.Click += new System.EventHandler(this.Onebutton_Click);
            // 
            // Minusbutton
            // 
            this.Minusbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minusbutton.Location = new System.Drawing.Point(309, 113);
            this.Minusbutton.Name = "Minusbutton";
            this.Minusbutton.Size = new System.Drawing.Size(99, 49);
            this.Minusbutton.TabIndex = 11;
            this.Minusbutton.Text = "-";
            this.Minusbutton.UseVisualStyleBackColor = true;
            this.Minusbutton.Click += new System.EventHandler(this.Minusbutton_Click);
            // 
            // Sixbutton
            // 
            this.Sixbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sixbutton.Location = new System.Drawing.Point(207, 113);
            this.Sixbutton.Name = "Sixbutton";
            this.Sixbutton.Size = new System.Drawing.Size(96, 49);
            this.Sixbutton.TabIndex = 10;
            this.Sixbutton.Text = "6";
            this.Sixbutton.UseVisualStyleBackColor = true;
            this.Sixbutton.Click += new System.EventHandler(this.Sixbutton_Click);
            // 
            // Fivebutton
            // 
            this.Fivebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fivebutton.Location = new System.Drawing.Point(105, 113);
            this.Fivebutton.Name = "Fivebutton";
            this.Fivebutton.Size = new System.Drawing.Size(96, 49);
            this.Fivebutton.TabIndex = 9;
            this.Fivebutton.Text = "5";
            this.Fivebutton.UseVisualStyleBackColor = true;
            this.Fivebutton.Click += new System.EventHandler(this.Fivebutton_Click);
            // 
            // Fourbutton
            // 
            this.Fourbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fourbutton.Location = new System.Drawing.Point(3, 113);
            this.Fourbutton.Name = "Fourbutton";
            this.Fourbutton.Size = new System.Drawing.Size(96, 49);
            this.Fourbutton.TabIndex = 8;
            this.Fourbutton.Text = "4";
            this.Fourbutton.UseVisualStyleBackColor = true;
            this.Fourbutton.Click += new System.EventHandler(this.Fourbutton_Click);
            // 
            // Multbutton
            // 
            this.Multbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multbutton.Location = new System.Drawing.Point(309, 58);
            this.Multbutton.Name = "Multbutton";
            this.Multbutton.Size = new System.Drawing.Size(99, 49);
            this.Multbutton.TabIndex = 7;
            this.Multbutton.Text = "*";
            this.Multbutton.UseVisualStyleBackColor = true;
            this.Multbutton.Click += new System.EventHandler(this.Multbutton_Click);
            // 
            // Ninebutton
            // 
            this.Ninebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ninebutton.Location = new System.Drawing.Point(207, 58);
            this.Ninebutton.Name = "Ninebutton";
            this.Ninebutton.Size = new System.Drawing.Size(96, 49);
            this.Ninebutton.TabIndex = 6;
            this.Ninebutton.Text = "9";
            this.Ninebutton.UseVisualStyleBackColor = true;
            this.Ninebutton.Click += new System.EventHandler(this.Ninebutton_Click);
            // 
            // Eightbutton
            // 
            this.Eightbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eightbutton.Location = new System.Drawing.Point(105, 58);
            this.Eightbutton.Name = "Eightbutton";
            this.Eightbutton.Size = new System.Drawing.Size(96, 49);
            this.Eightbutton.TabIndex = 5;
            this.Eightbutton.Text = "8";
            this.Eightbutton.UseVisualStyleBackColor = true;
            this.Eightbutton.Click += new System.EventHandler(this.Eightbutton_Click);
            // 
            // Sevbutton
            // 
            this.Sevbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sevbutton.Location = new System.Drawing.Point(3, 58);
            this.Sevbutton.Name = "Sevbutton";
            this.Sevbutton.Size = new System.Drawing.Size(96, 49);
            this.Sevbutton.TabIndex = 4;
            this.Sevbutton.Text = "7";
            this.Sevbutton.UseVisualStyleBackColor = true;
            this.Sevbutton.Click += new System.EventHandler(this.Sevbutton_Click);
            // 
            // CEbutton
            // 
            this.CEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(96, 49);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delbutton.Location = new System.Drawing.Point(207, 3);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(96, 49);
            this.Delbutton.TabIndex = 2;
            this.Delbutton.Text = "Del";
            this.Delbutton.UseVisualStyleBackColor = true;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // Divbutton
            // 
            this.Divbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divbutton.Location = new System.Drawing.Point(309, 3);
            this.Divbutton.Name = "Divbutton";
            this.Divbutton.Size = new System.Drawing.Size(99, 49);
            this.Divbutton.TabIndex = 3;
            this.Divbutton.Text = "/";
            this.Divbutton.UseVisualStyleBackColor = true;
            this.Divbutton.Click += new System.EventHandler(this.Divbutton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Equalbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(435, 374);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Rae\'s Calculator";
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.Button Fivebutton;
        private System.Windows.Forms.Button Fourbutton;
        private System.Windows.Forms.Button Multbutton;
        private System.Windows.Forms.Button Ninebutton;
        private System.Windows.Forms.Button Eightbutton;
        private System.Windows.Forms.Button Sevbutton;
        private System.Windows.Forms.Button Divbutton;
        private System.Windows.Forms.Button Onebutton;
        private System.Windows.Forms.Button Minusbutton;
        private System.Windows.Forms.Button Sixbutton;
        private System.Windows.Forms.Button Twobutton;
        private System.Windows.Forms.Button Equalbutton;
        private System.Windows.Forms.Button Dotbutton;
        private System.Windows.Forms.Button Zerobutton;
        private System.Windows.Forms.Button Plusbutton;
        private System.Windows.Forms.Button Threebutton;
    }
}

