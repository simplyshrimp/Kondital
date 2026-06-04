namespace Kondital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vægt;
            int hvilePuls, maxPuls;
            try
            {
                Console.Write("skriv din vægt i kg: ");
                vægt = Convert.ToDouble(Console.ReadLine());
                Console.Write("din hvilepuls: ");
                hvilePuls = Convert.ToInt32(Console.ReadLine());
                Console.Write("din maxpuls: ");
                maxPuls = Convert.ToInt32(Console.ReadLine());

                int kondital = Kondital.BeregnKondital(hvilePuls, maxPuls);
                Console.WriteLine($"dit kondital er: {kondital} ml/kg/min");
                double maxIltoptagelse = Kondital.BeregnIltoptagelse(kondital, vægt);
                Console.WriteLine($"din max iltoptagelse er {maxIltoptagelse} l/ml");
                //spørg om benævnelsen
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
