/*
 * Name: Kenneth Wallace
 * Date: 1-21-23
 * Brief: concrete cat class
 * Description: subclass of the abstract animal class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1_JKW_352
{
    public class Cat : Animal
    {
        //Cat Default Constructor
        Cat()
        {
            setNoise("Miau.");

            setName("Casey the Cat");
            setAge(5);
            setWeight(9f);
        }

        //Cat Default Constructor
        public Cat(string name, int age, float weight)
        {
            setNoise("Miau.");

            setName(name);
            setAge(age);
            setWeight(weight);
        }
    }
}
