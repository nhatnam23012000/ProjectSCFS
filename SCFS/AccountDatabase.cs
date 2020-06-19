using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class AccountDatabase
    {
        private LinkedList<Account> accounts;
        private int count;
        public AccountDatabase()
        {
            this.accounts = new LinkedList<Account>();
            this.count = 0;
        }
        public bool addStaffAccount(String name, String pass, Authorization authorization, int id)
        {
            for (int i = 0; i < accounts.Count(); i++)
            {
                if (accounts.ElementAt<Account>(i).getName() == name) return false;
            }
            Account newAccount = new StaffAccount(name, pass, authorization, id);
            accounts.AddLast(newAccount);
            count++;
            return true;
        }
        public bool addCustomerAccount(String name, String pass)
        {
            for (int i = 0; i < accounts.Count(); i++)
            {
                if (accounts.ElementAt<Account>(i).getName() == name) return false;
            }
            Account newAccount = new CustomerAccount(name, pass);
            accounts.AddLast(newAccount);
            count++;
            return true;
        }
        public bool checkInfo(String name, String pass)
        {
            for (int i = 0; i < accounts.Count(); i++)
            {
                Account checkingAccount = accounts.ElementAt<Account>(i);
                if (checkingAccount.getName() == name && checkingAccount.getPassword() == pass) return true;
            }
            return false;
        }
        public bool checkAuthorization(int id)
        {
            for (int i = 0; i < accounts.Count(); i++)
            {
                Account otherAccount = accounts.ElementAt<Account>(i);
                if (otherAccount.GetType() == typeof(StaffAccount))
                {
                    StaffAccount account = (StaffAccount)otherAccount;
                    if (account.getID() == id && account.getAuthorization() == Authorization.MASTERITSTAFF) return true;
                }
            }
            return false;
        }
        public Authorization getAuthorization(String name)
        {
            for (int i = 0; i < accounts.Count(); i++)
            {
                if (accounts.ElementAt<Account>(i).getName() == name) return accounts.ElementAt<Account>(i).getAuthorization();
            }
            return Authorization.CUSTOMER;
        }
        public int getCount()
        {
            return count;
        }
        public Account getAccount(String name)
        {
            for (int i = 0; i < accounts.Count(); i++)
            {
                if (accounts.ElementAt<Account>(i).getName() == name) return accounts.ElementAt<Account>(i);
            }
            return null;
        }
        public Account getAccount(int i)
        {
            return accounts.ElementAt<Account>(i);
        }
    }
}
