using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPA_Calculator_Lab_2
{
    public partial class Form1 : Form
    {
        //list define
        List<string> codesArray = new List<string>();
        List<int> totalArray = new List<int>();
        List<double> gpaArray = new List<double>();
        List<string> gradesArray = new List<string>();    
        public Form1()
        {
            InitializeComponent();
            Result_listbox.Items.Add("Course \t\t Total \t GPA \t Grade");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_button2_Click(object sender, EventArgs e)
        {
            //Array show in box using loop
            for (int i = 0; i<gpaArray.Count; i++)
            {
                string res = $"{codesArray[i]}\t {totalArray[i]}\t {gpaArray[i]}\t {gradesArray[i]}";

                //adding in listbox
                Result_listbox.Items.Add(res);
            }

            //cgpa calculate
            double sum = 0;
            for(int j = 0; j<gpaArray.Count; j++)
            {
                sum = sum + gpaArray[j];
            }
            double cgpa= sum/gpaArray.Count;

            //Showing the cgpa result
            string cgpa1 = Convert.ToString(cgpa);

            cgpa_lebel.Text = $"cgpa : {cgpa1}";


        }

        private void add_button1_Click(object sender, EventArgs e)
        {
            string code = course_comboBox.Text;
            codesArray.Add(code);

            int Mid  = Convert.ToInt32(mid_textBox1.Text)/3;
            int Final  = Convert.ToInt32(final_textBox1.Text);
            int Att = Convert.ToInt32(att_textBox1.Text);
            int quiz1 = Convert.ToInt32(qz_1_textBox.Text);
            int quiz2 = Convert.ToInt32(qz_2_textBox.Text);
            int quiz3 = Convert.ToInt32(qz_3_textBox.Text);
            int quiz4 = Convert.ToInt32(qz_4_textBox.Text);
            

            //array 
            int[] qz = new int[4];
            qz[0] = quiz1;
            qz[1] = quiz2;
            qz[2] = quiz3;
            qz[3] = quiz4;

            //Array sort
            Array.Sort(qz);

            //total quiz value
            int quiz = (qz[1] + qz[2] + qz[3])/3;

            //total
            int total = Mid + Final + Att + quiz;
            Result_listbox.Text = total.ToString();

            //total mark add
            totalArray.Add(total);


            //calculate
            string grade ="a";
            double gpa = 0.0;

            //branching (if/else)
            if (total >= 80)
            {
                grade = "A+";
                gpa = 4.00;
            } else if (total >= 75 && total<80)
            {
                grade = "A";
                gpa = 3.75;
            }
            else if (total >= 70 && total < 75)
            {
                grade = "A-";
                gpa = 3.50;
            }
            else if (total >= 65 && total < 70)
            {
                grade = "B+";
                gpa = 3.25;
            }
            else if (total >= 60 && total < 65)
            {
                grade = "B";
                gpa = 3.00;
            }
            else if (total >= 55 && total < 60)
            {
                grade = "B-";
                gpa = 2.75;
            }
            else if (total >= 50 && total < 55)
            {
                grade = "C+";
                gpa = 2.50;
            }
            else if (total >= 45 && total < 50)
            {
                grade = "C";
                gpa = 2.25;
            }
            else if (total >= 40&& total < 45)
            {
                grade = "D";
                gpa = 2.00;
            }
            else 
            {
                grade = "F";
                gpa = 0;
            }


            //Add in gpa and grade
            gpaArray.Add(gpa);
            gradesArray.Add(grade);


            //messege show
            MessageBox.Show("Added Successfully. Add Next Course. Calculate After Adding Last Course");
            
            //auto clear
            mid_textBox1.Clear();
            final_textBox1.Clear();
            att_textBox1.Clear();
            qz_1_textBox.Clear();
            qz_2_textBox.Clear();
            qz_3_textBox.Clear();
            qz_4_textBox.Clear();

        }
    }
}
