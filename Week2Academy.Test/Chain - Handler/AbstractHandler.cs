using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Test.Handler
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler { get; set; }

        public virtual string Handle(Spese spesa)
        {
            if (_nextHandler != null)
                return _nextHandler.Handle(spesa);

            else
                return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;

        }

       
    }
}
