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
        private string noise;
        // Weight of the animal (lbs)
        private float weight;

        //Constructor
        public Animal()
        {
            setName("Bartholomew");
            setAge(20);
            setNoise("Greetings my good sir.");
            setWeight(900f);
        }

        public void printInfo()
        {
            Console.WriteLine("Animal Info:\n\tName: " + name + "\n\tAge: " + age + "\n\tWeight: " + weight + "\n");
        }

        public void makeNoise()
        {
            Console.WriteLine(name + " says: " + noise + "\n");
        }

        public void ageUp()
        {
            age++;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public string getNoise()
        {
            return noise;
        }

        public void setNoise(string noise)
        {
            this.noise = noise;
        }

        public float getWeight()
        {
            return weight;
        }

        public void setWeight(float weight)
        {
            this.weight = weight;
        }
    }
}
