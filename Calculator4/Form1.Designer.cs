namespace Calculator4
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
            this.lable_Show = new System.Windows.Forms.Label();
            this.textBox1_Display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable_Show
            // 
            this.lable_Show.AutoSize = true;
            this.lable_Show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lable_Show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable_Show.Location = new System.Drawing.Point(12, 55);
            this.lable_Show.Name = "lable_Show";
            this.lable_Show.Size = new System.Drawing.Size(17, 15);
            this.lable_Show.TabIndex = 0;
            this.lable_Show.Text = "__";
            // 
            // textBox1_Display
            // 
            this.textBox1_Display.Location = new System.Drawing.Point(12, 73);
            this.textBox1_Display.Name = "textBox1_Display";
            this.textBox1_Display.Size = new System.Drawing.Size(399, 23);
            this.textBox1_Display.TabIndex = 1;
            this.textBox1_Display.Text = "0";
            this.textBox1_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.operators_ClickEve);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "RESET";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(336, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 46);
            this.button6.TabIndex = 11;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(255, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 46);
            this.button7.TabIndex = 10;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.operators_ClickEve);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(174, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 46);
            this.button8.TabIndex = 9;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(93, 165);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 46);
            this.button9.TabIndex = 8;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 165);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 46);
            this.button10.TabIndex = 7;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(336, 217);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 98);
            this.button11.TabIndex = 16;
            this.button11.Text = "=";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(255, 217);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 46);
            this.button12.TabIndex = 15;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.operators_ClickEve);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(174, 217);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 46);
            this.button13.TabIndex = 14;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(93, 217);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 46);
            this.button14.TabIndex = 13;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 217);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 46);
            this.button15.TabIndex = 12;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(255, 269);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 46);
            this.button17.TabIndex = 20;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.operators_ClickEve);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(174, 269);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 46);
            this.button18.TabIndex = 19;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(12, 269);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(156, 46);
            this.button20.TabIndex = 17;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.buttons_Clickeve);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 359);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_Display);
            this.Controls.Add(this.lable_Show);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lable_Show;
        private TextBox textBox1_Display;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button17;
        private Button button18;
        private Button button20;
    }
}