using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pyramid pyramid = Fabryc.CreatePyramid("input.txt");
                Console.WriteLine(pyramid);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
