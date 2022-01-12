using System;
using System.Threading;

namespace TransparentRabbitStartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(() =>
            {
                new MainWindow().ShowDialog();
            });

            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            Console.ReadKey();
        }
    }
}