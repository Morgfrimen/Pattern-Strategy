using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Паттерн_Стратегия.Extension;
using Паттерн_Стратегия.Interface;

namespace Паттерн_Стратегия.Logical
{
    internal class AsyncRunWorker
    {
        private void CreateWorker()
        {
            Console.WriteLine("DoWorkers");

            List<IWorker> _workers = new List<IWorker>()
            {
                new HardWork(),
                new MediumWorker(),
                new IziWork()
            };

            foreach (IWorker worker in _workers)
            {
                worker.DoWorkExtension();
            }

            Console.WriteLine("EndWorkers");

            foreach (IWorker worker in _workers)
            {
                worker.EndWorkExtension();
            }

        }

        internal async void CreateClasesAsync()
        {
            await Task.Run(CreateWorker);
        }
    }
}
