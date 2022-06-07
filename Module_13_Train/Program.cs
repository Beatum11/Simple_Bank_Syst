using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_13_Train
{
   public class Program
    {
        


        static void Main(string[] args)
        {

            bool t = true;
            while (t)
            {
                Message();
                //t = false;
            }




            Console.ReadKey();
        }




        private static void Message()
        {
          
                Console.Write("\nЧто выберем: ");
                string s = Console.ReadLine();

                switch (s)
                {
                    case "А":
                        Console.WriteLine("\nХуй на");
                        return;

                    case "Б":
                        Console.WriteLine("\nПо бороде");
                        return;

                }



        }

    }
}
