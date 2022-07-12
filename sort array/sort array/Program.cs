using System;

namespace sort_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //We will create a simple one integer array having values  0, 2, 8, 6, 7 in the array . 
            //We will take two for loops; first, a for loop for checking the first position of an array and iterating the length of the array.
            //The second loop starts with the i+1 position and iterates the length of the array.
            int[] intArray = new int[] { 0, 2, 8, 6, 7};
            int temp = 0;

            for (int i = 0; i <= intArray.Length-1; i++)
            {
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in Ascending order");
            foreach(var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
