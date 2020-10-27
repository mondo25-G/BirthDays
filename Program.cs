using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Birthdays
{
    class Program
    {

        static void Main(string[] args)
        {


            PrintYourName();

            GiveName("Provide Name");
            GiveName("Dammit Give me your name i didn't hear it!");

            //or better
            string aMessage = "Give your Name, please";
            GiveName(aMessage);
            aMessage = "Give your Name, pretty please";
            GiveName(aMessage);
            //variable aMessage in MAIN scope passes its value as a PARAMETER (message) in GiveName()
            //parameter message is in another scope

            // here we took what was RETURNED from METHOD
            int x = AddTwoOtherIntegers(4, 3);
            Console.WriteLine(x);
            //des kai skepsou me vasi tis methodous tin writeline kai tin readline
            //ti kanoun ? void kai return?
            //ara einai methods kapoioi alloi tiw exoun grapsei kai emeis apla tis xrisimopoiooyme 
            // poy einai aytes oi methodoi?? sto .NET framework


            int noOfFriends = 5;
            string[] firstNames = new string[noOfFriends];
            string[] lastNames = new string[noOfFriends];
            string[] telephones = new string[noOfFriends];
            string[] datesOfBirth = new string[noOfFriends];

            //0 <---- 1 friend
            //<---- fill arrays with the data the user types from the keybord

            for (int i = 0; i < noOfFriends; i++)
            {



                if (i == 0)
                {
                    Console.WriteLine("Data for {0}st person: ", i + 1);
                }

                if (i == 1)
                {
                    Console.WriteLine("Data for {0}nd person: ", i + 1);
                }

                if (i == 2)
                {
                    Console.WriteLine("Data for {0}rd person: ", i + 1);
                }

                if (i > 2)
                {
                    Console.WriteLine("Data for {0}th person: ", i + 1);
                }

                Console.Write("Give me your firsst name: ");
                firstNames[i] = Console.ReadLine(); // ASSIGNED
                                                    //Console.WriteLine(firstNames[i]);

                Console.Write("Give me your last name: ");
                lastNames[i] = Console.ReadLine(); // ASSIGNED
                                                   //Console.WriteLine(lastNames[i]);

                Console.Write("Give me your telephone: ");
                telephones[i] = Console.ReadLine(); // ASSIGNED
                                                    //Console.WriteLine(telephones[i]);

                Console.Write("Give me your date Of Birth: ");
                datesOfBirth[i] = Console.ReadLine(); // ASSIGNED
                                                      //Console.WriteLine(datesOfBirth[i]);
            }

            ////This code is not poetic it has many stuff that repeat themselves
            //// he showed answer += * --> answer=answer+1
            //int i = 0;

            ////all the same
            //i= i + 1;
            //i += 1;
            //i++;
            ////HW check differences between i++, ++i
            //i = i - 1;
            //i -= 1;
            //i--;

            ////Console.WriteLine(i++/1-1); valid
            ///


            //WHILE LOOPS

            //dont run it
            //if you run it ctrl+C to exit or press start (debugging) and then stop (debugging)

            //while (true)
            //{
            //    Console.WriteLine("You are crazy!!!!\n This is an infinite loop!!!\tHow can i stop it???");// /n goes to new line,  t/ is a tab.
            //}

            //
            //int x=3000
            //while (x=3000)
            //{
            //    Console.WriteLine(x/2); infinite loop
            //}



            //observe this Program.cd notice it has a method in it (Main).
            //note Namespace-->Class-->(Main)Method architecture
            //METHODS We write them using Pascal Case

            //replace the following code with method
            //this particular method MUST be declared as STATIC we'll see why
            //like Main also note VOID its RETURN TYPE
            //so i need to write it as
            //static void AskUserDetails() {} 
            //try inserting it in different places in program.cs and you will see that it is accepted when i place it inside sth called CLASS Program 
            //Furthermore it is above MAIN or below MAIN
            // you can try placing it inside method MAIN ONLY if you remove the STATIC keyword. only then is it accpeted
            // a static method cannot be declared inside MAIN?? but METHOD main can contain METHODS
            //therefore generally speaking a method can be declared inside a class, before or after other methods (maybe other things in OOP>)


            //i'd like to place that inside it
            //Console.Write("Give me your firsst name: ");
            //firstNames[i] = Console.ReadLine(); 

            //Console.Write("Give me your last name: ");
            //lastNames[i] = Console.ReadLine(); 

            //Console.Write("Give me your telephone: ");
            //telephones[i] = Console.ReadLine(); 

            //Console.Write("Give me your date Of Birth: ");
            //datesOfBirth[i] = Console.ReadLine(); 


        }

        //for all METHODS that do not involve OOP we will place the STATIC 

        //static          return data type  method name    parameters
          static          void              AskUserDetails(         )//DEFINITION method signature == static void AskUserDetail, don't know what it does but that is what i need
        {
            //block code BODY OF THE METHOD
        }

        //define the MethodPrintYourName
        static void PrintYourName()
        {
            Console.WriteLine("Introduce yourself");
            //one way is to save it like that then call it
            //string name=Console.ReadLine(); 
            //Console.WriteLine(name);

            //Look here! Method readline is used as input parameter for Method Writeline. Works fine.
            Console.WriteLine(Console.ReadLine());
        }
        //ok, done, where do i put it to call it? put it in MAIN since that is where i out my code

        //Note that bold color in method means I USE IT, where as dim color means I DONT USE IT (In Main Method)

        //Look
        //I give my METHOD the flexibility to accept INPUT from outside of BODY that passes as a PARAMETER 
        static void GiveName(string message)  //GiveName(string message, int x, bool b)
        {
            Console.WriteLine(message);
            Console.WriteLine(Console.ReadLine());
        }

        static void AddTwoIntegers(int x,int y)
        {
            Console.WriteLine("x + y ="+ (x + y));
            //return (..);  Void forbids it
        }
        //yes but i am bored i dont want to cw all the time i want to print in MAIN method. Thelw mono tin praksi
        //therefore i NEED a RETURN TYPE and the command return
        static int  AddTwoOtherIntegers(int x, int y)
        {
            return x + y;
        }
        //static int DivideTwoNumbers(int x,int y)
        //static void MergeTwoStringsAndPrint(string s1, string s2)  use the one below as points bonus
        //static string MergeTwoStrings(string s1, string s2)
        //static void PrintSumOfIntegers(int[] array)
        //static void PrintCharacterXTimes(string character, int times)
        //static string ReturnCharacterXTimes(string character, int times)
        //static string[] fillArrayWithNullValues(int sizeOfArray)  psakse ta null values

        //you should make a new project where all of the above methods must be used





    }

}
