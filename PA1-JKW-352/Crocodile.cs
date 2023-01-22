/*
 * Name: Kenneth Wallace
 * Date: 1-21-23
 * Brief: concrete crocodile class
 * Description: subclass of the abstract animal class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1_JKW_352
{
    public class Crocodile : Animal
    {
        //Crocodile Default Constructor
        Crocodile()
        {
            setNoise("Snarl.");

            setName("Cid the Crocodile");
            setAge(45);
            setWeight(1900f);
        }

        //Crocodile Paramaterized Constructor
        public Crocodile(string name, int age, float weight)
        {
            setNoise("Snarl.");

            setName(name);
            setAge(age);
            setWeight(weight);
        }
    }
}
