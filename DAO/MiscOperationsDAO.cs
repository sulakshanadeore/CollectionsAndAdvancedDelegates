using CollectionModels;
namespace DAO
{
    public class MiscOperationsDAO
    {
        public static int AddNumbers(int p1, int p2)
        {
            return p1 + p2;

        }


        public static bool IsNumberEven(int no1)
        {
            if (no1 < 0) 
                return false;
            else if (no1 % 2 == 0) 
                return true;
            else return false;
        
        
        }

        //Func
        public double AddSingles(float i, float j)
        {

            return i + j;

        }

        //when a static method wants to use any variable or property,
        //that variable/property must also be static

        public static void Greet(string username)
        {

            //            Console.WriteLine("Good Morning," +username);
            Maths.SendGreetings = "Good Morning" + username;
        }


        public void SayBye(string username)
        {

            Console.WriteLine("Good day,See u soon" + username);
        }

    }
}
