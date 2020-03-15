using System;
using System.Collections.Generic;
using System.Text;

namespace Паттерн_Стратегия.Interface
{
    public interface IWorker
    {
        string Message { get;}
        string DoWork(IWorker worker) => $"{nameof(IWorker.DoWork)} в интерфейсе ({worker.Message})";
        string EndWork(IWorker worker) => $"{nameof(IWorker.EndWork)} в интерфейсе ({worker.Message})";
    }
}
