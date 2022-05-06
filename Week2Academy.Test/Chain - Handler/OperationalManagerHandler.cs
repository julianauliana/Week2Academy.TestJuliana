using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Test.Handler
{
    public class OperationalManagerHandler : AbstractHandler
    {
        public override string Handle(Spese importo)
        {
            if (importo.Importo > 401 && importo.Importo <= 1000)
                return $" Operational Manager - importo: {importo.Importo}";
            else
                return base.Handle(importo);
        }
    }
}
