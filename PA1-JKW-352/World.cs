/*
 * Name: Kenneth Wallace
 * Date: 1-21-23
 * Brief: user interface for program
 * Description: Allows user to interact with Animal class and its subclasses with an in-depth user interface.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1_JKW_352
{
    class World
    {
        List<Animal> animalList = new List<Animal>();

        public void animalMenu()
        {
            int userInput = 0;

            while(userInput != 7)
            {
                Console.WriteLine("\nANIMAL MANAGEMENT INTERFACE\n" 
                    + "Please enter a number:\n" 
                    + "\t[1] List Animals\n"
                    + "\t[2] Add Animal\n"
                    + "\t[3] Remove Animal\n"
                    + "\t[4] Find Animal\n"
                    + "\t[5] Play Animal's Noise\n"
                    + "\t[6] Age Up An Animal\n"
                    + "\t[7] Exit Program\n");
                
                userInput = Convert.ToInt32(Console.ReadLine());

                switch(userInput)
                {
                    case 1: //List Animals
                        listAnimals();
                        break;

                    case 2: //Add Animal
                        addAnimal();
                        break;

                    case 3: //Remove Animal
                        removeAnimal();
                        break;

                    case 4: //Find Animal
                        findAnimal();
                        break;

                    case 5: //Play Animal Noise
                        playAnimalNoise();
                        break;

                    case 6: //Age Animal
                        ageUpAnimal();
                        break;

                    case 7: //Exit Program
                        break;

                    default: //Not a valid number
                        Console.WriteLine("Invalid Selection.\n");
                        break;
                }
            }

        }

        private void listAnimals()
        {
            //Exit if theres no animals yet
            if (animalList.Count() <= 0)
            {
                Console.WriteLine("No animals in system.\n");
                return;
            }

            //Prints all animals
            //Used in other methods to give user choices as well
            Console.WriteLine("\nPrinting All Animals...\n");
            for (int i = 0; i < animalList.Count(); i++)
            {
                string speciesName = Convert.ToString(animalList[i]);
                speciesName = speciesName.Remove(0, 12);
                Console.WriteLine((i + 1) + ". " + speciesName + ":");
                animalList[i].printInfo();
            }
        }

        private void addAnimal()
        {
            int userInput = 0;

            //Initialized because compiler hates using uninitialized variables for some reason (CS0165)
            string animalName = "";
            int animalAge = 0;
            float animalWeight = 0f;

            //User Option Prompt
            Console.WriteLine("Add Animal selected, please choose an animal to add:\n" +
                "[1] Cassowary\n" +
                "[2] Cat\n" +
                "[3] Crocodile\n" +
                "[4] None, Exit Menu\n");
            userInput = Convert.ToInt32(Console.ReadLine());

            //Skip Animal Info. Input if user wants to exit
            if(userInput != 4)
            {
                Console.WriteLine("Enter name of animal:");
                animalName = Console.ReadLine();

                Console.WriteLine("Enter age of animal:");
                animalAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the weight of the animal (decimals allowed):");
                animalWeight = Convert.ToSingle(Console.ReadLine());
            }

            //User Option Controller using userInput
            switch(userInput)
            {
                case 1: //Cassowary
                    Cassowary cass = new Cassowary(animalName, animalAge, animalWeight);
                    animalList.Add(cass);
                    break;

                case 2: //Cat
                    Cat cat = new Cat(animalName, animalAge, animalWeight);
                    animalList.Add(cat);
                    break;

                case 3: //Crocodile
                    Crocodile croc = new Crocodile(animalName, animalAge, animalWeight);
                    animalList.Add(croc);
                    break;

                case 4: //User Exit
                    break;

                default: //Unknown Input, Exit Anyways
                    break;
            }
        }

        private void removeAnimal()
        {
            //Exit if theres no animals yet
            if (animalList.Count() <= 0)
            {
                Console.WriteLine("No animals in system.\n");
                return;
            }

            int userInput;

            //Prints all animals so user can choose which one to remove
            listAnimals();
            Console.WriteLine("Which animal to remove?");
            userInput = Convert.ToInt32(Console.ReadLine());

            //Checks if user input is out of bounds (negative or greater than)
            //User Input is decreased by one, this is because animal number is increased by one (cosmetic decision so animal count doesn't start at 0.)
            if ((userInput - 1) < 0 || (userInput - 1) > animalList.Count())
            {
                Console.WriteLine("Animal does not exist.\n");
            }
            else
            {
                animalList.Remove(animalList[userInput - 1]);
            }
        }

        private void findAnimal()
        {
            //Exit if theres no animals yet
            if (animalList.Count() <= 0)
            {
                Console.WriteLine("No animals in system.\n");
                return;
            }

            int userInput;
            int incrementHelper = 0; //Tells method if any animals have been found, if none then it will tell user.
            string animalName;
            int animalAge;
            float animalWeight;

            Console.WriteLine("Choose one find an animal with:\n"
                + "1. Animal Name\n"
                + "2. Animal Age\n"
                + "3. Animal Weight\n"
                + "4. None, Exit Menu\n");

            userInput = Convert.ToInt32(Console.ReadLine());

            switch(userInput)
            {
                case 1: //Search by Animal Name
                    Console.WriteLine("Enter name to search for:");
                    animalName = Console.ReadLine();

                    //Increment through whole animalList, if animal has same name as given, print info
                    for(int i = 0; i < animalList.Count(); i++)
                    {
                        if(animalList[i].getName() == animalName)
                        {
                            incrementHelper++;
                            animalList[i].printInfo();
                        }
                    }
                    break;

                case 2: //Search by Animal Age
                    Console.WriteLine("Enter age to search for:");
                    animalAge = Convert.ToInt32(Console.ReadLine());

                    for(int i = 0; i < animalList.Count(); i++)
                    {
                        if(animalList[i].getAge() == animalAge)
                        {
                            incrementHelper++;
                            animalList[i].printInfo();
                        }
                    }
                    break;

                case 3: //Search by Animal Weight
                    Console.WriteLine("Enter weight to search for:");
                    animalWeight = Convert.ToSingle(Console.ReadLine());

                    for(int i = 0; i < animalList.Count(); i++)
                    {
                        if(animalList[i].getWeight() == animalWeight)
                        {
                            incrementHelper++;
                            animalList[i].printInfo();
                        }
                    }
                    break;

                case 4: //Exit menu
                    incrementHelper++;
                    break;

                default:
                    incrementHelper++;
                    break;
            }

            if(incrementHelper == 0)
            {
                Console.WriteLine("No animal found.\n");
            }
        }

        private void playAnimalNoise()
        {
            //Exit if theres no animals yet
            if (animalList.Count() <= 0)
            {
                Console.WriteLine("No animals in system.\n");
                return;
            }

            int userInput;

            //Prints all animals so user can choose which one to remove
            listAnimals();
            Console.WriteLine("Which animal to sound off?");
            userInput = Convert.ToInt32(Console.ReadLine());

            if ((userInput - 1) < 0 || (userInput - 1) > animalList.Count())
            {
                Console.WriteLine("Animal does not exist.\n");
            }
            else
            {
                animalList[userInput - 1].makeNoise();
            }

        }

        private void ageUpAnimal()
        {
            //Exit if theres no animals yet
            if (animalList.Count() <= 0)
            {
                Console.WriteLine("No animals in system.\n");
                return;
            }

            int userInput;

            listAnimals();
            Console.WriteLine("Which animal to age up?");
            userInput = Convert.ToInt32(Console.ReadLine());

            if((userInput - 1) < 0 || (userInput - 1) > animalList.Count())
            {
                Console.WriteLine("Animal does not exist.\n");
            }
            else
            {
                animalList[userInput - 1].ageUp();
            }
        }
    }
}
