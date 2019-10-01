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


namespace Customer
{
    public partial class CustomerUI : Form
    {
        string connectionString = @"Server =DESKTOP-OVFETI4\SQLEXPRESS ; Database = CoffeShop; Integrated Security = True";


        public CustomerUI()
        {
            InitializeComponent();
        }


        //private bool CheckIfNumeric(string input)
        //{
        //    return input.IsNumeric();
        //}

        private void Clear()
        {
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Clear();
           
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



        private int ShowData()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Name, Contact, Address FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (isFill > 0)
            {
                dataGridView.DataSource = dataTable;
                return 1;
            }
            else
            {
                dataGridView.DataSource = "";
                return 0;
            }


        }

            private void addButton_Click(object sender, EventArgs e)
        {
            Name = nameTextBox.Text;

            if (nameTextBox.Text == "" || contactTextBox.Text == "" || addressTextBox.Text == "" )
            {
                MessageBox.Show("Field must not be empty..");
                return;
            }

            if (SelectCustomerName() == 1)
            {
                MessageBox.Show("This Customer is Already exist..");
                nameTextBox.Text = "";
                return;
            }


            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = "INSERT INTO Customer (Name, Contact, Address) VALUES('" +nameTextBox.Text+ "', '" +contactTextBox.Text+ "', '" + addressTextBox.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();

                if (isExecute > 0)
                {
                    if (ShowData() == 1)
                    {
                     MessageBox.Show("Updated Successfully");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }
                sqlConnection.Close();
            }
            catch (Exception excp)
            {

                MessageBox.Show(excp.Message);
            }



        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            nameTextBox.Text = dataGridView[0, e.RowIndex].Value.ToString();
            contactTextBox.Text = dataGridView[1, e.RowIndex].Value.ToString();
            addressTextBox.Text = dataGridView[2, e.RowIndex].Value.ToString();
            
            //id = Convert.ToInt32(showDataGridView[0, e.RowIndex].Value);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (ShowData() == 0)
            {
                dataGridView.DataSource = "";
                MessageBox.Show("There is no available Customer");
            }



        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            
                if (searchTextBox.Text == "")
                {
                    MessageBox.Show("Please enter Name.");
                    return;
                }

                try
                {
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    string commandString = "DELETE FROM Customer WHERE Name = '" + searchTextBox.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();
                    int isExecute = sqlCommand.ExecuteNonQuery();

                    if (isExecute > 0)
                    {
                        if (ShowData() == 1 || ShowData() == 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                            return;
                        }
                    }
                    else
                    {
                        if (dataGridView.DataSource == "")
                        {
                            MessageBox.Show("There is no available data");
                            return;
                        }
                        MessageBox.Show("Please,,Select Correct ID");
                        return;
                    }
                    sqlConnection.Close();
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
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Name,Contact,Address FROM Customer WHERE Name = '" + searchTextBox.Text + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (isFill > 0)
            {
              dataGridView.DataSource = "";
               dataGridView.DataSource = dataTable;
            }
            else
            {
                if (dataGridView.DataSource == "")
                {
                    MessageBox.Show("There is no available data..");
                    return;
                    ;
                }
                MessageBox.Show("Sorry Not Found This Name..");
                return;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
