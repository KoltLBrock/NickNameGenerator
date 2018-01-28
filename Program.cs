using System;

namespace NickNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of names, Roman Emperor's names before ascension
            string[,] nicknames = new string[10,2];
            nicknames[0,0] = "Gaius";
            nicknames[0,1] = "Octavius";
            nicknames[1,0] = "Nero";
            nicknames[1,1] = "Claudius";
            nicknames[2,0] = "Marcus";
            nicknames[2,1] = "Agrippa";
            nicknames[3,0] = "Gaius";
            nicknames[3,1] = "Julius";
            nicknames[4,0] = "Vespasianus";
            nicknames[4,1] = "Flavius";
            nicknames[5,0] = "Titus";
            nicknames[5,1] = "Flavius";
            nicknames[6,0] = "Marcus";
            nicknames[6,1] = "Nerva";
            nicknames[7,0] = "Lucius";
            nicknames[7,1] = "Commodus";
            nicknames[8,0] = "Publius";
            nicknames[8,1] = "Hadrianus";
            nicknames[9,0] = "Marcus";
            nicknames[9,1] = "Aurelius";
            //prompts user for input name, it gets split by space
            Console.WriteLine("Enter your name please: ");
            string name = Console.ReadLine();
            string[] nameparts = name.Split(' ');
            //the parts of the name, minus the space is added together
            int nameOneLength = nameparts[0].Length;
            int nameTwoLength = nameparts[1].Length;
            int combinedLength = nameOneLength + nameTwoLength;
            //nickname is selected based on legnth, most common name lengths have the most variation, long and short names past that length dont get special names
            //nickname is then printed
            if(combinedLength <= 4){
                Console.WriteLine("Your new nickname is " + nicknames[9,0] + " " + nicknames[9,1]);
            }else if(combinedLength <= 6 && combinedLength > 4){
                Console.WriteLine("Your new nickname is " + nicknames[8,0] + " " + nicknames[8,1]);
            }else if(combinedLength <= 8 && combinedLength > 6){
                Console.WriteLine("Your new nickname is " + nicknames[7,0] + " " + nicknames[7,1]);
            }else if(combinedLength <= 10 && combinedLength > 8){
                Console.WriteLine("Your new nickname is " + nicknames[6,0] + " " + nicknames[6,1]);
            }else if(combinedLength <= 11 && combinedLength > 10){
                Console.WriteLine("Your new nickname is " + nicknames[5,0] + " " + nicknames[5,1]);
            }else if(combinedLength <= 12 && combinedLength > 11){
                Console.WriteLine("Your new nickname is " + nicknames[4,0] + " " + nicknames[4,1]);
            }else if(combinedLength <= 13 && combinedLength > 12){
                Console.WriteLine("Your new nickname is " + nicknames[3,0] + " " + nicknames[3,1]);
            }else if(combinedLength <= 14 && combinedLength > 13){
                Console.WriteLine("Your new nickname is " + nicknames[2,0] + " " + nicknames[2,1]);
            }else if(combinedLength <= 15 && combinedLength > 14){
                Console.WriteLine("Your new nickname is " + nicknames[1,0] + " " + nicknames[1,1]);
            }else{
                Console.WriteLine("Your new nickname is " + nicknames[0,0] + " " + nicknames[0,1]);
            }
        }
    }
}
