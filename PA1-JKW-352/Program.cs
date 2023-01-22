/*
 * Name: Kenneth Wallace
 * Date: 1-21-23
 * Brief: main driver for program
 * Description: calls upon the world method for Animal class interactions
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1_JKW_352
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize a world object
            World world = new World();

            //Calling upon the power of The World class
            world.animalMenu();
        }
    }
}
