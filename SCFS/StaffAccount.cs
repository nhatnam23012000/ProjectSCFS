using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class StaffAccount : Account
    {
        private int id;
        public StaffAccount(String userName, String passWord, Authorization authorizarion, int id) : base(userName, passWord, authorizarion)
        {
            this.id = id;
        }
        public StaffAccount() : base()
        {
            this.id = 0;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public int getID()
        {
            return id;
        }
    }
}
