using System;

namespace Praktika_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Human human = new Human
                {
                    Age = -1
                };
            }
            catch (AgeException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
