//string userkey = "Qocali2002";
//string pass = "Psg+1970";
//;
//bool key = true;
//do
//{
//    Console.WriteLine("please,enter your username");
//    string username = Console.ReadLine();
//    Console.WriteLine("please,enter your password");
//    string password = Console.ReadLine();
//if (username==userkey && password == pass)
//    {
//        Console.WriteLine("succesfully entering");
//        key= false;
//    }
//    else
//    {
//        Console.WriteLine("have any false");
//    }
//}while (key);


//public class ExThread
//{

//    // Static method for thread a
//    public static void thread1()
//    {
//        for (int z = 0; z < 5; z++)
//        {
//            Console.WriteLine(z);

//        }
//    }

//    // static method for thread b
//    public static void thread2()
//    {
//        for (int z = 0; z < 5; z++)
//        {
//            Console.WriteLine(z);
//        }
//    }
//}

//// Driver Class
//public class GFG
//{

//    // Main method
//    public static void Main()
//    {
//        // Creating and initializing threads
//        Thread a = new Thread(ExThread.thread1);
//        Thread b = new Thread(ExThread.thread2);
//        Thread.Sleep(1000);
//        a.Start();
//        Thread.Sleep(1000);
//        b.Start();
//    }
//}

//bool key = true;
//    List<int> nums = new List<int>();
//while (key)
//{
//      Console.WriteLine("her hansi ededi giriniz");
//        int num = Convert.ToInt32(Console.ReadLine());
//        nums.Add(num);
//        Console.WriteLine("davam etmek istetorsunuz");
//        char res = Convert.ToChar(Console.ReadLine());
//        if (res.ToString().ToLower() == "y")
//        {
//            key = true;
//        }
//        else
//        {
//            int max = nums.FindAll(x => x % 2 != 0).Max();
//            int min = nums.FindAll(x => x % 2 != 0).Min();
//            Console.WriteLine(max - min);
//            key = false;
//        }


   
    
//}
public class MyThread
{
    public void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(200);
        }
    }
}
public class ThreadExample
{
    public static void Main()
    {
        MyThread mt = new MyThread();
        Thread t1 = new Thread(new ThreadStart(mt.Thread1));
        Thread t2 = new Thread(new ThreadStart(mt.Thread1));
        t1.Start();
        t2.Start();
    }
}

