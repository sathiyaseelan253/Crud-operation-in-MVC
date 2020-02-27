using System.Collections.Generic;

namespace Account.Entity
{
    public class accountRepository
    {
        public static List<Accounts> listOfIds = new List<Accounts>();
        static int flag = 0;
        static accountRepository()
        {
            listOfIds.Add(new Accounts
            {
                Name = "sathyaseelan",
                Password = "123",
                City = "karur",
                Qualification = "B.E",
                ContactNo = "8072117799",
                Email = "sathyaseelan253@gmail.com",
                Gender = "Male"
            });
            listOfIds.Add(new Accounts
            {
                Name = "Gokul",
                Password = "12345",
                City = "karur",
                Qualification = "B.E",
                ContactNo = "9047670773",
                Email = "gokul@gmail.com",
                Gender = "Male"
            });
        }
        public IEnumerable<Accounts> GetAllAccounts()
        {
            return listOfIds;
        }
        public static bool CheckIds(Accounts account)
        {
            foreach (Accounts id in listOfIds)
            {
                if (account.Email == id.Email && account.Password == id.Password)

                    return true;
             
            }

            return false;
                    
                    
        }
    }
}
