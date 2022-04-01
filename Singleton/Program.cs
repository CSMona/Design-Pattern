using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();

        private static readonly object obj = new object();
        private static int counter;
        private  Singleton()
        {
            counter++;
            Console.WriteLine("counter{0}",counter);
        }
        //use double check to reduce synchronize
        public static Singleton getinstance()
        {
            if (instance == null)//check one
            {
                lock (obj)
                {
                    if (instance == null)//check two
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }

        public void GetDetailes(string msg)
        {
            Console.WriteLine(msg);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => GetStudent(),
                () => GetEmployee()
                );
          

        }

        private static void GetEmployee()
        {
            Singleton s2 = Singleton.getinstance();
            s2.GetDetailes("Employee");
        }

        private static void GetStudent()
        {
            Singleton s1 = Singleton.getinstance();
            s1.GetDetailes("Student");
        }

    }

       

    }

