using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Customer.Repository
{
    public class CustomerRepository
    {
        string connectionString = @"Server =DESKTOP-OVFETI4\SQLEXPRESS ; Database = CoffeShop; Integrated Security = True";

        public bool Add(string nameTextBox, string contactTextBox, string addressTextBox)
        {
            bool isAdded = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = "INSERT INTO Customer (Name, Contact, Address) VALUES('" + nameTextBox + "', '" + contactTextBox + "', '" + addressTextBox + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();

                if (isExecute > 0)
                {
                    isAdded = true;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                // MessageBox.Show(excp.Message);
            }

            return isAdded;
        }

        public bool Delete(string nameTextBox)
        {
            bool isDelete = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = "DELETE FROM Customer WHERE Name = '" + nameTextBox + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();

                if (isExecute > 0)
                {
                    isDelete = true;
                }
                sqlConnection.Close();
            }
            catch (Exception excp)
            {

                // MessageBox.Show(excp.Message);
            }

            return isDelete;
        }


        public bool IsNameExist(string nameTextBox)
        {
            bool isExist = false;




            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Name,Contact,Address FROM Customer WHERE Name = '" + nameTextBox + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (isFill > 0)
            {
                isExist = true;
            }





            return isExist;
        }
        public DataTable ShowData()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Name, Contact, Address FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            //if (isFill > 0)
            //{
            //    dataGridView.DataSource = dataTable;
            //    return 1;
            //}
            //else
            //{
            //    dataGridView.DataSource = "";
            //    return 0;
            //}
            sqlConnection.Close();

            return dataTable;

        }









    }
}
