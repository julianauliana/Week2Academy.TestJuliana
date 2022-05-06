using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Academy.Test.Handler
{
    public class CEOHandler : AbstractHandler
    {
        public override string Handle(Spese importo)
        {
            if (importo.Importo > 1001 && importo.Importo< 2500)
                return $" CEO - importo: {importo.Importo}";
            else
                return base.Handle(importo);
        }
    }
}
