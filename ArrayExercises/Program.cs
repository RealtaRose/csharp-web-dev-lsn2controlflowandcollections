using System;

namespace ArrayExercises
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] simpleArray = {1, 1, 2, 3, 5, 8};
            for (int i = 1; i < simpleArray.Length; i += 2) {
                Console.WriteLine(simpleArray[i]);
            }

        }
    
    }

}
