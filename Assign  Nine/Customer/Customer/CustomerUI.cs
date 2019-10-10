using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer.BLL;
using Customer.Model;


namespace Customer
{
    public partial class CustomerUI : Form
    {
        CustomerManager _customerManager = new CustomerManager();

        string connectionString = @"Server =DESKTOP-OVFETI4\SQLEXPRESS ; Database = CoffeShop; Integrated Security = True";


        public CustomerUI()
        {
            InitializeComponent();
        }


        //private bool CheckIfNumeric(string input)
        //{
        //    return input.IsNumeric();
        //}

        public void Clear()
        {
            codeTextBox.Text = "";
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            districtComboBox.Text = "";
           

        }
        private int SelectCustomerName()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Name FROM Customer WHERE Name = '" + nameTextBox.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);


            if (isFill > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



      // public void Display()
        //{
        //    //SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    //string commandString = @"SELECT Name, Contact, Address FROM Customer";
        //    //SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    //DataTable dataTable = new DataTable();
        //    //int isFill = sqlDataAdapter.Fill(dataTable);

        //    //if (isFill > 0)
        //    //{
        //    //    dataGridView.DataSource = dataTable;
        //    //    return 1;
        //    //}
        //    //else
        //    //{
        //    //    dataGridView.DataSource = "";
        //    //    return 0;
        //    //}
        //    dataGridView.DataSource = _customerManager.ShowData();
           
        

       // }

        private void addButton_Click(object sender, EventArgs e)
        {
            Cus cus = new Cus();

            if (nameTextBox.Text == "" || contactTextBox.Text == "" || addressTextBox.Text == "")
            {
                MessageBox.Show("Field must not be emptay..");
                Clear();
                return;

            }



            if (Code.Text.Length > 4)
            {
                MessageBox.Show("Can Enter only Four Characters in this Textbox.", "Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Contact.Text.Length >11)
            {
                MessageBox.Show("Can Enter only Eleven Characters in this Textbox.", "Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (_customerManager.IsNameExist(cus))
            {
                MessageBox.Show(nameTextBox.Text + "Already Exits");
                Clear();
                return;

            }
           






                if (nameTextBox.Text == "" || contactTextBox.Text == "" || addressTextBox.Text == "")
            {
                MessageBox.Show("Field must not be emptay..");
                Clear();
                return;
                
            }


            cus.Code = codeTextBox.Text;
            cus.Name = nameTextBox.Text;
            cus.Contact = contactTextBox.Text;
            cus.Address = addressTextBox.Text;
            cus.District = districtComboBox.Text;


            if (_customerManager.Add(cus))
            {
                MessageBox.Show("Saved");
                dataGridView.DataSource = _customerManager.ShowData();
            }



            else
            {
                MessageBox.Show("Not Saved");
            }

            Clear();

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            codeTextBox.Text = dataGridView[0, e.RowIndex].Value.ToString();
            nameTextBox.Text = dataGridView[1, e.RowIndex].Value.ToString();
            addressTextBox.Text = dataGridView[2, e.RowIndex].Value.ToString();
            contactTextBox.Text = dataGridView[3, e.RowIndex].Value.ToString();
            districtComboBox.Text = dataGridView[4, e.RowIndex].Value.ToString();
            //id = Convert.ToInt32(showDataGridView[0, e.RowIndex].Value);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            

            
                
                dataGridView.DataSource = _customerManager.ShowData();

                return;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {


            Cus cus = new Cus();


            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter Name.");
                return;
            }

            cus.Code = codeTextBox.Text;
            cus.Name = nameTextBox.Text;
            cus.Contact = contactTextBox.Text;
            cus.Address = addressTextBox.Text;
            cus.District = districtComboBox.Text;

            try
            {

                if (_customerManager.Delete(cus))
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }

                Clear();

            }





            catch (Exception excp)
                {

                    MessageBox.Show(excp.Message);
                }



            }



        private void searchButton_Click(object sender, EventArgs e)
           
            
           

        {
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Field must not be empty..");
                return;
            }

            try
            {

                if (Search(codeTextBox.Text,nameTextBox.Text, contactTextBox.Text, addressTextBox.Text, districtComboBox.Text))
                {


                    MessageBox.Show("Found");
                }
                else
                {
                    MessageBox.Show("Not Found");
                }


            }

            catch (Exception excp)
            {

                MessageBox.Show(excp.Message);
            }



        }

        public bool Search(string codeTextBox,string nameTextBox, string contactTextBox, string addressTextBox, string comboTextBox)
        {
            bool isSearch = false;
            try
            {

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"SELECT Code,Name,Contact,Address, District FROM Customer WHERE Name = '" + searchTextBox.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                int isFill = sqlDataAdapter.Fill(dataTable);

                if (isFill > 0)
                {

                    dataGridView.DataSource = "";
                    dataGridView.DataSource = dataTable;
                    return true;
                }




            }
            catch (Exception excp)
            {

                MessageBox.Show(excp.Message);
            }

            return isSearch;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
           districtComboBox.DataSource =  _customerManager.cusCombo(); ;
        }
    }
}







