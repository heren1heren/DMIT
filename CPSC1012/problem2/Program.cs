﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//when you create a class within a project, by default,
//  the namespace for the class is the project name

namespace Animals
{
    //the definition of the class name
    //  a) access level
    //       private nothing outside of the class has acces to items
    //          within the class
    //       internal access to the class is limited to programming
    //          within the project
    //       public access to the class is open to an outside user
    //          of the class
    //  b) the key word class
    //  c) the programmer/developer define name of the class

    class Program {
        static void Main(string[] args) {

            myDog = new Dog("big boy", -1, "heren", "lastName");

            Console.Write(myDog.ToString());
        }
    }
    public class Dog // public mae the class avaiable to be use outside its block scope
    {
     
        public Dog(String Breed, int Age, String Name, String OwnerFirstName, String OwnerLastName) {

            /* if there is no code  in your default constructor assigning
               values to your data members, the data will be set to their system defaults
             the default constructor is often compared to the 'system' constructor
             
                         this is a default constructor
             SINCE our properties have business rules (validation)
              our "default" constructor should ensure that data members within
              our class instance passes any validation
              
             Consideration!!!!
             does the property have any validation htat would be violated
              by just using the system datatype defaults?
              
             in this example Name, FirstName and LastName cannot be null, empty or jsut blanks
             thus, a literal value was assigned that would pass the valdiation
              
             Age has a validation but the system datatype default would survice
            */

            //*Validation part
             if(string.IsNullOrEmpty(name)) {
                throw new Exception("aoeuaoeueaous;}{tp}");

             }
            this.Name = Name;
             

//* default values
  someDefaultValues = "hello I am a default value from the class dog, you can try to access me by calling: Dog.someDefaultValues"
//* parameter values
this.Breed = Breed;
this.Age = Age;
this.OwnerFirstName = OwnerFirstName;
this.OwnerLastName = OwnerLastName;

        }
        //declares the characteristics of a Dog
        //each characteristic is a variable
        //a valid characteristic has a valid C# datatype
        //NOTE: a class can have various datatypes

        //Data Members (aka fields, variables, value,....)

        //if you wish to encapsulate your data in a secure fashion
        //  your characteristics have an access type of private
        //* these properties are hidden from users and cannot be seen or accessed from outside the class Dog
        //* if there is a private property. their name should be started with a '_'
        private string _Name; 
        private double _Age; //omitting the access type for your variable means that the
                             //     access type defaults to private.
        private string _OwnerFirstName;
        private string _OwnerLastName;
        private string _Breed;

        //Behaviours (aka methods)

        //mutator (setter)
        public void SetName(string name)
        {
            _Name = name;
        }
        public void SetAge(double age)
        {
            _Age = age;
        }

        //accessor (getter)
        public string GetName()
        {
            return _Name;
        }

        public double GetAge()
        {
            return _Age;
        }

        //methods that do "stuff" against the data contained within the class
        //if the data is within the instance ALREADY then you DO NOT need to
        //  pass the data in with the method
        public void CelebrateBrithday()
        {
            //this method does not take in any parameters BECAUSE the data
            //  is AREADY contained within the instance
            _Age = Math.Floor(++_Age);  //using ++Age 4.5 + 1 -> 5.5 -> .Floor(5.5) -> 5
                                        //using Age++ .Floor(4.5) -> 4 -> 4.5 + 1 -> 5.5 
        }
           public void CelebrateBrithday(int newAge)
        {
            //this method does not take in any parameters BECAUSE the data
            //  is AREADY contained within the instance
            _Age = newAge;  //using ++Age 4.5 + 1 -> 5.5 -> .Floor(5.5) -> 5
                                        //using Age++ .Floor(4.5) -> 4 -> 4.5 + 1 -> 5.5 
        }
        //Each class has a given set of methods
        //ONe such method is called ToString()
        //this method can of overridden with your OWN version
        //* method property
        public override string ToString()
        {
            return $"{_Name},{_Age},{_OwnerFirstName},{_OwnerLastName},{_Breed}";
        }

        //Properties

        //consider this a special type of method
        //a property is an interface to private data member within your class definition
        //a property is associated with a SINGLE piece of data
        //a property is public
        //a property MUST have an accessor (getter)
        //  the getter returns a piece of data
        //  the getter is public
        //a property MAY have a mutator (setter)
        //  the setter assigns a value to your private data member
        //  a setter may be either public (default) or private
        //  if the setter is private, it can be used from within the class
        //      it CANNOT be used by an outsider user
        //  a property without a setter is referred to as "readonly"
        //PROPERTIES DO NOT HAVE A PARAMETER LIST!!!!!!! NOT EVEN THE ( )!!!!!!
        //properties use a special key word to refer to the incoming data value
        //      that key word is -> value

        //syntax property: accesstype datatype propertyname
        //                { 
        //                    get { ... coding block ...}
        //                   [[private] set { ... coding block ...}]
        //                }

        //there are two ways to code a property
        //  a) fully-implemented property
        //  b) auto-implemented property

        //Fully-implemented property
        //a fully-implemented property will have an associated data member
        //data is transfer via the property into/out of the data member
        //the data is NOT store in the property
        //a property can have additional logic within its coding
        //  this logic is usually validation of some type

        //instead of using a getter and setter method, Name could be
        //  coded using a property
        //* value property
        public string Name
        {
            //accessor
            get { return _Name; }  //retreives the current value store in the private data member
            //mutator
            set { _Name = value; } //stores the incoming data into the private data member
        }

        public double Age
        {
            //rule: age must be zero or greater
            get { return _Age; }  //retreives the current value store in the private data member
            set 
            { 
                if (value < 0)
                {
                    throw new Exception($"{value} as an Age is invalid. Must be 0 to greater.");
                }
                _Age = value; 
            } //stores the incoming data into the private data member
        }

        public string OwnerFirstName
        {
            get { return _OwnerFirstName; }
            set 
            {
                //validation of the incoming data
                //rule: the string cannot be null, empty or content just blanks
                if (string.IsNullOrWhiteSpace(value))
                {
                    //bad data
                    //cast an error message
                    //within a class, casting error messages is done using Exceptions
                    //if this exception is throw, then the processing in the class
                    //  is terminated and the system returns to where the property
                    //  was being used.
                    //  ONE DOES NOT USE CONSOLE.WRITELINE WITHIN THE CLASS TO 
                    //      DISPLAY ERROR MESSAGES!!!!!!!!!!!!!!!!!!!!!!!!!
                    throw new Exception("You are missing the owner first name.");
                }
                //since the error would through an error and exit the proper if
                //  there was an error; the else of the conditional statement
                //  is optionally

                //else
                //{
                    _OwnerFirstName = value;
                //}
            }
        }

        public string OwnerLastName
        {
            get { return _OwnerLastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("You are missing the owner first name.");
                }
                _OwnerLastName = value;
            }
        }

        public string Breed
        {
            //accessor
            get { return _Breed; }  //retreives the current value store in the private data member
            //mutator
            set { _Breed = value; } //stores the incoming data into the private data member
        }

        //  a property without a setter is referred to as "readonly"
        public string FullName
        {
            //this property will use the first and last name to create a string
            //  that contains the owner's full name

            //Don's Rule: wherever possible within the class coding, use the property
            //              to acces your data.

            get { return OwnerLastName + "," + OwnerFirstName; }

            //NOTE: no set!!!!!!!!
        }
        //constructors
//  these are used during the creation of an instance (occurrence) of your
//    class during your program execution
 
//a class DOES NOT need a constructor physically code for it
//if a class DOES NOT have a physically code constructor method then
//      the system will create the instance of your class
//      using the system default values for your field datatype
 
//HOWEVER!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//IF YOU CODE A CONSTRUCTOR PHYSICALLY FOR YOUR CLASS, YOU ARE TOTALLY
//      RESPONSIBLE FOR ANY AND ALL CONSTRUCTORS OF THE CLASS
//=!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 
//how many constructors can a class have? Many
 
//the purpose of the constructor is to ensure that the user of the class
//  gets a expected usable valid instance of the class
 
//there is generally two types of constructors coded for a class
//you DO NOT need to code both!!!
 
//*syntax for a general constructor
//   public className( [list of parameters] ) { coding block }
 
//access: public
//NO RETURN DATATYPE
//name: is your class name
//parameters: are optional
//coding block: is C# code
 
//Default constructor
//this constructor will not have any parameters
//the assumption is the data will have either
//  a) the system datatype defualts
//  b) any assigned literal values to ensure property validation is meet
    }

}



/*
*Write a class with no constructors that has 5 public pp, 1 private pp. 
*/

namespace Cats
{
    public class BlackCat {

        String name;
        int Age;
        String Description;
       


    }

    public class OrangeCat {

        String name;
        int Age;
        String Description;
    }
}


/*
* Write the same class with a constructor that has the same pp. this constructor needs to have at least 2 "default values"
*/
namespace Cats
{
    public class BlackCat {

            //* without  executing each class here with Main method while trying to understand them. None matters.
            //! Run this code please. Do not just make assumptions
        class Program {
          
          static void Main(string[] args) {
             
             myCuteCat = new BlackCat('randomName', 100, 'this is a cute cat with a randomname','no memory');
             mySecondCat = new OrangeCat('randomName', 100, 'this is a cute cat with a randomname',' this guy is crazy');
            Console.WriteLine(myCuteCat.ToString());
            Console.WriteLine(mySecondCate.ToString());
          }

        }
       public BlackCat(String name, int Age, String Description, String Memory) {
        // default values
        Food = " cat food";
        Smell = " cat smell";
        Price = "priceless"
        this.Name = name;
        this.Age = Age;
        this.Description = Description;
        this.Memory = Memory;
        
        
       }
       
       

    }

    public class OrangeCat {
       public OrangeCat(String name, int Age, String Description, String Memory) {
        //* validate these
        Food = " cat food";
        Smell = " cat smell";
        Price = "priceless"
        this.Name = name;
        this.Age = Age;
        this.Description = Description;
        this.Memory = Memory;
       }
    }
}
