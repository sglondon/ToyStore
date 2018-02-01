using System;
using System.Collections.Generic;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toyArray = { "action figure", "doll", "legos" };//to create a new array

            List<string> toyList = new List<string>() { "action figure", "stuffed animal", "legos" }; //to create a new list, specifiy datatype

            toyList.Add("Barbie"); //add automatically goes to the end of the list
            toyList.Add("remote control car");
            toyList.Add("yo-yo");  //have to add elements one at a time not all in the same string

            //foreach(string toy in toyList) //for each loops are magical! 
            //{
            //    Console.WriteLine(toy);
            //}

            //for (int i = 0; i < toyList.Count; i++)  this does the same thing with a for loop
            // {
            // Console.WriteLine(toyList[i]);
            //  }

            Console.WriteLine(toyList[0]); //prints individual elements by referencing the index location. this slide doesn't work

            //the properties and methods we will use the most
            //are .Count
            //.Insert()
            //.Add()
            //.Remove()


            Console.WriteLine(toyList.Count);  //.Count is a property, it doesn't need ()

            toyList.Remove("Barbie");

            Console.WriteLine(toyList.Count);

            //insert allows us to put a new element in the list and
            //specify which index we want for that element

            toyList.Insert(0, "kite");  //whatever had been there moves to the next index spot
            toyList.Insert(2, "baby doll");
            toyList.Insert(1, "plastic dinosaur");

            //foreach(string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            //Another method that we will often use is .Contains(), built in method in arrays and lists
            //it returns a Boolean value 

            if (toyList.Contains("plastic dinosaur"))
            {
                Console.WriteLine("Daniel would never buy the dino.");
            }
            else
            {
                Console.WriteLine("Daniel might buy any of these todys.");
            }

            //.remove plastic dinosaur to get other message

            List<bool> shelfStatus = new List<bool>() { true, false, true, true, false };

            for (int i = 0; i < shelfStatus.Count; i++)
            {
                if (shelfStatus[i] == true)
                    Console.WriteLine("There are toys on this shelf.");

                
            else if (shelfStatus[i] == false)
                {
                    Console.WriteLine("This shelf is empty.");
                }
                else
                {

                    Console.WriteLine("You broke the code!");
                }


            }

            //Create a list. Add five stuffed animals to your list
            //Print each stuffed animal in your list.


            List<string> toyListTwo = new List<string>() { "Dog", "Cat", "Bear", "Cow", "Elephant" };

            foreach (string stuffedAnimal in toyListTwo)
            {
              Console.WriteLine(stuffedAnimal);
            }


            //Practice Question
            //Create a list with the following numbers
            //1, 23, 9, 77, 922, 6, 32, 63, 14, 5
            //determine whether each of the following values is an element in the list: 23, 77, 15
            //remove the following elements: 27, 922, 32, 6
            //again determine whether each of the following values is an element in the list: 23, 77, 15
            // (*Stretch: create a method so that you don't need to duplicate this work.*)


            List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            
                foreach (int num in numbers) 
            {
               Console.WriteLine(num);
            }


            if (numbers.Contains(23))
            {
                Console.WriteLine("The list contains number 23");
            }
            else
            {
                Console.WriteLine("The list doesn't contain number 23");
            }

            if (numbers.Contains(77))
            {
                Console.WriteLine("The list contains number 77");
            }
            else
            {
                Console.WriteLine("The list doesn't contain number 77");
            }

            if (numbers.Contains(15))
            {
                Console.WriteLine("The list contains number 15");
            }
            else
            {
                Console.WriteLine("The list doesn't contain number 15");
            }

            //remove 27(not in list), 23, 922, 32, 6

            numbers.Remove(23);
            numbers.Remove(922);
            numbers.Remove(32);
            numbers.RemoveAt(5);

            if (numbers.Contains(23))
            {
                Console.WriteLine("The list contains number 23");
            }
            else
            {
                Console.WriteLine("The list doesn't contain number 23");
            }

            if (numbers.Contains(77))
            {
                Console.WriteLine("The list contains number 77");
            }
            else
            {
                Console.WriteLine("The list doesn't contain number 77");
            }

            if (numbers.Contains(15))
            {
                Console.WriteLine("The list contains number 15");
            }
            else
            {
                Console.WriteLine("The list doesn't contain number 15");
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }



            List<string> employeeNames = new List<string>(); //lists are mutable, their size can change, don't have to assign a size, it can grow and shrink



        }
    }
}
