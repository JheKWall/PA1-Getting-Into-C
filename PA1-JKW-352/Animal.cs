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
    public abstract class Animal
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

        //Method to print all of the animal's information
        //Prints animal information to console.
        public abstract void printInfo();

        //Method to make the animal make a noise
        //Prints animal's noise to console.
        public abstract void makeNoise();

        //Method to increment animal's age by one.
        public abstract void ageUp();

        //Name Accessor
        protected string getName()
        {
            return name;
        }

        //Name Mutator
        protected void setName(string name)
        {
            this.name = name;
        }

        //Age Accessor
        protected int getAge()
        {
            return age;
        }

        //Age Mutator
        protected void setAge(int age)
        {
            this.age = age;
        }

        //Noise Accessor
        protected string getNoise()
        {
            return noise;
        }

        //Noise Mutator
        protected void setNoise(string noise)
        {
            this.noise = noise;
        }

        //Weight Getter
        protected float getWeight()
        {
            return weight;
        }

        //Weight Setter
        protected void setWeight(float weight)
        {
            this.weight = weight;
        }
    }
}
