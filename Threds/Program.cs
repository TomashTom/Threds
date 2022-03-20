using System;
using System.Threading;
namespace Threds
{

    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine("Print Number", Thread.CurrentThread.Name);
            Console.WriteLine("Your number: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + ",  ");
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
        
    }

    public class ForegroundThread

    {
        static void mythread()
        {
            for (int c = 0; c <= 3; c++)
            {
                Console.WriteLine("mythread is in progress!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }


    }


    class Program
    {
        static void Main(string[] args)
        {


            //public string chooice;



          

            Console.WriteLine("******Background Threads******");
            Printer p = new Printer();
            Thread backgroundThred = new Thread(new ThreadStart(p.PrintNumbers));
            backgroundThred.IsBackground = true;
            backgroundThred.Start();
            Console.WriteLine("Main is working");
            Console.ReadLine();



            /*Console.WriteLine("******MultiThreading******");
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";


            Thread thread1 = new Thread(() => CountDow("Timer #1"));
            Thread thread2 = new Thread(() => Countup("Timer #2"));
            thread1.Start();
            thread2.Start();



            Console.WriteLine(mainThread.Name + "is complite!");

            Console.ReadKey();*/

            Console.WriteLine("******Foreground Threads******");

            Thread thr = new Thread(mythread);
            thr.Start();
            Console.WriteLine("Main Thread Ends!!");





        }
        /*public static void CountDow(String name)
        {
            for(int i =5; i>0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + "seconds");
                Thread.Sleep(2000);
            }
            Console.WriteLine("Timer #1 is complite!");
        }
        public static void Countup(String name)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Timer #2 : " + i + "seconds");
                Thread.Sleep(2000);
            }
            Console.WriteLine("Timer #2 is complite!");
        }*/

        static void mythread()
        {
            for (int c = 0; c <= 3; c++)
            {

                Console.WriteLine("mythread is in progress!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine("mythread ends!!");
        }


        
    }

}
