


using System;
using System.IO;




namespace fileHandling
{
    class fileHandling
    {
        static void Main(string[] args)
        {
            string lineIn;




            FileStream fs = new FileStream(@"H:\Modules\Year 1\Semester 2\Programming 2 sem2 yr1\idk\readThis.txt", FileMode.Open, FileAccess.Read);

            StreamReader inputStream = new StreamReader(fs);

            lineIn = inputStream.ReadLine();

            Console.WriteLine(lineIn);

            inputStream.Close();

        }
    }
}
