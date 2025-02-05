// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace Cats
{
    public class BlackCat
    {
        //* without  executing each class here with Main method while trying to understand them. None matters.
        //! Run this code please. Do not just make assumptions
        class Program
        {
            static void Main(string[] args)
            {
                myCuteCat = new BlackCat(
                    "randomName",
                    100,
                    "this is a cute cat with a randomname",
                    "no memory"
                );
                mySecondCat = new OrangeCat(
                    "randomName",
                    100,
                    "this is a cute cat with a randomname",
                    " this guy is crazy"
                );
                Console.WriteLine(myCuteCat.ToString());
                Console.WriteLine(mySecondCate.ToString());
            }
        }

      public class BlackCat
    {
            Food = " cat food";
            Smell = " cat smell";
            Price = "priceless";
        public BlackCat(String name, int Age, String Description, String Memory)
        {
            //* validate these
            
            this.Name = name;
            this.Age = Age;
            this.Description = Description;
            this.Memory = Memory;
        }
    }
    public class OrangeCat
    {
        Food = " cat food";
            Smell = " cat smell";
            Price = "priceless";
        public OrangeCat(String name, int Age, String Description, String Memory)
        {
            //* validate these
            
            this.Name = name;
            this.Age = Age;
            this.Description = Description;
            this.Memory = Memory;
        }
    }
}
}