using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Test.Handler
{
    public class ManagerHandler : AbstractHandler
    {
        
        public override string Handle(Spese importo)
        {
            if (importo.Importo <= 400)
                return $" Manager - importo: {importo.Importo}";
            else
            return base.Handle(importo);
        }
    }
}
