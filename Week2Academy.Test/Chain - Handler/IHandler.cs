using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Test.Handler
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        string Handle(Spese spesa);

    }
}
