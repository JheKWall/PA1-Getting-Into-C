/*
 * Name: Kenneth Wallace
 * Date: 1-21-23
 * Brief: concrete cassowary class
 * Description: subclass of the abstract animal class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1_JKW_352
{
    public class Cassowary : Animal
    {

        //Cassowary Paramaterized Constructor
        public Cassowary(string name, int age, float weight)
        {
            setNoise("Growl.");

            setName(name);
            setAge(age);
            setWeight(weight);
        }

        //Method to print all of the animal's information
        //Prints animal information to console.
        public override void printInfo()
        {
            Console.WriteLine("- Name: " + getName() + "\n- Age: " + getAge() + "\n- Weight: " + getWeight() + "\n");
        }

        //Method to make the animal make a noise
        //Prints animal's noise to console.
        public override void makeNoise()
        {
            Console.WriteLine(getName() + " says: \"" + getNoise() + "\"\n");
        }

        //Method to increment animal's age by one.
        public override void ageUp()
        {
            setAge(getAge() + 1);
        }
    }
}
