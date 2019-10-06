using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Customer.Repository;
namespace Customer.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(string nameTextBox, string contactTextBox, string addressTextBox)
        {

            return _customerRepository.Add(nameTextBox,contactTextBox,addressTextBox );


        }

        public bool IsNameExist(string nameTextBox)
        {
            return _customerRepository.IsNameExist(nameTextBox);
        }
        public bool Delete(string nameTextBox )
        {
            return _customerRepository.Delete(nameTextBox);

        }

        public DataTable ShowData()
        {
            return _customerRepository.ShowData();

        }
        
    }
}
