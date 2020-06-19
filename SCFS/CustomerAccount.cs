using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class CustomerAccount : Account
    {
        public CustomerAccount(String userName, String passWord) : base(userName, passWord, Authorization.CUSTOMER) { }
        public CustomerAccount() : base() { }
    }
}
