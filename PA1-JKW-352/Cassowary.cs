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
        //Cassowary Default Constructor
        Cassowary()
        {
            setNoise("Growl.");

            setName("Carl the Cassowary");
            setAge(10);
            setWeight(130f);
        }

        //Cassowary Paramaterized Constructor
        public Cassowary(string name, int age, float weight)
        {
            setNoise("Growl.");

            setName(name);
            setAge(age);
            setWeight(weight);
        }
    }
}
