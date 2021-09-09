using System;

namespace rastreio
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo;

            //Console.WriteLine("Digite ou cole o codigo:");
           // codigo = Console.ReadLine();

            try
            {
                var result = new Correios.NET.Services().GetPackageTracking(args[0]);


                foreach (var track in result.TrackingHistory)
                    Console.WriteLine(" \r\n  {0:dd/MM/yyyy HH:mm} - {1} - {2} - {3}", track.Date, track.Location, track.Status, track.Details);
            }
            catch
            {

                Console.WriteLine("Aguardando postagem pelo remetente!");
            }
           

            Console.ReadLine();
        }
    }
}
