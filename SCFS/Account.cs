using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public abstract class Account
    {
        protected String userName;
        protected String passWord;
        protected Authorization authorization;

        public Account()
        {
            this.userName = "";
            this.passWord = "";
            this.authorization = Authorization.ITSTAFF;
        }
        public Account(String userName, String passWord, Authorization authorizarion)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.authorization = authorizarion;
        }
        public void setName(String name)
        {
            this.userName = name;
        }
        public void setPassword(String pass)
        {
            this.passWord = pass;
        }
        public void setAuthorization(Authorization a)
        {
            this.authorization = a;
        }
        public String getName()
        {
            return userName;
        }
        public String getPassword()
        {
            return passWord;
        }
        public Authorization getAuthorization()
        {
            return authorization;
        }
    }
}
