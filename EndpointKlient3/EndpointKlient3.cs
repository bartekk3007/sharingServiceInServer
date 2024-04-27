using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace EndpointKlient3
{
    public class HandlerZad6 : EndpointKlient3.ServiceReference1.IZadanie6Callback
    {
        public void Wynik(int wyn)
        {
            Console.WriteLine($"Wynik zwrotny: {wyn}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var client5 = new EndpointKlient3.ServiceReference1.Zadanie5Client();
            Console.WriteLine(client5.ScalNapisy(client5.ScalNapisy("zadanie", " dziala"), " dobrze"));
            Console.ReadKey();
            ((IDisposable)client5).Dispose();

            var client6 = new EndpointKlient3.ServiceReference1.Zadanie6Client(new InstanceContext(new HandlerZad6()));
            client6.Dodaj(1, 1);
            Console.ReadKey();
            ((IDisposable)client6).Dispose();
        }
    }
}
