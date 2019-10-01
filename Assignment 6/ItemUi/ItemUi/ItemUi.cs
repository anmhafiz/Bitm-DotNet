using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemUi
{
    public partial class ItemUi : Form



    {

        string connectionString = @"Server = DESKTOP-OVFETI4\SQLEXPRESS; Database = CoffeShop; Integrated Security = true";
        public ItemUi()
        {
            InitializeComponent();
        }


       

        private void Clear()
        {
            
            nameTextBox.Text = "";
            priceTextBox.Clear();

        }


        private int SelectCustomerName()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Name FROM Items WHERE Name = '" + nameTextBox.Text + "'";
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
            string commandString = @"SELECT Name,Price FROM Items";
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

            if (nameTextBox.Text == "" || nameTextBox.Text == "" || priceTextBox.Text == "")
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

            //    try
            //    {


            //        string connectionString = @"Server = DESKTOP-KMRIBC2\SQLEXPRESS; Database = CoffeShop; Integrated Security = True";
            //    SqlConnection sqlConnection = new SqlConnection(connectionString);

            //    string commandString = @"INSERT INTO Items (CustomerName, Price) Values ( '" + nameTextBox.Text + "', " + priceTextBox.Text + " )";
            //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //    sqlConnection.Open();
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}

            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = "INSERT INTO Items(Name, Price) VALUES('" + nameTextBox.Text + "', " +priceTextBox.Text+ " )";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();
                if (isExecute > 0)
                {
                    if (ShowData() == 1)
                    {
                        MessageBox.Show("Saved Successfully");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Not Saved Data, Check Inserting Details");
                }
                sqlConnection.Close();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }




        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            nameTextBox.Text = dataGridView[1, e.RowIndex].Value.ToString();
            priceTextBox.Text = dataGridView[2, e.RowIndex].Value.ToString();
        }
    }













   
    }







