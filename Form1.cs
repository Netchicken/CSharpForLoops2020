using System;
using System.Windows.Forms;

namespace CSharpForLoops2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //For Loop
        private void btnGo_Click(object sender, EventArgs e)
        {
            Single Number = Convert.ToSingle(txtNumber.Text);
            Single UpperLimit = Convert.ToSingle(txtUpperLimit.Text);


            // start     finish      step
            for (int i = 0; i < UpperLimit; i++)
            {
                Single Answer = i * Number;

                if (i % 5 == 0)
                {

                    lbxLoop.Items.Add("Fizz");
                }
                if (i % 3 == 0)
                {

                    lbxLoop.Items.Add("Buzz");
                }
                if ((i % 3 == 0) && (i % 5 == 0))
                {

                    lbxLoop.Items.Add("FizzBuzz");
                }
                lbxLoop.Items.Add(i + " X " + Number + " = " + Answer);
            }

        }

        private void btnGoForEach_Click(object sender, EventArgs e)
        {
            //Array 
            string[] students = { "Tyler", "Vaughn", "Lyle", "Jacob", "Reuben", "Femi", "Jack" };

            foreach (var student in students)
            {

                if (student == "Tyler")
                {
                    lbxLoop.Items.Add(student + " needs a new chair");
                }

                if (student == "Jacob" || student == "Femi")
                {
                    lbxLoop.Items.Add(student + " has a unhealthy relationship with fast food");
                }

                if (student.Contains("b"))
                {
                    lbxLoop.Items.Add(student + " Is a great programmer");
                }

                lbxLoop.Items.Add(student);
            }




        }
    }
}
