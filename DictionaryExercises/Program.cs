using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> iDNumbers = new List<int>();
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
            string input;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names
            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    names.Add(newStudent);
                }

            } while (!Equals(newStudent, ""));

            // Get student ID
            foreach (string name in names)
            {
                Console.WriteLine("ID for " + name + ": ");
                input = Console.ReadLine();
                int iD = int.Parse(input);
                iDNumbers.Add(iD);
            }
            
            // Fill dictionary
            for (int i = 0; i < names.Count; i++)
            {
                students.Add(iDNumbers[i], names[i]);
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
        }
    }
}
