namespace LAB4Encapsulation
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbyear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbListofPerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNamemax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNamemin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGPmin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGPavg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGPA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbGPmax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(103, 99);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(151, 31);
            this.tbname.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbyear
            // 
            this.tbyear.Location = new System.Drawing.Point(103, 138);
            this.tbyear.Name = "tbyear";
            this.tbyear.Size = new System.Drawing.Size(151, 31);
            this.tbyear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brithyear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "All Age";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(121, 159);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(136, 31);
            this.tbTotal.TabIndex = 5;
            this.tbTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "All Name";
            // 
            // tbListofPerson
            // 
            this.tbListofPerson.Location = new System.Drawing.Point(121, 198);
            this.tbListofPerson.Multiline = true;
            this.tbListofPerson.Name = "tbListofPerson";
            this.tbListofPerson.Size = new System.Drawing.Size(136, 92);
            this.tbListofPerson.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // tbNamemax
            // 
            this.tbNamemax.Location = new System.Drawing.Point(333, 46);
            this.tbNamemax.Name = "tbNamemax";
            this.tbNamemax.Size = new System.Drawing.Size(136, 31);
            this.tbNamemax.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name";
            // 
            // tbNamemin
            // 
            this.tbNamemin.Location = new System.Drawing.Point(333, 85);
            this.tbNamemin.Name = "tbNamemin";
            this.tbNamemin.Size = new System.Drawing.Size(136, 31);
            this.tbNamemin.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "GPA Min";
            // 
            // tbGPmin
            // 
            this.tbGPmin.Location = new System.Drawing.Point(121, 85);
            this.tbGPmin.Name = "tbGPmin";
            this.tbGPmin.Size = new System.Drawing.Size(136, 31);
            this.tbGPmin.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "GPA Avg";
            // 
            // tbGPavg
            // 
            this.tbGPavg.Location = new System.Drawing.Point(121, 122);
            this.tbGPavg.Name = "tbGPavg";
            this.tbGPavg.Size = new System.Drawing.Size(136, 31);
            this.tbGPavg.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "GPA";
            // 
            // tbGPA
            // 
            this.tbGPA.Location = new System.Drawing.Point(103, 175);
            this.tbGPA.Name = "tbGPA";
            this.tbGPA.Size = new System.Drawing.Size(151, 31);
            this.tbGPA.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "GPA Max";
            // 
            // tbGPmax
            // 
            this.tbGPmax.Location = new System.Drawing.Point(121, 46);
            this.tbGPmax.Name = "tbGPmax";
            this.tbGPmax.Size = new System.Drawing.Size(136, 31);
            this.tbGPmax.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.tbGPmax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNamemin);
            this.groupBox1.Controls.Add(this.tbListofPerson);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNamemax);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbGPmin);
            this.groupBox1.Controls.Add(this.tbGPavg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(295, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 316);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายวิชา";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbGPA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbyear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbname;
        private Button button1;
        private TextBox tbyear;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbTotal;
        private Label label4;
        private TextBox tbListofPerson;
        private Label label5;
        private TextBox tbNamemax;
        private Label label6;
        private TextBox tbNamemin;
        private Label label7;
        private TextBox tbGPmin;
        private Label label8;
        private TextBox tbGPavg;
        private Label label9;
        private TextBox tbGPA;
        private Label label10;
        private TextBox tbGPmax;
        private GroupBox groupBox1;
    }
}