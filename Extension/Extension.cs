using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Паттерн_Стратегия.Interface;

namespace Паттерн_Стратегия.Extension
{
    public static class Extension
    {
        public static void DoWorkExtension(this IWorker worker) => Console.WriteLine(worker.DoWork(worker));

        public static void EndWorkExtension(this IWorker worker) => Console.WriteLine(worker.EndWork(worker));
    }
}
