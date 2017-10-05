using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Day_4
{
    class Cat
    {
        //States - The private modifier means that it stays inside this class.
        //Different types of states.
        //Fields
       
        private string name;
        //Properties are part of the program that let us interact with the characteristics of the fields.
        //Properties are the mama bear/bouncer for the fields.
        public string Name //Property is upper case name with get set. 
        {
            get { return this.name; } // 
            set { this.name = value; }

        }




        //Behaviors
        //Constructors - The constructor will be cat, it's treated like a method. Each class needs a constructor so that when we are in another program we can create an object.
        public Cat()
        {
            //default constructor, it takes no parameters. 
        }
    }
}
