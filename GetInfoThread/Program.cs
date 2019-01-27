using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetInfoThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;

            Console.WriteLine("Имя потока: {0}", t.Name);
            t.Name = "Метод Main";
            Console.WriteLine("Имя потока: {0}", t.Name);

            Console.WriteLine("Запущен ли поток: {0}", t.IsAlive);
            Console.WriteLine("Приоритет потока: {0}", t.Priority);
            Console.WriteLine("Статус потока: {0}", t.ThreadState);

            Console.WriteLine("Домен приложения: {0}", Thread.GetDomain().FriendlyName);
            Console.ReadLine();
        }
    }
}
