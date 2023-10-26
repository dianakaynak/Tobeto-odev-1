using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void UpDate();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");

        }

        public void UpDate()
        {
            Console.WriteLine("Sql updated");
            ;
        }
    }


    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void UpDate()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        
        {
            customerDal.Add();
        }
    }
}


