/*
 * Name: Kenneth Wallace
 * Date: 1-21-23
 * Brief: abstract animal class
 * Description: abstract animal class, parent of all concrete animal classes (cassowary, cat, crocodile, etc.)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1_JKW_352
{
    public class Animal
    {
        // Name of the animal
        private string name;
        // Age of the animal
        private int age;
        // Noise the animal makes (meow, rawr, etc.)
        // Noise is not set by the constructor as each animal type makes the same noise
        private string noise;
        // Weight of the animal (lbs)
        private float weight;

        //Constructor
        public Animal()
        {
            setNoise("Greetings my good sir.");

            setName("Bartholomew");
            setAge(30);
            setWeight(170f);
        }

        //Paramaterized Constructor
        public Animal(string name, int age, float weight)
        {
            setNoise("Greetings my good sir.");

            setName(name);
            setAge(age);
            setWeight(weight);
        }

        //Method to print all of the animal's information
        //Prints animal information to console.
        public void printInfo()
        {
            Console.WriteLine("- Name: " + name + "\n- Age: " + age + "\n- Weight: " + weight + "\n");
        }

        //Method to make the animal make a noise
        //Prints animal's noise to console.
        public void makeNoise()
        {
            Console.WriteLine(name + " says: \"" + noise + "\"\n");
        }

        //Method to increment animal's age by one.
        public void ageUp()
        {
            age++;
        }

        //Name Accessor
        public string getName()
        {
            return name;
        }

        //Name Mutator
        public void setName(string name)
        {
            this.name = name;
        }

        //Age Accessor
        public int getAge()
        {
            return age;
        }

        //Age Mutator
        public void setAge(int age)
        {
            this.age = age;
        }
        
        //Noise Accessor
        public string getNoise()
        {
            return noise;
        }

        //Noise Mutator
        public void setNoise(string noise)
        {
            this.noise = noise;
        }

        //Weight Getter
        public float getWeight()
        {
            return weight;
        }

        //Weight Setter
        public void setWeight(float weight)
        {
            this.weight = weight;
        }
    }
}
