using CollectionModels;
using DAO;

using System.Collections.Generic;
using System.Collections;
internal class Program
{

    private static void Main(string[] args)
    {
        //object---System.Collection---NonGenerics
        //all types allowed use NonGeneric
        //Stack s=new Stack();//LIFO
        //s.Push(1);
        //s.Push("Hello");
        //s.Push('A');
        //s.Push(new DateTime(2020, 2, 12));
        //s.Push(56.33f);
        //s.Push(3435.343d);
        //s.Push(23234234234l);

        //foreach (var item in s)
        //{

        //    Console.WriteLine(item);

        //}

        ////Push,pop,peek,toarray,count,clear, copy,contains
        //Queue q=new Queue();//FIFO
        //q.Enqueue(34);
        //q.Enqueue("Hello");
        ////Enqueue,Dequeue,Peek,Count,Clear,Copy,contains

        //foreach (var item in q)
        //{
        //    Console.WriteLine(item);
        //}

        //Hashtable ht=new Hashtable();//Key is object,value is object
        //ht.Add(1, 100);
        //ht.Add("1", 100);
        //ht.Add(2, "200");
        //ht.Remove(1);//remove by key
        ////Add,Remove,Count,Clear,Copy,contains

        //ArrayList a=new ArrayList(2);
        //a.Add(1);
        //a.Add(2);
        //a.Add(234234);
        //a.Add("JHello");
        //a.Add(3435345.34f);

        //ArrayList b=new ArrayList(2); 
        //b.Add(100);
        //b.Add(200);
        //b.Add(3000);
        //b.Add(400);

        //a.AddRange(b);
        //foreach (var item in a)
        //{
        //    Console.WriteLine(item);
        //}


        ////add,remove,count,copy,contains,clear,toarray,reverse,InsertRange


        ////whenever only specific is to be allowed use generic
        //Stack<int> intStack=new Stack<int>();   
        //intStack.Push(1);
        //intStack.Push(2);
        //intStack.Push(3933);
        ////intStack.Push("sfs");---Not allowed in Generic

        //Stack<Products> productsStack=new Stack<Products>();
        //productsStack.Push(new Products { Prodid = 1, Prodname = "Tea", UnitPrice = 10 });
        //productsStack.Push(new Products { Prodid = 2, Prodname = "Coffee", UnitPrice = 20 });
        //productsStack.Push(new Products { Prodid = 3, Prodname = "Green Tea", UnitPrice = 30 });



        //WorkingWithList();

        //Dictionary<int,string> dic=new Dictionary<int,string>();
        //dic.Add(1, "Suvarna");
        //dic.Add(2, "Anita");
        //dic.Add(3, "Vinita");
        //dic.Add(4, "Pranita");
        //dic.Add(5, "Ankita");
        //Console.WriteLine("Using While Loop");
        //Dictionary<int,string>.Enumerator DictValues= dic.GetEnumerator();
        //while (DictValues.MoveNext())
        //{
        //    Console.WriteLine(DictValues.Current.Key);
        //    Console.WriteLine(DictValues.Current.Value);

        //}

        //Console.WriteLine("using For each loop");
        //foreach (KeyValuePair<int,string> item in dic)
        //{
        //    Console.WriteLine(item.Key);
        //    Console.WriteLine(item.Value);

        //}
        //Console.WriteLine("-------------------");

        //IEnumerable<KeyValuePair<int,string>>  data=dic.Where<KeyValuePair<int, string>>(v => v.Key == 1);
        //foreach (var item in data)
        //{
        //    Console.WriteLine(item.Key + "  " + item.Value);
        //}
        //Console.WriteLine("------------------------------");

        //Dictionary<int, User> userDic = new Dictionary<int, User>();

        
        //userDic.Add(1, new User { UserName = "Pari", Password = 23423 });
        //userDic.Add(3, new User { UserName = "Hari", Password = 234231 });
        //userDic.Add(4, new User { UserName = "Jim", Password = 12345 });
        //userDic.Add(2, new User { UserName = "Kat", Password = 234324 });

        //foreach (KeyValuePair<int, User> item in userDic)
        //{
        //    Console.Write(item.Key + "\t");
        //    Console.Write(item.Value.UserName + "\t");
        //    Console.Write(item.Value.Password + "\t");
        //    Console.WriteLine();
        //}


        //IEnumerable<KeyValuePair<int, User>> userfoundInDic = 
        //    userDic.Where<KeyValuePair<int, User>>
        //    (v => v.Key == 1 && v.Value.UserName == "Pari" && v.Value.Password == 23423);


        //foreach (var item in userfoundInDic)
        //{
        //    Console.WriteLine(item.Key);
        //    Console.WriteLine(item.Value.UserName);
        //    Console.WriteLine(item.Value.Password);
        //}

        //Console.WriteLine("=====================");


        SortedDictionary<int, User> userDicSorted = new SortedDictionary<int, User>();


        userDicSorted.Add(1, new User { UserName = "Pari", Password = 23423 });
        userDicSorted.Add(3, new User { UserName = "Hari", Password = 234231 });
        userDicSorted.Add(4, new User { UserName = "Jim", Password = 12345 });
        userDicSorted.Add(2, new User { UserName = "Kat", Password = 234324 });

        foreach (KeyValuePair<int, User> item in userDicSorted)
        {
            Console.Write(item.Key + "\t");
            Console.Write(item.Value.UserName + "\t");
            Console.Write(item.Value.Password + "\t");
            Console.WriteLine();
        }

        Console.WriteLine("==========================");

        SortedList<int, string> names = new SortedList<int, string>();
        names.Add(1,   "Praj");
        names.Add(3, "Simran" );
        names.Add(5,   "Raj" );
        names.Add(4, "Nita" );
        names.Add(2,  "Sima" );
        names.Add(6,  "Rajesh" );


        foreach (var item in names)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }
        Console.WriteLine("--------------------------");
        SortedSet<string> setdata = new SortedSet<string>();
        setdata.Add("One");
        setdata.Add("Two");
        setdata.Add("Three");

        foreach (var item in setdata)
        {
            Console.WriteLine(item);
        }



        //int ans=Maths.AddNumbers(10, 20);
        //Console.WriteLine(ans);
        //Last parameter in the func wlambda is output type of the method.

        //public static int AddNumbers(int p1, int p2)

        //Func<int, int, int> funLambda = MiscOperationsDAO.AddNumbers;
        //int ans = funLambda(10, 20);
        //Console.WriteLine(ans);

        //Maths m=new Maths();
        //Func<float,float,double> addtwoFloats=m.AddSingles;
        //double valueonAddition=addtwoFloats(100.3f, 88.56f);
        //Console.WriteLine(valueonAddition);


        // public static void Greet(string username)
        //Action<string> funAction = Maths.Greet;
        //funAction(" Aarya");
        //string msg=Maths.SendGreetings;
        //Console.WriteLine(msg);
        //Predicate<int> predLambda=MiscOperationsDAO.IsNumberEven;
        //bool isEven=predLambda(101);
        //Console.WriteLine(isEven);


        Console.WriteLine();


        //Maths.Greet("Abhishek");
        //Maths m = new Maths();
        //m.SayBye("Prajakta");

        //Program.StaticMethod();
        //StaticMethod();
        //Program p = new Program();
        //p.NonStatic();

        Console.ReadKey();


    }

    private static void WorkingWithList()
    {
        List<string> strList = new List<string>();
        strList.Add("ankit");
        List<User> users = new List<User>();


        users.Add(new User { UserName = "ankit", Password = 123 });

        User u = new User();
        u.UserName = "Shivani";
        u.Password = 134;

        users.Add(u);
        users.Add(new User { UserName = "Suma", Password = 1234 });
        users.Add(new User { UserName = "Suma", Password = 123 });

        foreach (var item in users)
        {
            Console.WriteLine(item.UserName);
            Console.WriteLine(item.Password);
            Console.WriteLine("-------");
        }

        Console.WriteLine("===========================");
        //  FindUserData(users);

        List<User> withSameName = users.FindAll(u => u.UserName == "Suma");
        foreach (var item in withSameName)
        {
            Console.WriteLine(item.UserName);
            Console.WriteLine(item.Password);
        }

        users.ForEach(u =>
        {
            Console.WriteLine(u.UserName);
            Console.WriteLine(u.Password);
        });

        Console.WriteLine("------------------------------------------");
        List<Products> productsList = new List<Products>();
        productsList.Add(new Products { Prodid = 1, Prodname = "Tea", UnitPrice = 10 });
        productsList.Add(new Products { Prodid = 2, Prodname = "Coffee", UnitPrice = 20 });
        productsList.Add(new Products { Prodid = 3, Prodname = "Green Tea", UnitPrice = 30 });
        productsList.Add(new Products { Prodid = 4, Prodname = "Coffee1", UnitPrice = 40 });
        productsList.Add(new Products { Prodid = 5, Prodname = "Green Tea1", UnitPrice = 50 });


        productsList.ForEach(p => Console.WriteLine(p.Prodid));

        Console.WriteLine("--------------------------------------------");

        bool istrue = productsList.All(p => p.Prodid > 0);
        Console.WriteLine(istrue);
        float maxvalue = productsList.Average(p => p.UnitPrice);
        Console.WriteLine(maxvalue);
        Console.WriteLine("===============");
        List<Products> productsUnitPriceGreaterThanEqualTo20 = productsList.Where(p => p.UnitPrice >= 20).ToList();
        foreach (var item in productsUnitPriceGreaterThanEqualTo20)
        {
            Console.WriteLine(item.Prodid);
            Console.WriteLine(item.Prodname);
            Console.WriteLine(item.UnitPrice);

        }
    }

    private static void FindUserData(List<User> users)
    {
        Console.WriteLine("Enter username");
        User validateUser = new User();
        validateUser.UserName = Console.ReadLine();
        Console.WriteLine("Enter password");
        validateUser.Password = Convert.ToInt32(Console.ReadLine());

        User foundOrNot = users.Find(u => u.UserName == validateUser.UserName && u.Password == validateUser.Password);
        if (foundOrNot == null)
        {
            Console.WriteLine("User not found");
        }
        else
        {
            Console.WriteLine("You are a valid user");
        }
    }

    private void NonStatic()
    {
        Console.WriteLine("Called non static");

    }
    private  static void StaticMethod()
    {
        Console.WriteLine("Called  static Method");

    }



}