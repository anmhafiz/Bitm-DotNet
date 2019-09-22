using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class StudentInfoApp : Form
    {
        List<string> studentId = new List<string>();
        List<string> studentName = new List<string>();
        List<string> studentMobile = new List<string>();
        List<string> studentAge = new List<string>();
        List<string> studentAddress = new List<string>();
        List<string> studentGpa = new List<string>();

        string id = "";
        string name = "";
        string mobile = "";
        string age = "";
        string address = "";
        string gpa = "";
        string max = "";
        string min = "";

        string maxName = "";
        string minName = "";
        double total = 0;

        double avg;

        int mobileLength, idLength, nameLength, gpaLength;

        public StudentInfoApp()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            id = idTextBox.Text;
            name = nameTextBox.Text;
            mobile = mobileTextBox.Text;
            age = ageTextBox.Text;
            address = addressTextBox.Text;
            gpa = gpaTextBox.Text;

            idLength = id.Length;
            mobileLength = mobile.Length;
            nameLength = name.Length;
            gpaLength = gpa.Length;

            if (id == "")
            {
                MessageBox.Show("Id Field is required");
                idTextBox.Clear();
            }
            else if (!CheckIfNumeric(id))
            {
                MessageBox.Show("Id Field is required numeric value");
                idTextBox.Clear();
                return;
            }
            else if (idLength != 4)
            {
                MessageBox.Show("Id Field is required 4 chararcter length");
                idTextBox.Clear();
                return;
            }
            else if (studentName.Count > 1)
            {
                for (int i = 0; i < studentName.Count; i++)
                {
                    if (id == studentId[i])
                    {
                        MessageBox.Show("Already Used this Id.Please Enter New Id");
                        idTextBox.Clear();
                        return;
                    }
                }
            }
            else if (name == "")
            {
                MessageBox.Show("Name Field is required");
                nameTextBox.Clear();
                return;
            }
            else if (nameLength > 30)
            {
                MessageBox.Show("Name Field is required within 30 chararcter length");
                nameTextBox.Clear();
                return;
            }
            else if (mobile == "")
            {
                MessageBox.Show("Mobile Field is required");
                mobileTextBox.Clear();
                return;
            }
            else if (mobileLength != 11)
            {
                MessageBox.Show("Mobile Number Field is required 11 chararcter length");
                mobileTextBox.Clear();
                return;
            }
            else if (studentName.Count > 1)
            {
                for (int i = 0; i < studentName.Count; i++)
                {
                    if (mobile == studentMobile[i])
                    {
                        MessageBox.Show("Already Used this Phone number.Please Enter New Phone number.");
                        idTextBox.Clear();
                        return;
                    }
                }
            }
            else if (gpaLength > 4)
            {
                MessageBox.Show("GPA Value range required 0-4 number");
                mobileTextBox.Clear();
                return;
            }

            //AddToList();
            studentId.Add(id);
            studentName.Add(name);
            studentMobile.Add(mobile);
            studentAge.Add(age);
            studentAddress.Add(address);
            studentGpa.Add(gpa);

            string msg = "";
            msg = "Id:  " + id + "\nName:  " + name + "\nMobile:  " + mobile + "\nAge: "
                + age + "\nAddress:   " + address + "\nGPA Pont:  " + gpa;
            showRichTextBox.Text = msg;
            MessageBox.Show("Student Added Successfully..");
            Clear();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (idRadioButton.Checked)
            {
                for (int i = 0; i < studentName.Count; i++)
                {
                    if (idTextBox.Text == studentId[i])
                    {
                        string msg = "Name: " + studentName[i] + "\nMobile:  " + studentMobile[i] +
                        "\nAddress:  " + studentAddress[i] + "\nAge:  " + studentAge[i] +
                        "\nGPA:  " + studentGpa[i];
                        showRichTextBox.Text = msg;
                    }
                    else
                    {
                        MessageBox.Show("Sorry! Not Found this ID..");
                        return;
                    }
                }

                //int index = studentId.IndexOf(id);
                //if (id == studentId[index])
                //{
                //    string msg = "Name: " + studentName[index] + " Mobile:  " + studentMobile[index] +
                //        "  Address:  " + studentAddress[index] + "  Age:  " + studentAge[index] +
                //        "   GPA:  " + studentGpa[index];
                //    showRichTextBox.Text = msg;
                //}
                //else
                //{
                //    MessageBox.Show("Sorry! Not Found this ID..");
                //    return;
                //}
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            max = studentGpa.Max();
            min = studentGpa.Min();
            int noOfStudent = studentName.Count;

            if (studentName.Count > 1)
            {
                for (int i = 0; i < studentName.Count; i++)
                {
                    total += Convert.ToDouble(studentGpa[i]);

                    if (max == studentGpa[i])
                    {
                        maxName = studentName[i];
                    }

                    if (min == studentGpa[i])
                    {
                        minName = studentName[i];
                    }
                }

                avg = total / noOfStudent;
            }

            string msg1 = "";
            msg1 = "Max GPA:  " + max + "\nName:  " + maxName+ 
                "\n\nMin GPA:  " + min + "\nName:  " + minName+
                 "\n\nTotal:  " + total + "\nAverage:  " + avg;

            showRichTextBox.Text = msg1;
        }

        //private void AddToList()
        //{
        //    studentId.Add(id);
        //    studentName.Add(name);
        //    studentMobile.Add(mobile);
        //    studentAge.Add(age);
        //    studentAddress.Add(address);
        //    studentGpa.Add(gpa);
        //}

        private bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }

        private void Clear()
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            mobileTextBox.Clear();
            ageTextBox.Clear();
            addressTextBox.Clear();
            gpaTextBox.Clear();
        }
    }

    public static class StringExtensions
    {
        public static bool IsNumeric(this string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
    }
}
