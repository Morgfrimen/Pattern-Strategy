using System;
using System.Collections.Generic;
using System.Text;
using Паттерн_Стратегия.Interface;

namespace Паттерн_Стратегия.Logical
{
    public class MediumWorker : IWorker
    {
        public string Message => nameof(MediumWorker);
    }
}
