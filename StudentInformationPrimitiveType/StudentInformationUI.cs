using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentInformationPrimitiveType
{
    public partial class StudentInformationUI : Form
    {
        public StudentInformationUI()
        {
            InitializeComponent();
        }
      
        Student aStudent = new Student();
        //private string regNo;
        //private string firstName;
        //private string lastName;

        private void showButton_Click(object sender, EventArgs e)
        {
           
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            ClearStudentInformationFromTextBoxes();
            MessageBox.Show(aStudent.GetFullName() + @", your registration number is " + aStudent.regNo+ "\nYour code no is "+aStudent.GetCode("123"));
        }

        private void ClearStudentInformationFromTextBoxes()
        {
            regNoTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNo;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
          
            aStudent= new Student();
            //aStudent.regNo = "";
            //aStudent.firstName = "";
            //aStudent.lastName = "";
            ClearStudentInformationFromTextBoxes();
        }
    }
}
