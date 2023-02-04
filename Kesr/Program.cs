using System.Text.RegularExpressions;

namespace Kesr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kesr ededi daxil edin-");
            double kesr = double.Parse(Console.ReadLine());

            //Console.Write("kesr hissede nece eded var-");

            //int kesrsay =int.Parse( Console.ReadLine());
            //int onluq = (int)Math.Pow(10, kesrsay);
            double b = kesr % 1;

            int f = kesr.ToString().Split('.')[1].Length;
            int d= (int) Math.Pow(10, f);
            int tam = Convert.ToInt32(kesr);
            int qaliq= Convert.ToInt32(b*d);

            if (b < 0.5)

                Console.WriteLine($"{qaliq}.{tam}");

            else
                Console.WriteLine($"{qaliq}.{tam - 1}");

            //string w = Convert.ToString(b);
            //string e = w.Replace("0.", string.Empty);
            //int f= Convert.ToInt32(e);
            //double c = b * onluq;
            //int g = Convert.ToInt32(c);
            //Console.WriteLine($"{kesrsay}.{h}");
            //Console.WriteLine(f);






        }
    }
}