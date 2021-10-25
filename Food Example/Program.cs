using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string chefType;
            var chefClass = new ChefTeller();

            Console.WriteLine("Chef origin : ");
            chefType = Console.ReadLine();
            if (StringCheck(chefType) == true)
            {
                chefClass.Foods(chefType);
            }
            else
                Console.WriteLine("You inserted something wrong");
        }


        static bool StringCheck(string _chefType)
        {
            if (_chefType is string)
                return true;
            else
                return false;
        }
    }
}
