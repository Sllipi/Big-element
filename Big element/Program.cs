using System;
using System.Linq;

namespace Big_element
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte  randMin = 1;
            byte  randMax = 10;
            byte[] bigElement = new byte[30];
            byte identicalElement = 0;
            for (byte i = 0; i < bigElement.Length; i++)
            {
                bigElement[i] = (byte)rand.Next(randMin, randMax);
                Console.Write(bigElement[i] + " ");
            }
            byte maxElement = bigElement.Max<byte>();
            for (byte j = 0; j < bigElement.Length; j++)
            {
                if (maxElement == bigElement[j])
                {
                    identicalElement++;
                }
            }
            Console.WriteLine($"\nНаибольшой элемент = {maxElement}, повторений = {identicalElement}");
        }
    }
}
