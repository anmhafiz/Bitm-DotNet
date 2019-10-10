using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Customer.Repository;
using Customer.Model;

namespace Customer.BLL

{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(Cus cus)
        {

            return _customerRepository.Add(cus );


        }

        public bool IsNameExist(Cus cus)
        {
            return _customerRepository.IsNameExist(cus);
        }
        public bool Delete(Cus cus )
        {
            return _customerRepository.Delete(cus);

        }

        public DataTable ShowData()
        {
            return _customerRepository.ShowData();

        }

        public DataTable cusCombo()
        {
            return _customerRepository.cusCombo();

        }

    }
}
