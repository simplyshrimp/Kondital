namespace Kondital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programDone = false;
            double vægt;
            int hvilePuls, maxPuls/*, alder, køn*/;
            //tilfø køn
            do
            {
                Console.Clear();
                try
                {
                    //inputs
                    /*Console.WriteLine("er du en kvinde eller en mand?");
                    Console.WriteLine(@"
[1] kvinde
[2] mand");
                    køn = Convert.ToInt32(Console.ReadLine());
                    if (køn != 1 && køn != 2)
                    {
                        throw new InvalidOperationException("du kan kun skrive et eller to for køn");
                    }
                    Console.Write("hvor gammel er du?: ");
                    alder = Convert.ToInt32(Console.ReadLine());*/
                    Console.Write("skriv din vægt i kg: ");
                    vægt = Convert.ToDouble(Console.ReadLine());
                    Console.Write("din hvilepuls: ");
                    hvilePuls = Convert.ToInt32(Console.ReadLine());
                    Console.Write("din maxpuls: ");
                    maxPuls = Convert.ToInt32(Console.ReadLine());

                    //udregninger of udskrivninger
                    double kondital = Kondital.BeregnKondital(hvilePuls, maxPuls);
                    Console.WriteLine($"dit kondital er: {Math.Round(kondital)} ml/kg/min");
                    double maxIltoptagelse = Kondital.BeregnIltoptagelse(kondital, vægt);
                    Console.WriteLine($"din max iltoptagelse er {Math.Round(maxIltoptagelse, 1)} l/ml");
                    programDone = true;
                    Console.ReadKey();
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    continue;
                    throw;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    continue;
                }
            }
            while (!programDone);
        }
    }
}
