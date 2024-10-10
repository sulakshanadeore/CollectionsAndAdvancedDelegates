using DAO;
namespace UtilProject
{
    public class UtilClass1
    {
        public static int AddUtility(int p1, int p2)
        {

            return MiscOperationsDAO.AddNumbers(p1, p2); 
        
        }
        public static void UserGreet(string username)
        { 
        MiscOperationsDAO.Greet(username);
        }


    }
}
