using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Паттерн_Стратегия.Extension;
using Паттерн_Стратегия.Interface;
using Паттерн_Стратегия.Logical;

namespace Паттерн_Стратегия
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Run {nameof(StartProgram)}");
            new IziWork().DoWorkExtension();

            AsyncRunWorker asyncRunWorker = new AsyncRunWorker();

            Console.WriteLine(nameof(asyncRunWorker.CreateClasesAsync));
            asyncRunWorker.CreateClasesAsync();


            Console.ReadLine();
        }
    }
}
