using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Паттерн_Стратегия.Interface;

namespace Паттерн_Стратегия.Logical
{
    public class IziWork : IWorker
    {
        public string Message => nameof(IziWork);
    }
}
