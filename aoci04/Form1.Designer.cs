namespace aoci04
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageBox1.Location = new System.Drawing.Point(1, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 480);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageBox2.Location = new System.Drawing.Point(728, 12);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(640, 480);
            this.imageBox2.TabIndex = 4;
            this.imageBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1257, 661);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "circles";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(774, 656);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "tri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(771, 587);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "rect";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(967, 498);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(268, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(967, 535);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(268, 45);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Value = 1;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(967, 587);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(268, 45);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.Value = 1;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(967, 639);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Minimum = 1;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(268, 45);
            this.trackBar4.TabIndex = 11;
            this.trackBar4.Value = 1;
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(81, 542);
            this.trackBar5.Maximum = 200;
            this.trackBar5.Minimum = 10;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(272, 45);
            this.trackBar5.TabIndex = 12;
            this.trackBar5.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(919, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "min dist";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(919, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "porog";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(919, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "min rad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(919, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "max rad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "porog";
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(497, 634);
            this.trackBar6.Maximum = 100;
            this.trackBar6.Minimum = 1;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(271, 45);
            this.trackBar6.TabIndex = 18;
            this.trackBar6.Value = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "minmax";
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(494, 503);
            this.trackBar7.Minimum = 1;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(271, 45);
            this.trackBar7.TabIndex = 20;
            this.trackBar7.Value = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "delta";
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(494, 554);
            this.trackBar8.Maximum = 100;
            this.trackBar8.Minimum = 1;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(271, 45);
            this.trackBar8.TabIndex = 22;
            this.trackBar8.Value = 1;
            // 
            // trackBar9
            // 
            this.trackBar9.Location = new System.Drawing.Point(81, 503);
            this.trackBar9.Maximum = 5;
            this.trackBar9.Minimum = 1;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(271, 45);
            this.trackBar9.TabIndex = 23;
            this.trackBar9.Value = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "minmax";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(196, 616);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "canny";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "rad razm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 664);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 664);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar9);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}

