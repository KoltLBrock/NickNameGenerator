using System;

namespace NickNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nicknames = new string[10,2];
            nicknames[0,0] = "Dude";
            nicknames[0,1] = "Jones";

            Console.WriteLine("Enter your name please: ");
            string name = Console.ReadLine();
            string[] nameparts = name.Split(new char[' ']);
            for(int i=0; i < nameparts.Length; i++){
                Console.WriteLine(nameparts[i]);
            }
        }
    }
}
