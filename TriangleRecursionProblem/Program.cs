using System;

namespace TriangleRecursionProblem
{
    class Program
    {
        //https://en.wikipedia.org/wiki/Triangular_number
        /*The pythagorus numbers...
         1,3,6,10,15,21,28,36 ...

         Description:
         We take the index of our position in the series and add the value of the previous index.
             
             */

        static void Main(string[] args)
        {
            Triangle(1,0);
        }

        public static void Triangle(int currentIndex,int previousValue)
        {
            //I have my index
            //I set up my previous value
            //I add the previous value to the value of this index
            int magicNumber = previousValue + currentIndex;
            Console.WriteLine(magicNumber);

            Triangle(++currentIndex, magicNumber);
                                             
        }

    }
}
