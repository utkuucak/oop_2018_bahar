using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //int a = 5;
            //Console.WriteLine(a);

            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(input);

            //double num = 5.145;
            //string text = "Object Oriented Programming";

            //Console.WriteLine(text);

            //string name = Console.ReadLine();
            //Console.WriteLine("Entered name is " + name + ".");
            //char c = 'a';
            //Console.WriteLine(c);
            //float f = 5.0F; // float için yanına f koyman gerek, yoksa double oluyor

            //bool b = true;

            //char character = 'A';
            //Console.WriteLine(Convert.ToInt32(character));

            //string name = "";
            //string surname = "";
            //string dob = ""; // date of birth
            //int age = 0;

            //Console.Write("Name: ");
            //name = Console.ReadLine();

            //Console.Write("Surname: ");
            //surname = Console.ReadLine();

            //Console.Write("Date of Birth (YYYY): ");
            //dob = Console.ReadLine();

            //age = 2018 - Convert.ToInt32(dob);

            ////Console.Write("Age: ");
            ////age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Surname: " + surname);
            //Console.WriteLine("Age: " + age);

            double r = 0;
            double volume = 0;
            double pi = 3.14;
            string r_prompt = "Please enter the radius of the globe: ";

            Console.Write(r_prompt);
            r = Convert.ToDouble(Console.ReadLine());

            volume = pi * r * r * r * 4 / 3;

            Console.Write(volume);



            Console.WriteLine("\n\n\nPress a key to quit...");
            Console.ReadKey();
        }
    }
}
