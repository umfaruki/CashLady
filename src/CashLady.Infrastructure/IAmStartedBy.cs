﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashLady.Infrastructure
{
    public interface IAmStartedBy<T> where T : Message
    {
        void Handle(T message);
    }
}
