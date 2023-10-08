namespace CGPA_Calculator_Lab_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.course_lebel = new System.Windows.Forms.Label();
            this.cgpa_lebel = new System.Windows.Forms.Label();
            this.mid_lebel = new System.Windows.Forms.Label();
            this.final_lebel = new System.Windows.Forms.Label();
            this.qz_1_lebel = new System.Windows.Forms.Label();
            this.qz_2_lebel = new System.Windows.Forms.Label();
            this.qz_3_lebel = new System.Windows.Forms.Label();
            this.qz_4_lebel = new System.Windows.Forms.Label();
            this.Att_lebel = new System.Windows.Forms.Label();
            this.course_comboBox = new System.Windows.Forms.ComboBox();
            this.mid_textBox1 = new System.Windows.Forms.TextBox();
            this.final_textBox1 = new System.Windows.Forms.TextBox();
            this.qz_1_textBox = new System.Windows.Forms.TextBox();
            this.qz_2_textBox = new System.Windows.Forms.TextBox();
            this.qz_3_textBox = new System.Windows.Forms.TextBox();
            this.qz_4_textBox = new System.Windows.Forms.TextBox();
            this.att_textBox1 = new System.Windows.Forms.TextBox();
            this.Result_listbox = new System.Windows.Forms.ListBox();
            this.add_button1 = new System.Windows.Forms.Button();
            this.calculate_button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // course_lebel
            // 
            this.course_lebel.AutoSize = true;
            this.course_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.course_lebel.Location = new System.Drawing.Point(102, 109);
            this.course_lebel.Name = "course_lebel";
            this.course_lebel.Size = new System.Drawing.Size(111, 32);
            this.course_lebel.TabIndex = 1;
            this.course_lebel.Text = "Course";
            this.course_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cgpa_lebel
            // 
            this.cgpa_lebel.AutoSize = true;
            this.cgpa_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cgpa_lebel.Location = new System.Drawing.Point(656, 434);
            this.cgpa_lebel.Name = "cgpa_lebel";
            this.cgpa_lebel.Size = new System.Drawing.Size(115, 32);
            this.cgpa_lebel.TabIndex = 1;
            this.cgpa_lebel.Text = "CGPA: ";
            this.cgpa_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mid_lebel
            // 
            this.mid_lebel.AutoSize = true;
            this.mid_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mid_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mid_lebel.Location = new System.Drawing.Point(66, 149);
            this.mid_lebel.Name = "mid_lebel";
            this.mid_lebel.Size = new System.Drawing.Size(147, 32);
            this.mid_lebel.TabIndex = 1;
            this.mid_lebel.Text = "Mid Exam";
            this.mid_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // final_lebel
            // 
            this.final_lebel.AutoSize = true;
            this.final_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.final_lebel.Location = new System.Drawing.Point(47, 189);
            this.final_lebel.Name = "final_lebel";
            this.final_lebel.Size = new System.Drawing.Size(166, 32);
            this.final_lebel.TabIndex = 1;
            this.final_lebel.Text = "Final Exam";
            this.final_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // qz_1_lebel
            // 
            this.qz_1_lebel.AutoSize = true;
            this.qz_1_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_1_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.qz_1_lebel.Location = new System.Drawing.Point(44, 229);
            this.qz_1_lebel.Name = "qz_1_lebel";
            this.qz_1_lebel.Size = new System.Drawing.Size(169, 32);
            this.qz_1_lebel.TabIndex = 1;
            this.qz_1_lebel.Text = "Quiz Test 1";
            this.qz_1_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // qz_2_lebel
            // 
            this.qz_2_lebel.AutoSize = true;
            this.qz_2_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_2_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.qz_2_lebel.Location = new System.Drawing.Point(44, 269);
            this.qz_2_lebel.Name = "qz_2_lebel";
            this.qz_2_lebel.Size = new System.Drawing.Size(169, 32);
            this.qz_2_lebel.TabIndex = 1;
            this.qz_2_lebel.Text = "Quiz Test 2";
            this.qz_2_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // qz_3_lebel
            // 
            this.qz_3_lebel.AutoSize = true;
            this.qz_3_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_3_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.qz_3_lebel.Location = new System.Drawing.Point(44, 309);
            this.qz_3_lebel.Name = "qz_3_lebel";
            this.qz_3_lebel.Size = new System.Drawing.Size(169, 32);
            this.qz_3_lebel.TabIndex = 1;
            this.qz_3_lebel.Text = "Quiz Test 3";
            this.qz_3_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // qz_4_lebel
            // 
            this.qz_4_lebel.AutoSize = true;
            this.qz_4_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_4_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.qz_4_lebel.Location = new System.Drawing.Point(44, 349);
            this.qz_4_lebel.Name = "qz_4_lebel";
            this.qz_4_lebel.Size = new System.Drawing.Size(169, 32);
            this.qz_4_lebel.TabIndex = 1;
            this.qz_4_lebel.Text = "Quiz Test 4";
            this.qz_4_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Att_lebel
            // 
            this.Att_lebel.AutoSize = true;
            this.Att_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Att_lebel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Att_lebel.Location = new System.Drawing.Point(44, 391);
            this.Att_lebel.Name = "Att_lebel";
            this.Att_lebel.Size = new System.Drawing.Size(169, 32);
            this.Att_lebel.TabIndex = 1;
            this.Att_lebel.Text = "Attendance";
            this.Att_lebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // course_comboBox
            // 
            this.course_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_comboBox.FormattingEnabled = true;
            this.course_comboBox.Items.AddRange(new object[] {
            "MAT3131",
            "CSE3122",
            "CSE3133",
            "CSE3134",
            "CSE31P5",
            "CSE3136",
            "CSE31P7",
            "CSE31P8",
            "CSE31P9"});
            this.course_comboBox.Location = new System.Drawing.Point(231, 104);
            this.course_comboBox.Name = "course_comboBox";
            this.course_comboBox.Size = new System.Drawing.Size(177, 37);
            this.course_comboBox.TabIndex = 3;
            this.course_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mid_textBox1
            // 
            this.mid_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mid_textBox1.Location = new System.Drawing.Point(231, 147);
            this.mid_textBox1.Name = "mid_textBox1";
            this.mid_textBox1.Size = new System.Drawing.Size(177, 34);
            this.mid_textBox1.TabIndex = 4;
            this.mid_textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // final_textBox1
            // 
            this.final_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_textBox1.Location = new System.Drawing.Point(231, 187);
            this.final_textBox1.Name = "final_textBox1";
            this.final_textBox1.Size = new System.Drawing.Size(177, 34);
            this.final_textBox1.TabIndex = 4;
            // 
            // qz_1_textBox
            // 
            this.qz_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_1_textBox.Location = new System.Drawing.Point(231, 227);
            this.qz_1_textBox.Name = "qz_1_textBox";
            this.qz_1_textBox.Size = new System.Drawing.Size(177, 34);
            this.qz_1_textBox.TabIndex = 4;
            // 
            // qz_2_textBox
            // 
            this.qz_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_2_textBox.Location = new System.Drawing.Point(231, 267);
            this.qz_2_textBox.Name = "qz_2_textBox";
            this.qz_2_textBox.Size = new System.Drawing.Size(177, 34);
            this.qz_2_textBox.TabIndex = 4;
            // 
            // qz_3_textBox
            // 
            this.qz_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_3_textBox.Location = new System.Drawing.Point(231, 307);
            this.qz_3_textBox.Name = "qz_3_textBox";
            this.qz_3_textBox.Size = new System.Drawing.Size(177, 34);
            this.qz_3_textBox.TabIndex = 4;
            // 
            // qz_4_textBox
            // 
            this.qz_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qz_4_textBox.Location = new System.Drawing.Point(231, 347);
            this.qz_4_textBox.Name = "qz_4_textBox";
            this.qz_4_textBox.Size = new System.Drawing.Size(177, 34);
            this.qz_4_textBox.TabIndex = 4;
            // 
            // att_textBox1
            // 
            this.att_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_textBox1.Location = new System.Drawing.Point(231, 387);
            this.att_textBox1.Name = "att_textBox1";
            this.att_textBox1.Size = new System.Drawing.Size(177, 34);
            this.att_textBox1.TabIndex = 4;
            // 
            // Result_listbox
            // 
            this.Result_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_listbox.FormattingEnabled = true;
            this.Result_listbox.ItemHeight = 29;
            this.Result_listbox.Location = new System.Drawing.Point(477, 115);
            this.Result_listbox.Name = "Result_listbox";
            this.Result_listbox.Size = new System.Drawing.Size(569, 294);
            this.Result_listbox.TabIndex = 5;
            // 
            // add_button1
            // 
            this.add_button1.AllowDrop = true;
            this.add_button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.add_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button1.Location = new System.Drawing.Point(283, 569);
            this.add_button1.Name = "add_button1";
            this.add_button1.Size = new System.Drawing.Size(125, 54);
            this.add_button1.TabIndex = 6;
            this.add_button1.Text = "Add";
            this.add_button1.UseVisualStyleBackColor = false;
            this.add_button1.Click += new System.EventHandler(this.add_button1_Click);
            // 
            // calculate_button2
            // 
            this.calculate_button2.AllowDrop = true;
            this.calculate_button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.calculate_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculate_button2.Location = new System.Drawing.Point(477, 569);
            this.calculate_button2.Name = "calculate_button2";
            this.calculate_button2.Size = new System.Drawing.Size(157, 54);
            this.calculate_button2.TabIndex = 6;
            this.calculate_button2.Text = "Calculate";
            this.calculate_button2.UseVisualStyleBackColor = false;
            this.calculate_button2.Click += new System.EventHandler(this.calculate_button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 747);
            this.Controls.Add(this.calculate_button2);
            this.Controls.Add(this.add_button1);
            this.Controls.Add(this.Result_listbox);
            this.Controls.Add(this.att_textBox1);
            this.Controls.Add(this.qz_4_textBox);
            this.Controls.Add(this.qz_3_textBox);
            this.Controls.Add(this.qz_2_textBox);
            this.Controls.Add(this.qz_1_textBox);
            this.Controls.Add(this.final_textBox1);
            this.Controls.Add(this.mid_textBox1);
            this.Controls.Add(this.course_comboBox);
            this.Controls.Add(this.Att_lebel);
            this.Controls.Add(this.qz_4_lebel);
            this.Controls.Add(this.qz_3_lebel);
            this.Controls.Add(this.qz_2_lebel);
            this.Controls.Add(this.qz_1_lebel);
            this.Controls.Add(this.final_lebel);
            this.Controls.Add(this.mid_lebel);
            this.Controls.Add(this.cgpa_lebel);
            this.Controls.Add(this.course_lebel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cgpa_Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label course_lebel;
        private System.Windows.Forms.Label cgpa_lebel;
        private System.Windows.Forms.Label mid_lebel;
        private System.Windows.Forms.Label final_lebel;
        private System.Windows.Forms.Label qz_1_lebel;
        private System.Windows.Forms.Label qz_2_lebel;
        private System.Windows.Forms.Label qz_3_lebel;
        private System.Windows.Forms.Label qz_4_lebel;
        private System.Windows.Forms.Label Att_lebel;
        private System.Windows.Forms.ComboBox course_comboBox;
        private System.Windows.Forms.TextBox mid_textBox1;
        private System.Windows.Forms.TextBox final_textBox1;
        private System.Windows.Forms.TextBox qz_1_textBox;
        private System.Windows.Forms.TextBox qz_2_textBox;
        private System.Windows.Forms.TextBox qz_3_textBox;
        private System.Windows.Forms.TextBox qz_4_textBox;
        private System.Windows.Forms.TextBox att_textBox1;
        private System.Windows.Forms.ListBox Result_listbox;
        private System.Windows.Forms.Button add_button1;
        private System.Windows.Forms.Button calculate_button2;
    }
}

