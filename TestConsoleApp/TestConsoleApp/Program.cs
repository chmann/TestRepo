using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShiftChars s = new ShiftChars("This is a test shift message. What does this look like when shifted by 9?" +
            "\nSetting 0: ON \nSetting 1: OFF \nSetting 2:HIGH");
            Console.WriteLine("Message when shifted By -9");
            String shifted = s.ShiftByConstant(-9);
            Console.WriteLine(shifted);
            //s.Message = "]qr|)r|)j)}n|})|qro})vn||jpn7)`qj})mxn|)}qr|)uxxt)urtn)?qnw)|qro}nm)k?)BH\n}}rwp)9C)XW?\n}}rwp):C)XOO?\n}}rwp)<C?QRPQ";
            s.Message = shifted;
            Console.WriteLine("Reverses back to");
            Console.WriteLine(s.ShiftByConstant(9));

            StreamReader sr = new StreamReader("source1.txt");
            StreamWriter sw = new StreamWriter("source1_encoded.txt");

            String line;


            try
            {
                while (sr.Peek() >= 0)
                {
                    line = sr.ReadLine();
                    s.Message = line;
                    sw.WriteLine(s.ShiftByConstant(-9));

                }
                sw.Flush();
                sw.Close();

                sr = new StreamReader("source1_encoded.txt");
                sw = new StreamWriter("source1_decoded.txt");
                String decoded;
                while (sr.Peek() >= 0)
                {
                    line = sr.ReadLine();
                    s.Message = line;
                    decoded = s.ShiftByConstant(9);
                    sw.WriteLine(decoded.Replace("God", "the Flying Spaghetti Monster"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("EL EXCEPTIONO OCCURREDO!!!!!\n" + e.ToString());
            }
            finally
            {
                sw.Flush();
                sw.Close();
            }



            //DateTime date = DateTime.Parse("1/2/1974 6:07PM");
            //DateTime date2 = DateTime.Parse("1/2/2013 8:23PM");
            //Console.WriteLine("Setting File Date to: " + date.ToString());
            //File.SetCreationTime("CreatedAt0631pm010213.txt", date2);
            //File.SetLastAccessTime("CreatedAt0631pm010213.txt", date);
            //File.SetLastWriteTime("CreatedAt0631pm010213.txt", date);

            Console.WriteLine("PRESS ENTER TO CONTINUE...");
            Console.ReadLine();
        }
    }
}
