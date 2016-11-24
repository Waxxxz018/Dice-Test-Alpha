using System;
using System.Security.Cryptography;

namespace Dice_Test_Alpha
{
    internal class Program
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        public enum Dice
        {
            /// <summary>
            /// This can be considered a double-sided coin;
            /// used to delimit a 50/50 probability.
            /// </summary>
            D2 = 2,

            /// <summary>
            /// A Tetrahedron
            /// A 4 Sided Die
            /// </summary>
            D4 = 4,

            /// <summary>
            /// A Cube
            /// A 6 Sided Die
            /// </summary>
            D6 = 6,

            /// <summary>
            /// A Octahedron
            /// A 8 Sided Die
            /// </summary>
            D8 = 8,

            /// <summary>
            /// A Pentagonal Trapezohedron
            /// A 10 Sided Die
            /// </summary>
            D10 = 10,

            /// <summary>
            /// A Dodecahedron
            /// A 12 Sided Die
            /// </summary>
            D12 = 12,

            /// <summary>
            /// A Icosahedron
            /// A 20 Sided Die
            /// </summary>
            D20 = 20,

            /// <summary>
            /// A Rhombic Triacontahedron
            /// A 30 Sided Die
            /// </summary>
            D30 = 30,

            /// <summary>
            /// A Icosakaipentagonal Trapezohedron
            /// A 50 Sided Die
            /// </summary>
            D50 = 50,

            /// <summary>
            /// A Pentagonal Hexecontahedron
            /// A 60 Sided Die
            /// </summary>
            D60 = 60,

            /// <summary>
            /// A Zocchihedron
            /// A 100 Sided Die
            /// </summary>
            D100 = 100
        };

        public static byte RollDie(int numberofDice, byte numberSides)
        {
            if (numberofDice <= 0)
                throw new ArgumentOutOfRangeException("numberofDice");

            if (numberSides <= 0)
                throw new ArgumentOutOfRangeException("numberSides");

            // Create a byte array to hold the random value.
            byte[] randomNumber = new byte[1];

            // Fill the array with a random value.
            rngCsp.GetBytes(randomNumber);

            return (byte)((randomNumber[0] % numberSides) + 1);
        }

        private static void Main(string[] args)
        {
            var r = RollDie(1, Convert.ToByte(Dice.D20));
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
